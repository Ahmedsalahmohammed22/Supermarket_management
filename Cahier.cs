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
    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";

        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            GetTranNo();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void slide(Button button)
        {
            panelSlide.BackColor = Color.White;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;
        }
        #region button
        private void btnNTran_Click(object sender, EventArgs e)
        {
            slide(btnNTran);
            GetTranNo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            slide(btnSearch);
            LookUpProduct lookUpProduct = new LookUpProduct(this);
            lookUpProduct.LoadProduct();
            lookUpProduct.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            slide(btnSettle);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            slide(btnClear);

        }

        private void btnDSales_Click(object sender, EventArgs e)
        {
            slide(btnDSales);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
        }
        #endregion button

        public void LoadCart()
        {
            int i = 0;
            double total = 0;
            double discount = 0;
            dgvCash.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand(
                "SELECT c.id, c.pid, p.name AS pname, p.barcode AS barcode, c.price, c.qty, c.disc, c.total " +
                "FROM tbCart AS c " +
                "INNER JOIN tbProduct AS p ON p.id = c.pid " +
                "WHERE c.transno LIKE @transno AND c.status LIKE 'Pending'",
                cn
            );
            cmd.Parameters.AddWithValue("@transno", lblTransNo.Text);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                total += Convert.ToDouble(dr["total"].ToString());
                discount += Convert.ToDouble(dr["disc"].ToString());
                dgvCash.Rows.Add(i, dr["id"].ToString(), dr["pname"].ToString(), dr["barcode"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()));
            }
            dr.Close();
            cn.Close();
            lblSaleTotal.Text = total.ToString("#,##0.00");
            lblDiscount.Text = discount.ToString("#,##0.00");
            GetCartTotal();
        }

        public void GetCartTotal()
        {
            double discount = double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblSaleTotal.Text) - discount;
            double VAT = sales * 0.14;//VAT : 14%
            double vatable = sales - VAT;

            lblVat.Text = VAT.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotal.Text = sales.ToString("#,##0.00");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void GetTranNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;
                cn.Open();
                cmd = new SqlCommand("SELECT TOP 1 transno from tbCart WHERE transno LIKE '" + sdate + "%' ORDER BY id ", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransNo.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, stitle);
            }

        }
    }
}
