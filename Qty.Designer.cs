namespace POS
{
    partial class Qty
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
            txtQty = new TextBox();
            SuspendLayout();
            // 
            // txtQty
            // 
            txtQty.Dock = DockStyle.Fill;
            txtQty.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(0, 0);
            txtQty.Multiline = true;
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(146, 45);
            txtQty.TabIndex = 0;
            txtQty.TextAlign = HorizontalAlignment.Center;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // Qty
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(146, 45);
            Controls.Add(txtQty);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Qty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Qty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQty;
    }
}