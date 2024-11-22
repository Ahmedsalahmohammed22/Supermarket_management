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

    public partial class Product : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        SqlDataReader dr;
        public Product()
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            LoadProduct();

        }

        //Data retrieve from tbProduct to dgvProduct on product form
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand(
                "SELECT p.id, p.name, p.barcode, b.brand AS brand, c.category AS category, p.price, p.reorder " +
                "FROM tbProduct AS p " +
                "INNER JOIN tbBrand AS b ON b.id = p.bid " +
                "INNER JOIN tbCategory AS c ON c.id = p.cid " +
                "WHERE p.name LIKE @searchText OR b.brand LIKE @searchText OR c.category LIKE @searchText",
                cn
            );
            cmd.Parameters.AddWithValue("@searchText", "%" + txtSearch.Text + "%");
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule.ShowDialog();
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete brand by cell click from tbBrand
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModule product = new ProductModule(this);
                product.lblId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.textPname.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.textBarcode.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.cboBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.cboCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.textPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.UDReOrder.Value = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());


                product.btnSave.Enabled = false;
                product.btnUpdate.Enabled = true;
                product.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tbProduct WHERE id LIKE '" + dgvProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successful deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            LoadProduct();
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialMultiLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
