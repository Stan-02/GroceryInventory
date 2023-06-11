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

   

        public Register()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
            loadCategory();
            
        }

        public void loadCategory()
        {
            cbCategory.Items.Clear();
            command = new SqlCommand("SELECT CategoryName FROM Category", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cbCategory.Items.Add(reader["CategoryName"].ToString());
            }
            reader.Close();
            connect.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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
                if ((txtProductCode.Text == string.Empty) || (txtProductName.Text == string.Empty) || (txtProductDesc.Text == string.Empty) || (cbCategory.Text == string.Empty) || (txtQuantity.Text == string.Empty) || (txtPrice.Text == string.Empty))
                {
                    MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to add this product?", "Adding Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    connect.Open();
                    command = new SqlCommand("INSERT INTO Product(ProductCode, ProductName, ProductDesc, CategoryName, Quantity, Price, Date, ExpDate) VALUES (@productCode, @productName,@productDesc, @categoryName, @price, @quantity, @date, @expDate)", connect);
                    command.Parameters.AddWithValue("@productCode", txtProductCode.Text);
                    command.Parameters.AddWithValue("@productName", txtProductName.Text);
                    command.Parameters.AddWithValue("@productDesc", txtProductDesc.Text);
                    command.Parameters.AddWithValue("@categoryName", cbCategory.SelectedItem);
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtPrice.Text));
                    command.Parameters.AddWithValue("@Price", Convert.ToInt32(txtQuantity.Text));
                    command.Parameters.AddWithValue("@date", dtpRegDate.Value.Date);
                    command.Parameters.AddWithValue("@expDate", dtpExpiration.Value.Date);

                    command.ExecuteNonQuery();
                    connect.Close();
                    
                    MessageBox.Show("Product has been successfully added!");
                    Clear();
                }

            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            AddCategory add_cat = new AddCategory();
            add_cat.Show();
        }

        // Created Methods
        public void Clear()
        {
            txtProductName.Clear();
            txtProductCode.Clear();
            txtProductDesc.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cbCategory.Text = null;
        }

     


       
    }
}
