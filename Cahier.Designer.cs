namespace POS
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panelSlide = new Panel();
            btnLogout = new Button();
            btnDSales = new Button();
            btnClear = new Button();
            btnSettle = new Button();
            btnDiscount = new Button();
            btnSearch = new Button();
            btnNTran = new Button();
            panel2 = new Panel();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblname = new Label();
            panel5 = new Panel();
            lblTimer = new Label();
            lblVatable = new Label();
            lblVat = new Label();
            lblDiscount = new Label();
            lblSaleTotal = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtBarcode = new TextBox();
            label6 = new Label();
            lblDate = new Label();
            label5 = new Label();
            lblTransNo = new Label();
            label2 = new Label();
            lblDisplayTotal = new Label();
            dgvCash = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            colAdd = new DataGridViewImageColumn();
            colReduce = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCash).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDSales);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSettle);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnNTran);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 700);
            panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.Location = new Point(192, 181);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 50);
            panelSlide.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 650);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 10;
            btnLogout.Text = " Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDSales
            // 
            btnDSales.Dock = DockStyle.Top;
            btnDSales.FlatAppearance.BorderSize = 0;
            btnDSales.FlatStyle = FlatStyle.Flat;
            btnDSales.ForeColor = Color.White;
            btnDSales.Image = (Image)resources.GetObject("btnDSales.Image");
            btnDSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSales.Location = new Point(0, 430);
            btnDSales.Name = "btnDSales";
            btnDSales.Size = new Size(200, 50);
            btnDSales.TabIndex = 9;
            btnDSales.Text = "Daily Sales";
            btnDSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDSales.UseVisualStyleBackColor = true;
            btnDSales.Click += btnDSales_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Top;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(0, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 50);
            btnClear.TabIndex = 8;
            btnClear.Text = " Clear Cart";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSettle
            // 
            btnSettle.Dock = DockStyle.Top;
            btnSettle.FlatAppearance.BorderSize = 0;
            btnSettle.FlatStyle = FlatStyle.Flat;
            btnSettle.ForeColor = Color.White;
            btnSettle.Image = (Image)resources.GetObject("btnSettle.Image");
            btnSettle.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettle.Location = new Point(0, 330);
            btnSettle.Name = "btnSettle";
            btnSettle.Size = new Size(200, 50);
            btnSettle.TabIndex = 7;
            btnSettle.Text = " Settle Payment";
            btnSettle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettle.UseVisualStyleBackColor = true;
            btnSettle.Click += btnSettle_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Dock = DockStyle.Top;
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.ForeColor = Color.White;
            btnDiscount.Image = (Image)resources.GetObject("btnDiscount.Image");
            btnDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiscount.Location = new Point(0, 280);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(200, 50);
            btnDiscount.TabIndex = 6;
            btnDiscount.Text = " Add Discount";
            btnDiscount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(0, 230);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 50);
            btnSearch.TabIndex = 5;
            btnSearch.Text = " Search Product";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNTran
            // 
            btnNTran.Dock = DockStyle.Top;
            btnNTran.FlatAppearance.BorderSize = 0;
            btnNTran.FlatStyle = FlatStyle.Flat;
            btnNTran.ForeColor = Color.White;
            btnNTran.Image = Properties.Resources.Transaction;
            btnNTran.ImageAlign = ContentAlignment.MiddleLeft;
            btnNTran.Location = new Point(0, 180);
            btnNTran.Name = "btnNTran";
            btnNTran.Size = new Size(200, 50);
            btnNTran.TabIndex = 4;
            btnNTran.Text = " New Transaction";
            btnNTran.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNTran.UseVisualStyleBackColor = true;
            btnNTran.Click += btnNTran_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 180);
            panel2.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(52, 147);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 70, 160);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 700);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 70, 160);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(lblname);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(208, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(992, 50);
            panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.Close_Window;
            pictureBox3.Location = new Point(963, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 30);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.ForeColor = Color.White;
            lblname.Location = new Point(59, 14);
            lblname.Name = "lblname";
            lblname.Size = new Size(122, 20);
            lblname.TabIndex = 5;
            lblname.Text = "Name and Role";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblTimer);
            panel5.Controls.Add(lblVatable);
            panel5.Controls.Add(lblVat);
            panel5.Controls.Add(lblDiscount);
            panel5.Controls.Add(lblSaleTotal);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtBarcode);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lblDate);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblTransNo);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(lblDisplayTotal);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(980, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 650);
            panel5.TabIndex = 3;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.LightSeaGreen;
            lblTimer.Dock = DockStyle.Bottom;
            lblTimer.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(0, 600);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(220, 50);
            lblTimer.TabIndex = 15;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVatable
            // 
            lblVatable.Location = new Point(98, 410);
            lblVatable.Name = "lblVatable";
            lblVatable.Size = new Size(121, 20);
            lblVatable.TabIndex = 14;
            lblVatable.Text = "0.00";
            lblVatable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVat
            // 
            lblVat.Location = new Point(98, 380);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(121, 20);
            lblVat.TabIndex = 13;
            lblVat.Text = "0.00";
            lblVat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            lblDiscount.Location = new Point(98, 345);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(121, 20);
            lblDiscount.TabIndex = 12;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSaleTotal
            // 
            lblSaleTotal.Location = new Point(98, 310);
            lblSaleTotal.Name = "lblSaleTotal";
            lblSaleTotal.Size = new Size(121, 20);
            lblSaleTotal.TabIndex = 11;
            lblSaleTotal.Text = "0.00";
            lblSaleTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 410);
            label10.Name = "label10";
            label10.Size = new Size(81, 20);
            label10.TabIndex = 10;
            label10.Text = "VATable : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 345);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 9;
            label9.Text = "Discount : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 380);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 8;
            label8.Text = "VAT : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 309);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 7;
            label7.Text = "Sales Total : ";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(11, 240);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(159, 26);
            txtBarcode.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 210);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Barcode";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(6, 172);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(81, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "000000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 145);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 3;
            label5.Text = "Date";
            // 
            // lblTransNo
            // 
            lblTransNo.AutoSize = true;
            lblTransNo.Location = new Point(6, 110);
            lblTransNo.Name = "lblTransNo";
            lblTransNo.Size = new Size(89, 20);
            lblTransNo.TabIndex = 2;
            lblTransNo.Text = "0000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Transaction No";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.BackColor = Color.FromArgb(0, 70, 160);
            lblDisplayTotal.Dock = DockStyle.Top;
            lblDisplayTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayTotal.ForeColor = Color.White;
            lblDisplayTotal.Location = new Point(0, 0);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(220, 31);
            lblDisplayTotal.TabIndex = 0;
            lblDisplayTotal.Text = "0.00";
            lblDisplayTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvCash
            // 
            dgvCash.AllowUserToAddRows = false;
            dgvCash.BackgroundColor = SystemColors.Control;
            dgvCash.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCash.ColumnHeadersHeight = 30;
            dgvCash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCash.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column8, Column4, Column6, Column5, Column3, Column7, colAdd, colReduce, Delete });
            dgvCash.Dock = DockStyle.Fill;
            dgvCash.EnableHeadersVisualStyles = false;
            dgvCash.Location = new Point(208, 50);
            dgvCash.Name = "dgvCash";
            dgvCash.RowHeadersVisible = false;
            dgvCash.Size = new Size(772, 650);
            dgvCash.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.Width = 53;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id";
            Column2.Name = "Column2";
            Column2.Width = 47;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Name";
            Column8.Name = "Column8";
            Column8.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Barcode";
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.HeaderText = "Price";
            Column6.Name = "Column6";
            Column6.Width = 69;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = dataGridViewCellStyle3;
            Column5.HeaderText = "Qty";
            Column5.Name = "Column5";
            Column5.Width = 58;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column3.DefaultCellStyle = dataGridViewCellStyle4;
            Column3.HeaderText = "Discount";
            Column3.Name = "Column3";
            Column3.Width = 95;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle5;
            Column7.HeaderText = "Total";
            Column7.Name = "Column7";
            Column7.Width = 65;
            // 
            // colAdd
            // 
            colAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colAdd.HeaderText = "";
            colAdd.Image = (Image)resources.GetObject("colAdd.Image");
            colAdd.Name = "colAdd";
            colAdd.Width = 5;
            // 
            // colReduce
            // 
            colReduce.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colReduce.HeaderText = "";
            colReduce.Image = Properties.Resources.Reduce;
            colReduce.Name = "colReduce";
            colReduce.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(dgvCash);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Cashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnNTran;
        private Panel panel5;
        private Button btnLogout;
        private Button btnDSales;
        private Button btnClear;
        private Button btnSettle;
        private Button btnDiscount;
        private Button btnSearch;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblname;
        private PictureBox pictureBox3;
        private Panel panelSlide;
        private DataGridView dgvCash;
        private Label lblDisplayTotal;
        private Label lblDate;
        private Label label5;
        private Label label2;
        private TextBox txtBarcode;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblTimer;
        private Label lblVatable;
        private Label lblVat;
        private Label lblDiscount;
        private Label lblSaleTotal;
        private System.Windows.Forms.Timer timer1;
        public Label lblUsername;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn colAdd;
        private DataGridViewImageColumn colReduce;
        private DataGridViewImageColumn Delete;
        public Label lblTransNo;
    }
}