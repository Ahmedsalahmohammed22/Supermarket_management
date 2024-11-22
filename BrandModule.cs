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
    public partial class BrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        Brand _brand;
        public BrandModule(Brand brand)
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            _brand = brand;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbBrand(brand)VALUES(@brand)", cn);
                    cmd.Parameters.AddWithValue("@brand", textBrand.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successful saved.", "POS");
                    Clear();
                    _brand.LoadBrand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            textBrand.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            textBrand.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update brand name 
            if (MessageBox.Show("Are you sure you want to update this brand?", "update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE tbBrand SET brand = @brand WHERE id LIKE '" + lblId.Text + "'", cn);
                cmd.Parameters.AddWithValue("@brand", textBrand.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand has been successfully updated.", "POS");
                Clear();
                this.Dispose(); // to close this form after update data
            }
        }
    }
}
