namespace POS
{
    partial class StockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            btnEntry = new Button();
            dgvStockIn = new DataGridView();
            panel2 = new Panel();
            txtAddress = new TextBox();
            txtContactInfo = new TextBox();
            cbSupplier = new ComboBox();
            lblId = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            LinGenerate = new LinkLabel();
            linProduct = new LinkLabel();
            dtStockIn = new DateTimePicker();
            txtStockInBy = new TextBox();
            txtRefNo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage1 = new TabPage();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockIn).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 496);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 65);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(4, -5);
            label1.Name = "label1";
            label1.Size = new Size(121, 71);
            label1.TabIndex = 3;
            label1.Text = "Stock In Module";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 496);
            tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEntry);
            tabPage2.Controls.Add(dgvStockIn);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(976, 463);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stock In ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEntry
            // 
            btnEntry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEntry.BackColor = Color.FromArgb(0, 70, 160);
            btnEntry.FlatAppearance.BorderSize = 0;
            btnEntry.FlatStyle = FlatStyle.Flat;
            btnEntry.ForeColor = SystemColors.Control;
            btnEntry.Location = new Point(874, 422);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(94, 35);
            btnEntry.TabIndex = 10;
            btnEntry.Text = "Entry";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += btnEntry_Click;
            // 
            // dgvStockIn
            // 
            dgvStockIn.AllowUserToAddRows = false;
            dgvStockIn.BackgroundColor = SystemColors.Control;
            dgvStockIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStockIn.ColumnHeadersHeight = 30;
            dgvStockIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStockIn.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column9, Column4, Column8, Column3, Column5, Column6, Column10, Column7, Delete });
            dgvStockIn.Dock = DockStyle.Top;
            dgvStockIn.EnableHeadersVisualStyles = false;
            dgvStockIn.Location = new Point(3, 167);
            dgvStockIn.Name = "dgvStockIn";
            dgvStockIn.RowHeadersVisible = false;
            dgvStockIn.Size = new Size(970, 247);
            dgvStockIn.TabIndex = 2;
            dgvStockIn.CellContentClick += dgvStockIn_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtContactInfo);
            panel2.Controls.Add(cbSupplier);
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(LinGenerate);
            panel2.Controls.Add(linProduct);
            panel2.Controls.Add(dtStockIn);
            panel2.Controls.Add(txtStockInBy);
            panel2.Controls.Add(txtRefNo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 164);
            panel2.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(632, 79);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(333, 26);
            txtAddress.TabIndex = 14;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(632, 46);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(333, 26);
            txtContactInfo.TabIndex = 13;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(632, 11);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(333, 28);
            cbSupplier.TabIndex = 12;
            cbSupplier.SelectedIndexChanged += cbSupplier_SelectedIndexChanged;
            cbSupplier.KeyPress += cbSupplier_KeyPress;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(493, 115);
            lblId.Name = "lblId";
            lblId.Size = new Size(40, 20);
            lblId.TabIndex = 11;
            lblId.Text = "lblId";
            lblId.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(493, 83);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 10;
            label7.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 51);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 9;
            label6.Text = "Contact Info :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 19);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 8;
            label5.Text = "Supplier :";
            // 
            // LinGenerate
            // 
            LinGenerate.AutoSize = true;
            LinGenerate.LinkColor = Color.DimGray;
            LinGenerate.Location = new Point(352, 19);
            LinGenerate.Name = "LinGenerate";
            LinGenerate.Size = new Size(99, 20);
            LinGenerate.TabIndex = 7;
            LinGenerate.TabStop = true;
            LinGenerate.Text = "[ Generate ]";
            LinGenerate.LinkClicked += LinGenerate_LinkClicked;
            // 
            // linProduct
            // 
            linProduct.AutoSize = true;
            linProduct.LinkColor = Color.DimGray;
            linProduct.Location = new Point(154, 128);
            linProduct.Name = "linProduct";
            linProduct.Size = new Size(242, 20);
            linProduct.TabIndex = 6;
            linProduct.TabStop = true;
            linProduct.Text = "[ Click here to browse product ]";
            linProduct.LinkClicked += linProduct_LinkClicked;
            // 
            // dtStockIn
            // 
            dtStockIn.Location = new Point(154, 93);
            dtStockIn.Name = "dtStockIn";
            dtStockIn.Size = new Size(297, 26);
            dtStockIn.TabIndex = 5;
            // 
            // txtStockInBy
            // 
            txtStockInBy.Location = new Point(154, 51);
            txtStockInBy.Name = "txtStockInBy";
            txtStockInBy.Size = new Size(297, 26);
            txtStockInBy.TabIndex = 4;
            // 
            // txtRefNo
            // 
            txtRefNo.Location = new Point(154, 13);
            txtRefNo.Name = "txtRefNo";
            txtRefNo.Size = new Size(187, 26);
            txtRefNo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 93);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 2;
            label4.Text = "Stock In Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 54);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 1;
            label3.Text = "Stock In By :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 16);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Reference No :";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 468);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stock In Record";
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
            // Column9
            // 
            Column9.HeaderText = "Reference#";
            Column9.Name = "Column9";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "pid";
            Column4.Name = "Column4";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Name";
            Column8.Name = "Column8";
            Column8.Width = 76;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Qty";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Stock In Date";
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Stock In By";
            Column6.Name = "Column6";
            Column6.Width = 111;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.HeaderText = "Status";
            Column10.Name = "Column10";
            Column10.Width = 74;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Supplier";
            Column7.Name = "Column7";
            Column7.Width = 89;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Cancel;
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // StockIn
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "StockIn";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "STOCK ENTRY";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockIn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel2;
        private DataGridView dgvStockIn;
        private Label label3;
        private Label label2;
        private LinkLabel LinGenerate;
        private LinkLabel linProduct;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        public Button btnEntry;
        public TabPage tabPage2;
        public DateTimePicker dtStockIn;
        public TextBox txtStockInBy;
        public TextBox txtRefNo;
        public TextBox txtAddress;
        public TextBox txtContactInfo;
        public ComboBox cbSupplier;
        public Label lblId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Delete;
    }
}