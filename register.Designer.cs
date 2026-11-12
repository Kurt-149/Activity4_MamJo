namespace activity3
{
    partial class register
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lnkBack);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Controls.Add(this.lblStatus);
            this.pnlCard.Controls.Add(this.txtConfirm);
            this.pnlCard.Controls.Add(this.lblConfirm);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblUsername);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.pnlAccent);
            this.pnlCard.Location = new System.Drawing.Point(420, 85);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(560, 580);
            this.pnlCard.TabIndex = 0;

            this.lnkBack.ActiveLinkColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.lnkBack.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lnkBack.LinkColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lnkBack.Location = new System.Drawing.Point(42, 520);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(476, 28);
            this.lnkBack.TabIndex = 11;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Already have an account? Sign in";
            this.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkBack.VisitedLinkColor = System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(42, 450);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(476, 54);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;

            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatus.Location = new System.Drawing.Point(42, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(476, 26);
            this.lblStatus.TabIndex = 9;

            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtConfirm.Location = new System.Drawing.Point(42, 360);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(476, 42);
            this.txtConfirm.TabIndex = 8;
            this.txtConfirm.UseSystemPasswordChar = true;

            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblConfirm.Location = new System.Drawing.Point(42, 330);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(165, 25);
            this.lblConfirm.TabIndex = 7;
            this.lblConfirm.Text = "Confirm Password";

            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtPassword.Location = new System.Drawing.Point(42, 275);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(476, 42);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;

            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPassword.Location = new System.Drawing.Point(42, 245);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtUsername.Location = new System.Drawing.Point(42, 190);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(476, 42);
            this.txtUsername.TabIndex = 4;

            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblUsername.Location = new System.Drawing.Point(42, 160);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 25);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitle.Location = new System.Drawing.Point(42, 112);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(230, 25);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Fill in the details below.";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitle.Location = new System.Drawing.Point(40, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create Account";

            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccent.Height = 8;
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.TabIndex = 0;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(900, 680);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlAccent;
    }
}