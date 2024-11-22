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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        SqlDataReader dr;
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            LoadRoles();
        }
        public void LoadRoles()
        {
            cbRole.Items.Clear();
            cbRole.DataSource = _connect.getTable("SELECT * FROM tbRole");
            cbRole.DisplayMember = "name";
            cbRole.ValueMember = "id";
        }
        public void Clear()
        {
            txtUserName.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtFullName.Clear();
            cbRole.Text = "";
            txtUserName.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password did not Match!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                cmd = new SqlCommand("INSERT INTO tbUser(username, password, roleId, fullName)VALUES(@username, @password, @roleId, @fullName)", cn);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                cmd.Parameters.AddWithValue("@roleId", cbRole.SelectedValue);
                cmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has been successful saved.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                //_product.LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
