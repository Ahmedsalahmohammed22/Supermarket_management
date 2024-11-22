using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        string stitle = "Point Of Sales";
        Supplier _supplier;
        public SupplierModule(Supplier supplier)
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            _supplier = supplier;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtSupplier.Clear();
            txtAddress.Clear();
            txtConInfo.Clear();
            txtPhone.Clear();

            txtSupplier.Enabled = true;
            txtSupplier.Focus();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbSupplier (supplierName, address, phone, contactInfo) VALUES(@supplierName, @address, @phone, @contactInfo)", cn);
                    cmd.Parameters.AddWithValue("@supplierName", txtSupplier.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@contactInfo", txtConInfo.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successful saved.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    _supplier.LoadSuppliers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Update this record? click yes to confirm", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("UPDATE tbsUPPLIER SET supplierName = @supplierName, address = @address, phone = @phone, contactInfo = @contactInfo WHERE id LIKE @id", cn);
                    cmd.Parameters.AddWithValue("@id", lblId.Text);
                    cmd.Parameters.AddWithValue("@supplierName", txtSupplier.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@contactInfo", txtConInfo.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successful updated.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message , "Warning");

            }
        }
    }
}
