using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace activity3
{
    internal static class Db
    {
        private const string ConnectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=activity_DB;Integrated Security=True;TrustServerCertificate=True;";

        public static readonly string[] Categories = { "Writing", "Paper", "Art", "Bags", "Tools" };

        private static string PrefixFor(string category)
        {
            switch (category)
            {
                case "Writing": return "WRT";
                case "Paper": return "PPR";
                case "Art": return "ART";
                case "Bags": return "BAG";
                case "Tools": return "TLS";
                default: return "PRD";
            }
        }

        public static bool UsernameExists(string username)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @u", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static void CreateUser(string username, string password)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "INSERT INTO users (username, password_hash, role) VALUES (@u, @p, 'user')", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", Hash(password));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static bool ValidateUser(string username, string password)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT password_hash FROM users WHERE username = @u", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                {
                    return false;
                }

                return string.Equals((string)result, Hash(password), StringComparison.Ordinal);
            }
        }

        public static DataTable GetProducts(string search)
        {
            const string sql = @"
                SELECT id AS No, code AS Code, product_name AS Product,
                       category AS Category, qty AS Qty, price AS Price
                FROM products
                WHERE @like = '%%'
                   OR product_name LIKE @like
                   OR code LIKE @like
                   OR category LIKE @like
                ORDER BY id";

            var table = new DataTable();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@like", "%" + (search ?? "") + "%");
                adapter.Fill(table);
            }

            return table;
        }

        public static DataRow GetProduct(int id)
        {
            const string sql = @"
                SELECT id AS No, code AS Code, product_name AS Product,
                       category AS Category, qty AS Qty, price AS Price
                FROM products
                WHERE id = @id";

            var table = new DataTable();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@id", id);
                adapter.Fill(table);
            }

            return table.Rows.Count == 0 ? null : table.Rows[0];
        }

        public static string GenerateCode(string category)
        {
            string prefix = PrefixFor(category);

            int count;
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM products WHERE code LIKE @p", conn))
            {
                cmd.Parameters.AddWithValue("@p", prefix + "-%");
                conn.Open();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }

            int n = count + 1;
            while (true)
            {
                string code = prefix + "-" + n.ToString("000");
                if (!CodeExists(code))
                {
                    return code;
                }
                n++;
            }
        }

        private static bool CodeExists(string code)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM products WHERE code = @c", conn))
            {
                cmd.Parameters.AddWithValue("@c", code);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static void InsertProduct(string code, string name, string category, int qty, decimal price)
        {
            const string sql = @"
                INSERT INTO products (code, product_name, category, qty, price)
                VALUES (@code, @name, @category, @qty, @price)";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@price", price);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateProduct(int id, string name, string category, int qty, decimal price)
        {
            const string sql = @"
                UPDATE products
                SET product_name = @name, category = @category, qty = @qty, price = @price
                WHERE id = @id";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@price", price);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteProduct(int id)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("DELETE FROM products WHERE id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static Dictionary<string, int> GetCategoryTotals()
        {
            var totals = new Dictionary<string, int>();

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(
                "SELECT category, SUM(qty) FROM products GROUP BY category", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totals[reader.GetString(0)] = reader.GetInt32(1);
                    }
                }
            }

            return totals;
        }

        public static string Hash(string text)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}