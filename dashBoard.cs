using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace activity3
{
    public partial class dashBoard : Form
    {
        private const int PageSize = 10;

        private int? _editingId;
        private int _currentPage = 1;

        private DataGridViewButtonColumn _colEdit;
        private DataGridViewButtonColumn _colDelete;
        private FlowLayoutPanel _pager;

        public dashBoard() : this("Admin")
        {
        }

        public dashBoard(string username)
        {
            InitializeComponent();

            lblUser.Text = "Logged in: " + username;
            btnLogout.Click += btnLogout_Click;

            SetupProductGrid();
            SetupProductForm();
            SetupPager();
            productGrid.CellContentClick += productGrid_CellContentClick;

            btnProducts.Click += (s, e) => { RefreshAll(); ShowFirstProduct(); };
            btnAdd.Click += (s, e) => ShowEditor(null);
            btnUpdate.Click += btnSave_Click;
            btnCancel.Click += (s, e) => ShowFirstProduct();
            txtSearch.TextChanged += (s, e) => { _currentPage = 1; LoadProducts(); };

            RefreshAll();
            ShowFirstProduct();

            Shown += (s, e) =>
            {
                productGrid.ClearSelection();
                ActiveControl = null;
            };
        }

        private void SetupProductGrid()
        {
            productGrid.Columns.Remove(colActions);

            _colEdit = new DataGridViewButtonColumn
            {
                Name = "colEdit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100,
                Resizable = DataGridViewTriState.False
            };

            _colDelete = new DataGridViewButtonColumn
            {
                Name = "colDelete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100,
                Resizable = DataGridViewTriState.False
            };

            foreach (DataGridViewButtonColumn col in new[] { _colEdit, _colDelete })
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            productGrid.Columns.Add(_colEdit);
            productGrid.Columns.Add(_colDelete);

            colQty.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPrice.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void SetupProductForm()
        {
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(Db.Categories);

            lblSupplier.Visible = false;
            cboSupplier.Visible = false;

            btnUpdate.Text = "Save";
        }

        private void SetupPager()
        {
            lblPages.Visible = false;

            _pager = new FlowLayoutPanel
            {
                AutoSize = true,
                WrapContents = false,
                FlowDirection = FlowDirection.LeftToRight,
                Location = new Point(lblPages.Location.X, lblPages.Location.Y - 4),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Margin = Padding.Empty
            };

            pnlContent.Controls.Add(_pager);
            _pager.BringToFront();
        }

        private void BuildPager(int totalPages)
        {
            _pager.Controls.Clear();

            _pager.Controls.Add(MakePageButton("<", _currentPage > 1,
                () => GoToPage(_currentPage - 1), false));

            for (int p = 1; p <= totalPages; p++)
            {
                int page = p;
                _pager.Controls.Add(MakePageButton(page.ToString(), true,
                    () => GoToPage(page), page == _currentPage));
            }

            _pager.Controls.Add(MakePageButton(">", _currentPage < totalPages,
                () => GoToPage(_currentPage + 1), false));
        }

        private static Button MakePageButton(string text, bool enabled, Action onClick, bool current)
        {
            var button = new Button
            {
                Text = text,
                Width = 32,
                Height = 28,
                Margin = new Padding(2),
                Enabled = enabled,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            button.FlatAppearance.BorderSize = 0;

            if (current)
            {
                button.BackColor = Color.FromArgb(37, 99, 235);
                button.ForeColor = Color.White;
            }

            button.Click += (s, e) => onClick();
            return button;
        }

        private void GoToPage(int page)
        {
            _currentPage = page;
            LoadProducts();
        }

        private void RefreshAll()
        {
            LoadProducts();
            LoadCategoryTotals();
        }

        private void LoadProducts()
        {
            try
            {
                DataTable table = Db.GetProducts(txtSearch.Text.Trim());

                int lowStock = 0;
                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToInt32(row["Qty"]) < 10)
                    {
                        lowStock++;
                    }
                }

                int totalPages = Math.Max(1, (int)Math.Ceiling(table.Rows.Count / (double)PageSize));
                if (_currentPage > totalPages)
                {
                    _currentPage = totalPages;
                }
                if (_currentPage < 1)
                {
                    _currentPage = 1;
                }

                productGrid.Rows.Clear();

                int start = (_currentPage - 1) * PageSize;
                int end = Math.Min(start + PageSize, table.Rows.Count);

                for (int i = start; i < end; i++)
                {
                    DataRow row = table.Rows[i];
                    productGrid.Rows.Add(
                        row["No"].ToString(),
                        row["Code"].ToString(),
                        row["Product"].ToString(),
                        row["Category"].ToString(),
                        Convert.ToInt32(row["Qty"]).ToString(),
                        "₱" + Convert.ToDecimal(row["Price"]).ToString("#,##0.00"));
                }

                lblTotal.Text = "Total items: " + table.Rows.Count;
                lblLow.Text = "Low stock: " + lowStock;

                BuildPager(totalPages);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load products: " + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadCategoryTotals()
        {
            try
            {
                Dictionary<string, int> totals = Db.GetCategoryTotals();

                lblWritingQty.Text = CategoryText(totals, "Writing");
                lblPaperQty.Text = CategoryText(totals, "Paper");
                lblArtQty.Text = CategoryText(totals, "Art");
                lblBagsQty.Text = CategoryText(totals, "Bags");
                lblToolsQty.Text = CategoryText(totals, "Tools");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load categories: " + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static string CategoryText(Dictionary<string, int> totals, string category)
        {
            int qty;
            if (!totals.TryGetValue(category, out qty))
            {
                return "0";
            }

            return qty < 10 ? qty + " low" : qty.ToString();
        }

        private void ShowEditor(int? id)
        {
            _editingId = id;

            if (id == null)
            {
                lblEditTitle.Text = "Add product";
                txtName.Text = "";
                cboCategory.SelectedIndex = 0;
                txtQty.Text = "0";
                txtPrice.Text = "0.00";
            }
            else
            {
                DataRow row = Db.GetProduct(id.Value);
                if (row == null)
                {
                    MessageBox.Show("That product no longer exists.", "Edit product",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAll();
                    return;
                }

                lblEditTitle.Text = "Edit product";
                txtName.Text = row["Product"].ToString();

                int categoryIndex = cboCategory.Items.IndexOf(row["Category"].ToString());
                cboCategory.SelectedIndex = categoryIndex < 0 ? 0 : categoryIndex;

                txtQty.Text = row["Qty"].ToString();
                txtPrice.Text = Convert.ToDecimal(row["Price"]).ToString("0.00", CultureInfo.InvariantCulture);
            }

            pnlEdit.Visible = true;
            txtName.Focus();
        }

        private void ShowFirstProduct()
        {
            DataTable table = Db.GetProducts("");
            if (table.Rows.Count == 0)
            {
                HideEditor();
                return;
            }

            ShowEditor(Convert.ToInt32(table.Rows[0]["No"]));
        }

        private void HideEditor()
        {
            _editingId = null;
            pnlEdit.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                ShowWarning("Product name is required.");
                return;
            }

            if (name.Length > 100)
            {
                ShowWarning("Product name must be 100 characters or fewer.");
                return;
            }

            if (cboCategory.SelectedItem == null)
            {
                ShowWarning("Please choose a category.");
                return;
            }

            int qty;
            if (!int.TryParse(txtQty.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out qty) || qty < 0)
            {
                ShowWarning("Quantity must be a whole number, 0 or higher.");
                return;
            }

            string priceText = txtPrice.Text.Replace("₱", "").Replace(",", "").Trim();
            decimal price;
            if (!decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out price) || price < 0)
            {
                ShowWarning("Price must be a number, 0 or higher.");
                return;
            }

            string category = cboCategory.SelectedItem.ToString();

            try
            {
                if (_editingId == null)
                {
                    string code = Db.GenerateCode(category);
                    Db.InsertProduct(code, name, category, qty, price);
                }
                else
                {
                    Db.UpdateProduct(_editingId.Value, name, category, qty, price);
                }
            }
            catch (Exception ex)
            {
                ShowWarning("Could not save the product: " + ex.Message);
                return;
            }

            HideEditor();
            RefreshAll();
        }

        private void productGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = productGrid.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value);
            string productName = row.Cells[2].Value.ToString();

            if (productGrid.Columns[e.ColumnIndex] == _colEdit)
            {
                ShowEditor(id);
            }
            else if (productGrid.Columns[e.ColumnIndex] == _colDelete)
            {
                DialogResult answer = MessageBox.Show(
                    "Delete \"" + productName + "\"? This cannot be undone.",
                    "Delete product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (answer != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    Db.DeleteProduct(id);
                }
                catch (Exception ex)
                {
                    ShowWarning("Could not delete the product: " + ex.Message);
                    return;
                }

                RefreshAll();

                if (_editingId == id)
                {
                    ShowFirstProduct();
                }
            }
        }

        private static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (answer == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}