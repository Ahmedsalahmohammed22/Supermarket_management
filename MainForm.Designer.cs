namespace POS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitle = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            panelSlide = new Panel();
            btnLogout = new Button();
            panelSubSetting = new Panel();
            btnStore = new Button();
            btnUser = new Button();
            btnSetting = new Button();
            panelSubRecord = new Panel();
            btnPosRecord = new Button();
            btnSaleHistory = new Button();
            btnRecord = new Button();
            btnSupplier = new Button();
            panelSubStock = new Panel();
            btnStockAdjustment = new Button();
            btnStockEntry = new Button();
            btnInStock = new Button();
            panelSubProduct = new Panel();
            btnBrand = new Button();
            btnCategory = new Button();
            btnProductList = new Button();
            btnProduct = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            pictureBox1 = new PictureBox();
            panelTitle.SuspendLayout();
            panelSlide.SuspendLayout();
            panelSubSetting.SuspendLayout();
            panelSubRecord.SuspendLayout();
            panelSubStock.SuspendLayout();
            panelSubProduct.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(228, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(956, 40);
            panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Simplified Arabic Fixed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlLight;
            lblTitle.Location = new Point(236, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(351, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TitleName";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Font = new Font("Simplified Arabic Fixed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelMain.Location = new Point(228, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(0, 40, 0, 0);
            panelMain.RightToLeft = RightToLeft.No;
            panelMain.Size = new Size(956, 661);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // panelSlide
            // 
            panelSlide.AutoScroll = true;
            panelSlide.Controls.Add(btnLogout);
            panelSlide.Controls.Add(panelSubSetting);
            panelSlide.Controls.Add(btnSetting);
            panelSlide.Controls.Add(panelSubRecord);
            panelSlide.Controls.Add(btnRecord);
            panelSlide.Controls.Add(btnSupplier);
            panelSlide.Controls.Add(panelSubStock);
            panelSlide.Controls.Add(btnInStock);
            panelSlide.Controls.Add(panelSubProduct);
            panelSlide.Controls.Add(btnProduct);
            panelSlide.Controls.Add(btnDashboard);
            panelSlide.Controls.Add(panelLogo);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(228, 661);
            panelSlide.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(0, 854);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(5, 0, 0, 0);
            btnLogout.Size = new Size(211, 45);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelSubSetting
            // 
            panelSubSetting.BackColor = Color.FromArgb(0, 70, 200);
            panelSubSetting.Controls.Add(btnStore);
            panelSubSetting.Controls.Add(btnUser);
            panelSubSetting.Dock = DockStyle.Top;
            panelSubSetting.Location = new Point(0, 764);
            panelSubSetting.Name = "panelSubSetting";
            panelSubSetting.Size = new Size(211, 90);
            panelSubSetting.TabIndex = 9;
            // 
            // btnStore
            // 
            btnStore.Dock = DockStyle.Top;
            btnStore.FlatAppearance.BorderSize = 0;
            btnStore.FlatStyle = FlatStyle.Flat;
            btnStore.ForeColor = SystemColors.Control;
            btnStore.Location = new Point(0, 45);
            btnStore.Name = "btnStore";
            btnStore.Padding = new Padding(35, 0, 0, 0);
            btnStore.Size = new Size(211, 45);
            btnStore.TabIndex = 5;
            btnStore.Text = "Store";
            btnStore.TextAlign = ContentAlignment.MiddleLeft;
            btnStore.UseVisualStyleBackColor = true;
            btnStore.Click += btnStore_Click;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.ForeColor = SystemColors.Control;
            btnUser.Location = new Point(0, 0);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(35, 0, 0, 0);
            btnUser.Size = new Size(211, 45);
            btnUser.TabIndex = 4;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.ForeColor = SystemColors.Control;
            btnSetting.Location = new Point(0, 719);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(5, 0, 0, 0);
            btnSetting.Size = new Size(211, 45);
            btnSetting.TabIndex = 8;
            btnSetting.Text = "Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // panelSubRecord
            // 
            panelSubRecord.AutoScroll = true;
            panelSubRecord.BackColor = Color.FromArgb(0, 70, 200);
            panelSubRecord.Controls.Add(btnPosRecord);
            panelSubRecord.Controls.Add(btnSaleHistory);
            panelSubRecord.Dock = DockStyle.Top;
            panelSubRecord.Location = new Point(0, 629);
            panelSubRecord.Name = "panelSubRecord";
            panelSubRecord.Size = new Size(211, 90);
            panelSubRecord.TabIndex = 7;
            // 
            // btnPosRecord
            // 
            btnPosRecord.Dock = DockStyle.Top;
            btnPosRecord.FlatAppearance.BorderSize = 0;
            btnPosRecord.FlatStyle = FlatStyle.Flat;
            btnPosRecord.ForeColor = SystemColors.Control;
            btnPosRecord.Location = new Point(0, 45);
            btnPosRecord.Name = "btnPosRecord";
            btnPosRecord.Padding = new Padding(35, 0, 0, 0);
            btnPosRecord.Size = new Size(211, 45);
            btnPosRecord.TabIndex = 5;
            btnPosRecord.Text = "POS Record";
            btnPosRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnPosRecord.UseVisualStyleBackColor = true;
            btnPosRecord.Click += btnPosRecord_Click;
            // 
            // btnSaleHistory
            // 
            btnSaleHistory.Dock = DockStyle.Top;
            btnSaleHistory.FlatAppearance.BorderSize = 0;
            btnSaleHistory.FlatStyle = FlatStyle.Flat;
            btnSaleHistory.ForeColor = SystemColors.Control;
            btnSaleHistory.Location = new Point(0, 0);
            btnSaleHistory.Name = "btnSaleHistory";
            btnSaleHistory.Padding = new Padding(35, 0, 0, 0);
            btnSaleHistory.Size = new Size(211, 45);
            btnSaleHistory.TabIndex = 4;
            btnSaleHistory.Text = "Sale History";
            btnSaleHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnSaleHistory.UseVisualStyleBackColor = true;
            btnSaleHistory.Click += btnSaleHistory_Click;
            // 
            // btnRecord
            // 
            btnRecord.Dock = DockStyle.Top;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.ForeColor = SystemColors.Control;
            btnRecord.Location = new Point(0, 584);
            btnRecord.Name = "btnRecord";
            btnRecord.Padding = new Padding(5, 0, 0, 0);
            btnRecord.Size = new Size(211, 45);
            btnRecord.TabIndex = 5;
            btnRecord.Text = "Record";
            btnRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.Dock = DockStyle.Top;
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.ForeColor = SystemColors.Control;
            btnSupplier.Location = new Point(0, 539);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Padding = new Padding(5, 0, 0, 0);
            btnSupplier.Size = new Size(211, 45);
            btnSupplier.TabIndex = 4;
            btnSupplier.Text = "Supplier";
            btnSupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // panelSubStock
            // 
            panelSubStock.BackColor = Color.FromArgb(0, 70, 200);
            panelSubStock.Controls.Add(btnStockAdjustment);
            panelSubStock.Controls.Add(btnStockEntry);
            panelSubStock.Dock = DockStyle.Top;
            panelSubStock.Location = new Point(0, 449);
            panelSubStock.Name = "panelSubStock";
            panelSubStock.Size = new Size(211, 90);
            panelSubStock.TabIndex = 4;
            // 
            // btnStockAdjustment
            // 
            btnStockAdjustment.Dock = DockStyle.Top;
            btnStockAdjustment.FlatAppearance.BorderSize = 0;
            btnStockAdjustment.FlatStyle = FlatStyle.Flat;
            btnStockAdjustment.ForeColor = SystemColors.Control;
            btnStockAdjustment.Location = new Point(0, 45);
            btnStockAdjustment.Name = "btnStockAdjustment";
            btnStockAdjustment.Padding = new Padding(35, 0, 0, 0);
            btnStockAdjustment.Size = new Size(211, 45);
            btnStockAdjustment.TabIndex = 5;
            btnStockAdjustment.Text = "Stock Adjustment";
            btnStockAdjustment.TextAlign = ContentAlignment.MiddleLeft;
            btnStockAdjustment.UseVisualStyleBackColor = true;
            btnStockAdjustment.Click += btnStockAdjustment_Click;
            // 
            // btnStockEntry
            // 
            btnStockEntry.Dock = DockStyle.Top;
            btnStockEntry.FlatAppearance.BorderSize = 0;
            btnStockEntry.FlatStyle = FlatStyle.Flat;
            btnStockEntry.ForeColor = SystemColors.Control;
            btnStockEntry.Location = new Point(0, 0);
            btnStockEntry.Name = "btnStockEntry";
            btnStockEntry.Padding = new Padding(35, 0, 0, 0);
            btnStockEntry.Size = new Size(211, 45);
            btnStockEntry.TabIndex = 4;
            btnStockEntry.Text = "Stock Entry";
            btnStockEntry.TextAlign = ContentAlignment.MiddleLeft;
            btnStockEntry.UseVisualStyleBackColor = true;
            btnStockEntry.Click += btnStockEntry_Click;
            // 
            // btnInStock
            // 
            btnInStock.Dock = DockStyle.Top;
            btnInStock.FlatAppearance.BorderSize = 0;
            btnInStock.FlatStyle = FlatStyle.Flat;
            btnInStock.ForeColor = SystemColors.Control;
            btnInStock.Location = new Point(0, 404);
            btnInStock.Name = "btnInStock";
            btnInStock.Padding = new Padding(5, 0, 0, 0);
            btnInStock.Size = new Size(211, 45);
            btnInStock.TabIndex = 3;
            btnInStock.Text = "In Stock";
            btnInStock.TextAlign = ContentAlignment.MiddleLeft;
            btnInStock.UseVisualStyleBackColor = true;
            btnInStock.Click += btnInStock_Click;
            // 
            // panelSubProduct
            // 
            panelSubProduct.BackColor = Color.FromArgb(0, 70, 200);
            panelSubProduct.Controls.Add(btnBrand);
            panelSubProduct.Controls.Add(btnCategory);
            panelSubProduct.Controls.Add(btnProductList);
            panelSubProduct.Dock = DockStyle.Top;
            panelSubProduct.Location = new Point(0, 269);
            panelSubProduct.Name = "panelSubProduct";
            panelSubProduct.Size = new Size(211, 135);
            panelSubProduct.TabIndex = 0;
            // 
            // btnBrand
            // 
            btnBrand.Dock = DockStyle.Top;
            btnBrand.FlatAppearance.BorderSize = 0;
            btnBrand.FlatStyle = FlatStyle.Flat;
            btnBrand.ForeColor = SystemColors.Control;
            btnBrand.Location = new Point(0, 90);
            btnBrand.Name = "btnBrand";
            btnBrand.Padding = new Padding(35, 0, 0, 0);
            btnBrand.Size = new Size(211, 45);
            btnBrand.TabIndex = 5;
            btnBrand.Text = "Brand";
            btnBrand.TextAlign = ContentAlignment.MiddleLeft;
            btnBrand.UseVisualStyleBackColor = true;
            btnBrand.Click += btnBrand_Click;
            // 
            // btnCategory
            // 
            btnCategory.Dock = DockStyle.Top;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ForeColor = SystemColors.Control;
            btnCategory.Location = new Point(0, 45);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(35, 0, 0, 0);
            btnCategory.Size = new Size(211, 45);
            btnCategory.TabIndex = 4;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProductList
            // 
            btnProductList.Dock = DockStyle.Top;
            btnProductList.FlatAppearance.BorderSize = 0;
            btnProductList.FlatStyle = FlatStyle.Flat;
            btnProductList.ForeColor = SystemColors.Control;
            btnProductList.Location = new Point(0, 0);
            btnProductList.Name = "btnProductList";
            btnProductList.Padding = new Padding(35, 0, 0, 0);
            btnProductList.Size = new Size(211, 45);
            btnProductList.TabIndex = 3;
            btnProductList.Text = "Product List";
            btnProductList.TextAlign = ContentAlignment.MiddleLeft;
            btnProductList.UseVisualStyleBackColor = true;
            btnProductList.Click += btnProductList_Click;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = SystemColors.Control;
            btnProduct.Location = new Point(0, 224);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(5, 0, 0, 0);
            btnProduct.Size = new Size(211, 45);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Location = new Point(0, 179);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(5, 0, 0, 0);
            btnDashboard.Size = new Size(211, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(lblUsername);
            panelLogo.Controls.Add(lblRole);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(211, 179);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(10, 114);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 1;
            label1.Text = "LN";
            label1.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ControlLight;
            lblUsername.Location = new Point(72, 111);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "UserName";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = SystemColors.ControlLight;
            lblRole.Location = new Point(52, 145);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(127, 21);
            lblRole.TabIndex = 0;
            lblRole.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Name;
            pictureBox1.Location = new Point(72, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 70, 160);
            ClientSize = new Size(1184, 661);
            Controls.Add(panelTitle);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            Font = new Font("Simplified Arabic Fixed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            Text = "Point Of Sales";
            Load += Form1_Load;
            panelTitle.ResumeLayout(false);
            panelSlide.ResumeLayout(false);
            panelSubSetting.ResumeLayout(false);
            panelSubRecord.ResumeLayout(false);
            panelSubStock.ResumeLayout(false);
            panelSubProduct.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitle;
        private Panel panelMain;
        private Label lblTitle;
        private Panel panelSlide;
        private Button btnLogout;
        private Panel panelSubSetting;
        private Button btnStore;
        private Button btnUser;
        private Button btnSetting;
        private Panel panelSubRecord;
        private Button btnPosRecord;
        private Button btnSaleHistory;
        private Button btnRecord;
        private Button btnSupplier;
        private Panel panelSubStock;
        private Button btnStockAdjustment;
        private Button btnStockEntry;
        private Button btnInStock;
        private Panel panelSubProduct;
        private Button btnBrand;
        private Button btnCategory;
        private Button btnProductList;
        private Button btnProduct;
        private Button btnDashboard;
        private Panel panelLogo;
        private Label label1;
        private Label lblUsername;
        private Label lblRole;
        private PictureBox pictureBox1;
    }
}
