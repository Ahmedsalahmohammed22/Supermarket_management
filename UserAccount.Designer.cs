namespace POS
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            btnAccCancel = new Button();
            btnAccSave = new Button();
            label6 = new Label();
            cbRole = new ComboBox();
            txtFullName = new TextBox();
            txtRePass = new TextBox();
            txtPass = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            btnPassCancel = new Button();
            btnPassSave = new Button();
            txtRePass2 = new TextBox();
            txtNPass2 = new TextBox();
            txtPass2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPassUsername = new TextBox();
            label10 = new Label();
            tabPage3 = new TabPage();
            dgvUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 80);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 71);
            label1.TabIndex = 3;
            label1.Text = "User Settings";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(25, 12);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(928, 452);
            materialTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btnAccCancel);
            tabPage1.Controls.Add(btnAccSave);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(cbRole);
            tabPage1.Controls.Add(txtFullName);
            tabPage1.Controls.Add(txtRePass);
            tabPage1.Controls.Add(txtPass);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtUserName);
            tabPage1.Controls.Add(label2);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(920, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Account";
            // 
            // btnAccCancel
            // 
            btnAccCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccCancel.BackColor = Color.LightGray;
            btnAccCancel.FlatAppearance.BorderSize = 0;
            btnAccCancel.FlatStyle = FlatStyle.Flat;
            btnAccCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnAccCancel.Location = new Point(714, 330);
            btnAccCancel.Name = "btnAccCancel";
            btnAccCancel.Size = new Size(94, 35);
            btnAccCancel.TabIndex = 14;
            btnAccCancel.Text = "Cancel";
            btnAccCancel.UseVisualStyleBackColor = false;
            btnAccCancel.Click += btnAccCancel_Click;
            // 
            // btnAccSave
            // 
            btnAccSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccSave.BackColor = Color.FromArgb(0, 70, 160);
            btnAccSave.FlatAppearance.BorderSize = 0;
            btnAccSave.FlatStyle = FlatStyle.Flat;
            btnAccSave.ForeColor = SystemColors.Control;
            btnAccSave.Location = new Point(600, 330);
            btnAccSave.Name = "btnAccSave";
            btnAccSave.Size = new Size(94, 35);
            btnAccSave.TabIndex = 13;
            btnAccSave.Text = "Save";
            btnAccSave.UseVisualStyleBackColor = false;
            btnAccSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 275);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 9;
            label6.Text = "Role : ";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(281, 272);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(527, 28);
            cbRole.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(281, 222);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(527, 26);
            txtFullName.TabIndex = 7;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(281, 172);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(527, 26);
            txtRePass.TabIndex = 6;
            txtRePass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(281, 122);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(527, 26);
            txtPass.TabIndex = 5;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 225);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Full Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 175);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 3;
            label4.Text = "Re-type Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 125);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(281, 72);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(527, 26);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 75);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "User Name :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(btnPassCancel);
            tabPage2.Controls.Add(btnPassSave);
            tabPage2.Controls.Add(txtRePass2);
            tabPage2.Controls.Add(txtNPass2);
            tabPage2.Controls.Add(txtPass2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtPassUsername);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(920, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Change Password";
            // 
            // btnPassCancel
            // 
            btnPassCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPassCancel.BackColor = Color.LightGray;
            btnPassCancel.FlatAppearance.BorderSize = 0;
            btnPassCancel.FlatStyle = FlatStyle.Flat;
            btnPassCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnPassCancel.Location = new Point(717, 288);
            btnPassCancel.Name = "btnPassCancel";
            btnPassCancel.Size = new Size(94, 35);
            btnPassCancel.TabIndex = 17;
            btnPassCancel.Text = "Cancel";
            btnPassCancel.UseVisualStyleBackColor = false;
            // 
            // btnPassSave
            // 
            btnPassSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPassSave.BackColor = Color.FromArgb(0, 70, 160);
            btnPassSave.FlatAppearance.BorderSize = 0;
            btnPassSave.FlatStyle = FlatStyle.Flat;
            btnPassSave.ForeColor = SystemColors.Control;
            btnPassSave.Location = new Point(603, 288);
            btnPassSave.Name = "btnPassSave";
            btnPassSave.Size = new Size(94, 35);
            btnPassSave.TabIndex = 16;
            btnPassSave.Text = "Save";
            btnPassSave.UseVisualStyleBackColor = false;
            // 
            // txtRePass2
            // 
            txtRePass2.Location = new Point(284, 227);
            txtRePass2.Name = "txtRePass2";
            txtRePass2.Size = new Size(527, 26);
            txtRePass2.TabIndex = 15;
            // 
            // txtNPass2
            // 
            txtNPass2.Location = new Point(284, 177);
            txtNPass2.Name = "txtNPass2";
            txtNPass2.Size = new Size(527, 26);
            txtNPass2.TabIndex = 14;
            // 
            // txtPass2
            // 
            txtPass2.Location = new Point(284, 127);
            txtPass2.Name = "txtPass2";
            txtPass2.Size = new Size(527, 26);
            txtPass2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 230);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 12;
            label7.Text = "Re-type Password :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(120, 180);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 11;
            label8.Text = "New Password :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 130);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 10;
            label9.Text = "Current Password :";
            // 
            // txtPassUsername
            // 
            txtPassUsername.Location = new Point(284, 77);
            txtPassUsername.Name = "txtPassUsername";
            txtPassUsername.Size = new Size(527, 26);
            txtPassUsername.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(120, 80);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 8;
            label10.Text = "User Name :";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(dgvUser);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(920, 424);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Activate/ UnActivate Account";
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.BackgroundColor = SystemColors.Control;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column8, Column4, Column3, Column5, Column6, Column7, Edit, Delete });
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Location = new Point(3, 3);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersVisible = false;
            dgvUser.Size = new Size(914, 418);
            dgvUser.TabIndex = 2;
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
            Column2.Visible = false;
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
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Barcode";
            Column4.Name = "Column4";
            Column4.Width = 96;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Brand";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Category";
            Column5.Name = "Column5";
            Column5.Width = 102;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Price";
            Column6.Name = "Column6";
            Column6.Width = 69;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Re-Order";
            Column7.Name = "Column7";
            Column7.Width = 99;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.Name = "Edit";
            Edit.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Cancel;
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(materialTabControl1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "UserAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAccount";
            panel1.ResumeLayout(false);
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private TextBox txtFullName;
        private TextBox txtRePass;
        private TextBox txtPass;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtUserName;
        private Label label6;
        private ComboBox cbRole;
        public Button btnAccCancel;
        public Button btnAccSave;
        private TextBox txtRePass2;
        private TextBox txtNPass2;
        private TextBox txtPass2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtPassUsername;
        private Label label10;
        public Button btnPassCancel;
        public Button btnPassSave;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}