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
    public partial class ProductStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";
        StockIn _stockIn;
        public ProductStockIn(StockIn stockIn)
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            LoadProduct();
            _stockIn = stockIn;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if(_stockIn.txtStockInBy.Text == string.Empty) 
                {
                    MessageBox.Show("Please enter stock in by name", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Dispose();
                    _stockIn.txtStockInBy.Focus();
                    return;
                }

                if (MessageBox.Show("Add this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tbStockIn(refno, pid, sdate, stockinby, supplierid)VALUES(@refno, @pid, @sdate, @stockinby, @supplierid)", cn);
                        cmd.Parameters.AddWithValue("@refno", _stockIn.txtRefNo.Text);
                        cmd.Parameters.AddWithValue("@pid", dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@sdate", _stockIn.dtStockIn.Value);
                        cmd.Parameters.AddWithValue("@stockinby", _stockIn.txtStockInBy.Text);
                        cmd.Parameters.AddWithValue("@supplierid", _stockIn.lblId.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        _stockIn.LoadStockIn();
                        MessageBox.Show("Successfully added", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, stitle);

                    }
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Data retrieve from tbProduct to dgvProduct on product form
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand(
                "SELECT id, name, qty " +
                "FROM tbProduct AS p " +
                "WHERE p.name LIKE @searchText",
                cn
            );
            cmd.Parameters.AddWithValue("@searchText", "%" + txtSearch.Text + "%");
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
