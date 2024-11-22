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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect _connect = new DBConnect();
        Category _category;
        public CategoryModule(Category category)
        {
            InitializeComponent();
            cn = new SqlConnection(_connect.myconnection());
            _category = category;
        }
        public void Clear()
        {
            textCategory.Clear();
            textCategory.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbCategory(category)VALUES(@category)", cn);
                    cmd.Parameters.AddWithValue("@category", textCategory.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successful saved.", "Point Of Sales");
                    Clear();
                }
                _category.LoadCategory();
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
            //update category name 
            if (MessageBox.Show("Are you sure you want to update this category?", "update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE tbCategory SET category = @category WHERE id LIKE '" + lblId.Text + "'", cn);
                cmd.Parameters.AddWithValue("@category", textCategory.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been successfully updated.", "Point Of Sales");
                Clear();
                this.Dispose(); // to close this form after update data
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
