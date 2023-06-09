using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace InventorySystemGrocery
{
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;

        //ProductStock prod_list;

        public Register()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
            //prod_list = stock_list;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductCode.Clear();
            txtProductDesc.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rndCode = new Random();
            int serialCode = rndCode.Next();

            txtProductCode.Text = serialCode.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /*if ((txtProductDesc.Text == string.Empty) || (cbCategory.Text == string.Empty) || (txtQuantity.Text == string.Empty) || (txtPrice.Text == string.Empty))
                {
                    MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/
                if (MessageBox.Show("Are you sure you want to add this product?", "Adding Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   

                    connect.Open();
                    command = new SqlCommand("INSERT INTO Product(ProductCode, ProductDesc, Category, Quantity, Price, Date, ExpDate) VALUES (@productCode, @productDesc, @categoryName, @price, @quantity, @date, @expDate)", connect);
                    command.Parameters.AddWithValue("@productCode", txtProductCode.Text);
                    command.Parameters.AddWithValue("@productDesc", txtProductDesc.Text);
                    command.Parameters.AddWithValue("@categoryName", cbCategory.SelectedItem);
                    command.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity));
                    command.Parameters.AddWithValue("@date", dtpRegDate.Text);
                    command.Parameters.AddWithValue("@expDate", dtpExpiration.Text);

                    command.ExecuteNonQuery();
                    connect.Close();
                    
                    MessageBox.Show("Item Added");
                    Clear();
                }

            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtProductCode.Clear();
            txtProductDesc.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            AddCategory add_cat = new AddCategory();
            add_cat.Show();
        }


    }
}
