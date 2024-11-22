namespace POS
{
    partial class ProductModule
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            picClose = new PictureBox();
            label1 = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnSave = new Button();
            textPname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBarcode = new TextBox();
            textPrice = new TextBox();
            cboBrand = new ComboBox();
            cboCategory = new ComboBox();
            UDReOrder = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UDReOrder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(764, 50);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Close_Window;
            pictureBox1.Location = new Point(733, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 30);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close_Window;
            picClose.Location = new Point(1251, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(28, 30);
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 0;
            label1.Text = "Product Module";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 267);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 13;
            lblId.Text = "id";
            lblId.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(628, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(528, 260);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 10;
            label2.Text = "Product Name:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(428, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textPname
            // 
            textPname.Location = new Point(179, 87);
            textPname.Name = "textPname";
            textPname.Size = new Size(195, 26);
            textPname.TabIndex = 8;
            textPname.TextChanged += textPname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 90);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(77, 20);
            label3.TabIndex = 14;
            label3.Text = "Barcode:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 136);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 15;
            label4.Text = "Brand:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 176);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 16;
            label5.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 216);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 17;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 217);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(124, 20);
            label7.TabIndex = 18;
            label7.Text = "Re-Order Level:";
            // 
            // textBarcode
            // 
            textBarcode.Location = new Point(542, 87);
            textBarcode.Name = "textBarcode";
            textBarcode.Size = new Size(168, 26);
            textBarcode.TabIndex = 19;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(179, 211);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(195, 26);
            textPrice.TabIndex = 22;
            // 
            // cboBrand
            // 
            cboBrand.FormattingEnabled = true;
            cboBrand.Location = new Point(179, 127);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(531, 28);
            cboBrand.TabIndex = 24;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(179, 169);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(531, 28);
            cboCategory.TabIndex = 26;
            // 
            // UDReOrder
            // 
            UDReOrder.ImeMode = ImeMode.NoControl;
            UDReOrder.Location = new Point(542, 214);
            UDReOrder.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            UDReOrder.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UDReOrder.Name = "UDReOrder";
            UDReOrder.Size = new Size(168, 26);
            UDReOrder.TabIndex = 25;
            UDReOrder.TextAlign = HorizontalAlignment.Center;
            UDReOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ProductModule
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 316);
            ControlBox = false;
            Controls.Add(UDReOrder);
            Controls.Add(cboCategory);
            Controls.Add(cboBrand);
            Controls.Add(textPrice);
            Controls.Add(textBarcode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(textPname);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            Load += ProductModule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)UDReOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel1;
        private PictureBox picClose;
        private Label label1;
        public Label lblId;
        public Button btnCancel;
        public Button btnUpdate;
        private Label label2;
        public Button btnSave;
        public TextBox textPname;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox textBarcode;
        public TextBox textPrice;
        public ComboBox cboBrand;
        public ComboBox cboCategory;
        public NumericUpDown UDReOrder;
    }
}