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
    public partial class LookUpProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        SqlDataReader dr;
        Cashier _cashier;

        public LookUpProduct(Cashier cashier)
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            LoadProduct();
            _cashier = cashier;

        }
        //Data retrieve from tbProduct to dgvProduct on product form
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand(
                "SELECT p.id, p.name, p.barcode, b.brand AS brand, c.category AS category, p.price, p.qty " +
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete brand by cell click from tbBrand
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            int pid = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
            double price = double.Parse(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
            int pQty = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

            if (colName == "Select")
            {
                Qty qty = new Qty(_cashier);
                qty.ProductDetails(pid, price, _cashier.lblTransNo.Text, pQty);
                qty.ShowDialog();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LookUpProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
