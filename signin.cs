using System;
using System.Drawing;
using System.Windows.Forms;

namespace activity3
{
    public partial class signin : Form
    {
        private static readonly Color ErrorColor = Color.FromArgb(190, 18, 60);
        private static readonly Color SuccessColor = Color.FromArgb(22, 163, 74);

        public signin()
        {
            InitializeComponent();

            AcceptButton = btnLogin;
            btnLogin.Click += btnLogin_Click;
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;

            Resize += (s, e) => CenterCard();
            Shown += (s, e) =>
            {
                CenterCard();
                ActiveControl = null;
            };
        }

        private void CenterCard()
        {
            int x = Math.Max(0, (ClientSize.Width - pnlCard.Width) / 2);
            int y = Math.Max(0, (ClientSize.Height - pnlCard.Height) / 2);
            pnlCard.Location = new Point(x, y);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                ShowStatus("Please enter your username and password.", true);
                return;
            }

            try
            {
                if (!Db.ValidateUser(username, password))
                {
                    ShowStatus("Invalid username or password.", true);
                    return;
                }
            }
            catch (Exception ex)
            {
                ShowStatus("Database error: " + ex.Message, true);
                return;
            }

            txtPassword.Clear();
            lblStatus.Text = "";

            Hide();
            using (var dashboard = new dashBoard(username))
            {
                dashboard.ShowDialog();

                if (dashboard.DialogResult != DialogResult.OK)
                {
                    Close();
                    return;
                }
            }

            txtUsername.Clear();
            Show();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var regForm = new register())
            {
                if (regForm.ShowDialog(this) == DialogResult.OK)
                {
                    txtUsername.Text = regForm.RegisteredUsername;
                    txtPassword.Clear();
                    ShowStatus("Account created. Please sign in.", false);
                }
            }
        }

        private void ShowStatus(string text, bool isError)
        {
            lblStatus.ForeColor = isError ? ErrorColor : SuccessColor;
            lblStatus.Text = text;
        }
    }
}