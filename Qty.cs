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
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        SqlDataReader dr;

        private int _pid;
        private double _price;
        private string _transno;
        private int _qty;

        Cashier _cashier;


        public Qty(Cashier cashier)
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            _cashier = cashier;
        }

        public void ProductDetails(int pid, double price, string transno, int qty)
        {
            _pid = pid;
            _price = price;
            _transno = transno;
            _qty = qty;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar == 13) && txtQty.Text != string.Empty)
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO tbCart(transno, pid, price, qty, sdate, cashier)VALUES(@transno, @pid, @price, @qty, @sdate, @cashier)", cn);
                cmd.Parameters.AddWithValue("@transno", _transno);
                cmd.Parameters.AddWithValue("@pid", _pid);
                cmd.Parameters.AddWithValue("@price", _price);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@cashier", _cashier.lblUsername.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                _cashier.LoadCart();
                this.Dispose();


            }
        }
    }
}
