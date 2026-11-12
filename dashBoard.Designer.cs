namespace activity3
{
    partial class dashBoard
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.lblToolsQty = new System.Windows.Forms.Label();
            this.lblToolsName = new System.Windows.Forms.Label();
            this.lblBagsQty = new System.Windows.Forms.Label();
            this.lblBagsName = new System.Windows.Forms.Label();
            this.lblArtQty = new System.Windows.Forms.Label();
            this.lblArtName = new System.Windows.Forms.Label();
            this.lblPaperQty = new System.Windows.Forms.Label();
            this.lblPaperName = new System.Windows.Forms.Label();
            this.lblWritingQty = new System.Windows.Forms.Label();
            this.lblWritingName = new System.Windows.Forms.Label();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.lblStockTitle = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();

            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnSuppliers);
            this.pnlSidebar.Controls.Add(this.btnCategories);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 716);
            this.pnlSidebar.TabIndex = 0;

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 656);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(230, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;

            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 308);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(230, 52);
            this.btnReports.TabIndex = 5;
            this.btnReports.TabStop = false;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;

            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 256);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnSuppliers.Size = new System.Drawing.Size(230, 52);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.TabStop = false;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.UseVisualStyleBackColor = false;

            this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(0, 204);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(230, 52);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.TabStop = false;
            this.btnCategories.Text = "Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = false;

            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(0, 152);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(230, 52);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.TabStop = false;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = false;

            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 52);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;

            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(230, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "INVENTORY";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlContent.Controls.Add(this.pnlStock);
            this.pnlContent.Controls.Add(this.pnlEdit);
            this.pnlContent.Controls.Add(this.lblPages);
            this.pnlContent.Controls.Add(this.productGrid);
            this.pnlContent.Controls.Add(this.btnAdd);
            this.pnlContent.Controls.Add(this.txtSearch);
            this.pnlContent.Location = new System.Drawing.Point(230, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1170, 716);
            this.pnlContent.TabIndex = 1;

            this.pnlStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStock.BackColor = System.Drawing.Color.White;
            this.pnlStock.Controls.Add(this.lblToolsQty);
            this.pnlStock.Controls.Add(this.lblToolsName);
            this.pnlStock.Controls.Add(this.lblBagsQty);
            this.pnlStock.Controls.Add(this.lblBagsName);
            this.pnlStock.Controls.Add(this.lblArtQty);
            this.pnlStock.Controls.Add(this.lblArtName);
            this.pnlStock.Controls.Add(this.lblPaperQty);
            this.pnlStock.Controls.Add(this.lblPaperName);
            this.pnlStock.Controls.Add(this.lblWritingQty);
            this.pnlStock.Controls.Add(this.lblWritingName);
            this.pnlStock.Controls.Add(this.txtCategorySearch);
            this.pnlStock.Controls.Add(this.lblStockTitle);
            this.pnlStock.Location = new System.Drawing.Point(810, 420);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(340, 280);
            this.pnlStock.TabIndex = 6;

            this.lblToolsQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblToolsQty.Location = new System.Drawing.Point(205, 260);
            this.lblToolsQty.Name = "lblToolsQty";
            this.lblToolsQty.Size = new System.Drawing.Size(115, 22);
            this.lblToolsQty.TabIndex = 11;
            this.lblToolsQty.Text = "0";
            this.lblToolsQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblToolsName.AutoSize = true;
            this.lblToolsName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblToolsName.Location = new System.Drawing.Point(15, 260);
            this.lblToolsName.Name = "lblToolsName";
            this.lblToolsName.Size = new System.Drawing.Size(55, 25);
            this.lblToolsName.TabIndex = 10;
            this.lblToolsName.Text = "Tools";

            this.lblBagsQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBagsQty.Location = new System.Drawing.Point(205, 220);
            this.lblBagsQty.Name = "lblBagsQty";
            this.lblBagsQty.Size = new System.Drawing.Size(115, 22);
            this.lblBagsQty.TabIndex = 9;
            this.lblBagsQty.Text = "0";
            this.lblBagsQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblBagsName.AutoSize = true;
            this.lblBagsName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBagsName.Location = new System.Drawing.Point(15, 220);
            this.lblBagsName.Name = "lblBagsName";
            this.lblBagsName.Size = new System.Drawing.Size(52, 25);
            this.lblBagsName.TabIndex = 8;
            this.lblBagsName.Text = "Bags";

            this.lblArtQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblArtQty.Location = new System.Drawing.Point(205, 180);
            this.lblArtQty.Name = "lblArtQty";
            this.lblArtQty.Size = new System.Drawing.Size(115, 22);
            this.lblArtQty.TabIndex = 7;
            this.lblArtQty.Text = "0";
            this.lblArtQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblArtName.AutoSize = true;
            this.lblArtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblArtName.Location = new System.Drawing.Point(15, 180);
            this.lblArtName.Name = "lblArtName";
            this.lblArtName.Size = new System.Drawing.Size(37, 25);
            this.lblArtName.TabIndex = 6;
            this.lblArtName.Text = "Art";

            this.lblPaperQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPaperQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60)))));
            this.lblPaperQty.Location = new System.Drawing.Point(205, 140);
            this.lblPaperQty.Name = "lblPaperQty";
            this.lblPaperQty.Size = new System.Drawing.Size(115, 22);
            this.lblPaperQty.TabIndex = 5;
            this.lblPaperQty.Text = "0";
            this.lblPaperQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblPaperName.AutoSize = true;
            this.lblPaperName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPaperName.Location = new System.Drawing.Point(15, 140);
            this.lblPaperName.Name = "lblPaperName";
            this.lblPaperName.Size = new System.Drawing.Size(60, 25);
            this.lblPaperName.TabIndex = 4;
            this.lblPaperName.Text = "Paper";

            this.lblWritingQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWritingQty.Location = new System.Drawing.Point(205, 100);
            this.lblWritingQty.Name = "lblWritingQty";
            this.lblWritingQty.Size = new System.Drawing.Size(115, 22);
            this.lblWritingQty.TabIndex = 3;
            this.lblWritingQty.Text = "0";
            this.lblWritingQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblWritingName.AutoSize = true;
            this.lblWritingName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWritingName.Location = new System.Drawing.Point(15, 100);
            this.lblWritingName.Name = "lblWritingName";
            this.lblWritingName.Size = new System.Drawing.Size(75, 25);
            this.lblWritingName.TabIndex = 2;
            this.lblWritingName.Text = "Writing";

            this.txtCategorySearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCategorySearch.Location = new System.Drawing.Point(15, 50);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(305, 32);
            this.txtCategorySearch.TabIndex = 1;

            this.lblStockTitle.AutoSize = true;
            this.lblStockTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblStockTitle.Location = new System.Drawing.Point(15, 12);
            this.lblStockTitle.Name = "lblStockTitle";
            this.lblStockTitle.Size = new System.Drawing.Size(218, 32);
            this.lblStockTitle.TabIndex = 0;
            this.lblStockTitle.Text = "Stock by category";

            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.Controls.Add(this.btnCancel);
            this.pnlEdit.Controls.Add(this.btnUpdate);
            this.pnlEdit.Controls.Add(this.cboSupplier);
            this.pnlEdit.Controls.Add(this.lblSupplier);
            this.pnlEdit.Controls.Add(this.txtPrice);
            this.pnlEdit.Controls.Add(this.lblPrice);
            this.pnlEdit.Controls.Add(this.txtQty);
            this.pnlEdit.Controls.Add(this.lblQty);
            this.pnlEdit.Controls.Add(this.cboCategory);
            this.pnlEdit.Controls.Add(this.lblCategory);
            this.pnlEdit.Controls.Add(this.txtName);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Controls.Add(this.lblEditTitle);
            this.pnlEdit.Location = new System.Drawing.Point(810, 80);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(340, 330);
            this.pnlEdit.TabIndex = 5;

            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancel.Location = new System.Drawing.Point(175, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;

            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(15, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update (U)";
            this.btnUpdate.UseVisualStyleBackColor = false;

            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Items.AddRange(new object[] {
            "Sunrise Supply",
            "Bright Office Supply",
            "Campus Mart"});
            this.cboSupplier.Location = new System.Drawing.Point(110, 222);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(210, 33);
            this.cboSupplier.TabIndex = 10;

            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSupplier.Location = new System.Drawing.Point(15, 226);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(82, 25);
            this.lblSupplier.TabIndex = 9;
            this.lblSupplier.Text = "Supplier";

            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(110, 182);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 32);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Text = "₱10.00";

            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPrice.Location = new System.Drawing.Point(15, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 25);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";

            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtQty.Location = new System.Drawing.Point(110, 142);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(210, 32);
            this.txtQty.TabIndex = 6;
            this.txtQty.Text = "120";

            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQty.Location = new System.Drawing.Point(15, 146);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(41, 25);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Qty";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Writing",
            "Paper",
            "Art",
            "Bags",
            "Tools"});
            this.cboCategory.Location = new System.Drawing.Point(110, 102);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(210, 33);
            this.cboCategory.TabIndex = 4;

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCategory.Location = new System.Drawing.Point(15, 106);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 25);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";

            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(110, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 32);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Ballpen (blue)";

            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblName.Location = new System.Drawing.Point(15, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";

            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblEditTitle.Location = new System.Drawing.Point(15, 12);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(156, 32);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "Edit product";

            this.lblPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPages.Location = new System.Drawing.Point(20, 640);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(93, 28);
            this.lblPages.TabIndex = 4;
            this.lblPages.Text = "< 1 2 3 >";

            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.productGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.productGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGrid.BackgroundColor = System.Drawing.Color.White;
            this.productGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colCode,
            this.colProduct,
            this.colCategory,
            this.colQty,
            this.colPrice,
            this.colActions});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.productGrid.EnableHeadersVisualStyles = false;
            this.productGrid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.productGrid.Location = new System.Drawing.Point(20, 80);
            this.productGrid.MultiSelect = false;
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersVisible = false;
            this.productGrid.RowHeadersWidth = 51;
            this.productGrid.RowTemplate.Height = 36;
            this.productGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGrid.Size = new System.Drawing.Size(770, 420);
            this.productGrid.TabIndex = 2;

            this.colNo.FillWeight = 6F;
            this.colNo.HeaderText = "#";
            this.colNo.MinimumWidth = 6;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;

            this.colCode.FillWeight = 13F;
            this.colCode.HeaderText = "Code";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;

            this.colProduct.FillWeight = 24F;
            this.colProduct.HeaderText = "Product";
            this.colProduct.MinimumWidth = 6;
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;

            this.colCategory.FillWeight = 16F;
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;

            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQty.DefaultCellStyle = dataGridViewCellStyle9;
            this.colQty.FillWeight = 9F;
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;

            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.colPrice.FillWeight = 12F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;

            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colActions.DefaultCellStyle = dataGridViewCellStyle11;
            this.colActions.FillWeight = 20F;
            this.colActions.HeaderText = "Actions";
            this.colActions.MinimumWidth = 6;
            this.colActions.Name = "colActions";
            this.colActions.ReadOnly = true;

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(590, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+ Add product";
            this.btnAdd.UseVisualStyleBackColor = false;

            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(20, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(320, 34);
            this.txtSearch.TabIndex = 0;

            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.pnlStatus.Controls.Add(this.lblUser);
            this.pnlStatus.Controls.Add(this.lblLow);
            this.pnlStatus.Controls.Add(this.lblTotal);
            this.pnlStatus.Location = new System.Drawing.Point(0, 716);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1400, 34);
            this.pnlStatus.TabIndex = 2;

            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblUser.Location = new System.Drawing.Point(1200, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(180, 22);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Logged in: Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblLow.Location = new System.Drawing.Point(200, 8);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(102, 23);
            this.lblLow.TabIndex = 1;
            this.lblLow.Text = "Low stock: 0";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total items: 0";

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "dashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System - School Supplies";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlStock.ResumeLayout(false);
            this.pnlStock.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActions;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Label lblStockTitle;
        private System.Windows.Forms.TextBox txtCategorySearch;
        private System.Windows.Forms.Label lblWritingName;
        private System.Windows.Forms.Label lblWritingQty;
        private System.Windows.Forms.Label lblPaperName;
        private System.Windows.Forms.Label lblPaperQty;
        private System.Windows.Forms.Label lblArtName;
        private System.Windows.Forms.Label lblArtQty;
        private System.Windows.Forms.Label lblBagsName;
        private System.Windows.Forms.Label lblBagsQty;
        private System.Windows.Forms.Label lblToolsName;
        private System.Windows.Forms.Label lblToolsQty;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblUser;
    }
}