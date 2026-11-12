using System;
using System.Drawing;
using System.Windows.Forms;

namespace activity3
{
    public partial class register : Form
    {
        private static readonly Color ErrorColor = Color.FromArgb(190, 18, 60);
        private static readonly Color SuccessColor = Color.FromArgb(22, 163, 74);

        public string RegisteredUsername { get; private set; } = "";

        public register()
        {
            InitializeComponent();

            AcceptButton = btnRegister;
            btnRegister.Click += btnRegister_Click;
            lnkBack.LinkClicked += lnkBack_LinkClicked;

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            if (username.Length < 3)
            {
                ShowStatus("Username must be at least 3 characters.", true);
                return;
            }

            if (password.Length < 6)
            {
                ShowStatus("Password must be at least 6 characters.", true);
                return;
            }

            if (password != confirm)
            {
                ShowStatus("Passwords do not match.", true);
                return;
            }

            try
            {
                if (Db.UsernameExists(username))
                {
                    ShowStatus("That username is already taken.", true);
                    return;
                }

                Db.CreateUser(username, password);
            }
            catch (Exception ex)
            {
                ShowStatus("Database error: " + ex.Message, true);
                return;
            }

            RegisteredUsername = username;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowStatus(string text, bool isError)
        {
            lblStatus.ForeColor = isError ? ErrorColor : SuccessColor;
            lblStatus.Text = text;
        }
    }
}