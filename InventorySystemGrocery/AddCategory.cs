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

namespace InventorySystemGrocery
{
    public partial class AddCategory : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        public AddCategory()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
        }



        private void btnCatExit_Click(object sender, EventArgs e)
        {
                Dispose();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                MessageBox.Show("No Input try again!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to save this category?", "Saving Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connect.Open();
                        command = new SqlCommand("INSERT INTO Category(CategoryName)VALUES(@CategoryName)", connect);
                        command.Parameters.AddWithValue("@CategoryName", txtCategory.Text);
                    
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Category has ben successfully added!");
                        Clear();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void Clear()
        {
            txtCategory.Clear();
        }

        private void btnClearCat_Click(object sender, EventArgs e)
        {
            Clear();
            btnAddCat.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Updating Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    command = new SqlCommand("UPDATE Category SET CategoryName = @CategoryName WHERE CategoryID '" + lblCatID.Text + "'", connect);
                    command.Parameters.AddWithValue("@CategoryName", txtCategory.Text);

                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Category has ben successfully added!");
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
