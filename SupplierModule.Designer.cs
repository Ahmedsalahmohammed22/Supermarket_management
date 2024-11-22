namespace POS
{
    partial class SupplierModule
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picClose = new PictureBox();
            label1 = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnSave = new Button();
            txtSupplier = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtConInfo = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(764, 50);
            panel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Close_Window;
            pictureBox2.Location = new Point(733, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 30);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Close_Window;
            pictureBox1.Location = new Point(1297, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 30);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.Image = Properties.Resources.Close_Window;
            picClose.Location = new Point(1815, 0);
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
            label1.Size = new Size(135, 19);
            label1.TabIndex = 0;
            label1.Text = "Supplier Module";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 267);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 33;
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
            btnCancel.TabIndex = 32;
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
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 30;
            label2.Text = "Supplier Name:";
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
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(179, 87);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(531, 26);
            txtSupplier.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 136);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 35;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 176);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 36;
            label5.Text = "Contact Info:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 216);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 37;
            label6.Text = "Phone No:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(179, 211);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 26);
            txtPhone.TabIndex = 40;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(179, 127);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(531, 26);
            txtAddress.TabIndex = 44;
            // 
            // txtConInfo
            // 
            txtConInfo.Location = new Point(179, 169);
            txtConInfo.Name = "txtConInfo";
            txtConInfo.Size = new Size(531, 26);
            txtConInfo.TabIndex = 45;
            // 
            // SupplierModule
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 316);
            Controls.Add(txtConInfo);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtSupplier);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SupplierModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox picClose;
        private Label label1;
        public Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public TextBox txtSupplier;
        private PictureBox pictureBox2;
        public TextBox txtPhone;
        public TextBox txtAddress;
        public TextBox txtConInfo;
        public Label label2;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label lblId;
    }
}