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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace POS
{
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        string stitle = "Point Of Sales";
        Product _product;
        public ProductModule(Product product)
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            LoadBrand();
            LoadCategory();
            _product = product;
        }
        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = _connect.getTable("SELECT * FROM tbCategory");
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "id";
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource = _connect.getTable("SELECT * FROM tbBrand");
            cboBrand.DisplayMember = "brand";
            cboBrand.ValueMember = "id";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Clear()
        {
            textPname.Clear();
            textBarcode.Clear();
            textPrice.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            UDReOrder.Value = 1;

            textPname.Enabled = true;
            textPname.Focus();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbProduct(name, barcode, bid, cid, price, reorder)VALUES(@name, @barcode, @bid, @cid, @price, @reorder)", cn);
                    cmd.Parameters.AddWithValue("@name", textPname.Text);
                    cmd.Parameters.AddWithValue("@barcode", textBarcode.Text);
                    cmd.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", double.Parse(textPrice.Text));
                    cmd.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successful saved.", stitle);
                    Clear();
                    _product.LoadProduct();
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbProduct SET name = @name, barcode = @barcode, bid = @bid, cid = @cid, price = @price, reorder = @reorder WHERE id LIKE @id", cn);
                    cmd.Parameters.AddWithValue("@id", lblId.Text);
                    cmd.Parameters.AddWithValue("@name", textPname.Text);
                    cmd.Parameters.AddWithValue("@barcode", textBarcode.Text);
                    cmd.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", textPrice.Text);
                    cmd.Parameters.AddWithValue("@reorder", UDReOrder.Text);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.", stitle);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }

        private void textPname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
