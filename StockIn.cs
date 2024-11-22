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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";

        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            LoadSupplier();

        }

        public void GetRefeNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
        }
        public void LoadSupplier()
        {
            cbSupplier.Items.Clear();
            cbSupplier.DataSource = _connect.getTable("SELECT * FROM tbSupplier");
            cbSupplier.DisplayMember = "supplierName";
        }

        public void LoadStockIn()
        {
            int i = 0;
            dgvStockIn.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM vwStockIn where refno LIKE @refno AND status LIKE 'pending' ", cn);
            cmd.Parameters.AddWithValue("@refno", "%" + txtRefNo.Text + "%");

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[7].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tbStockIn WHERE id = '" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed", stitle , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }
        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tbSupplier WHERE supplierName LIKE '" + cbSupplier.Text + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblId.Text = dr["id"].ToString();
                txtContactInfo.Text = dr["contactInfo"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LinGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefeNo();
        }

        private void linProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStockIn = new ProductStockIn(this);
            productStockIn.ShowDialog();

        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvStockIn.Rows.Count > 0)
                {
                    if(MessageBox.Show("Are you sure you want to save this record?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for(int i = 0; i < dgvStockIn.Rows.Count; i++)
                        {
                            //update product quantity
                            cn.Open();
                            cmd = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " WHERE name LIKE '" + dgvStockIn.Rows[i].Cells[3].Value.ToString()+ "'", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();

                            //update stockIn qty
                            cn.Open();
                            cmd = new SqlCommand("UPDATE tbStockIn SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + ", status='Done' WHERE id LIKE '" + dgvStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                        Clear();
                        LoadStockIn();  
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Clear()
        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockIn.Value = DateTime.Now;
        }
    }
}
