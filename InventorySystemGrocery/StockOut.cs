using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGrocery
{
    public partial class StockOut : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;
        int qty = 0;
        public StockOut()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
            viewItemList();
        }

        public void viewItemList()
        {
            int i = 0;
            DGVinventory.Rows.Clear();
            command = new SqlCommand("Select * from Product WHERE CONCAT(ProductCode, ProductName, ProductDesc, CategoryName, Quantity, Price, Date, ExpDate) LIKE '%" + txtSearchProd.Text + "%'", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i++;
                DGVinventory.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductName"].ToString(), reader["ProductDesc"].ToString(), reader["CategoryName"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString(), reader["Date"].ToString(), reader["ExpDate"].ToString());
            }
            reader.Close();
            connect.Close();
        }
        
        

        private void DGVinventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtProdCode.Text = DGVinventory.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtProdDesc.Text = DGVinventory.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = DGVinventory.Rows[e.RowIndex].Cells[6].Value.ToString();
            qty = Convert.ToInt32(DGVinventory.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void numericQty_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericQty.Value) > qty)
            {
                MessageBox.Show("The Quantity is not enough!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericQty.Value = numericQty.Value - 1;
                return;
            }
            if(Convert.ToInt32(numericQty.Value) > 0)
            {
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(numericQty.Value);
                txtTotal.Text = total.ToString();
            }
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            StockOutHistory stckHistory = new StockOutHistory();
            stckHistory.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        public void Clear()
        {
            txtPrice.Clear();
            txtProdDesc.Clear();
            txtProdCode.Clear();
            txtTotal.Clear();
            numericQty.Value = 0 ;
            
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            viewItemList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to add this product?", "Adding Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                connect.Open();
                command = new SqlCommand("INSERT INTO StockOut (ProductCode, ProductDesc, Quantity, Price, Date, Total) VALUES (@productCode, @productDesc, @quantity, @price, @date, @total)", connect);
                command.Parameters.AddWithValue("@productCode", txtProdCode.Text);
                command.Parameters.AddWithValue("@productDesc", txtProdDesc.Text);
                command.Parameters.AddWithValue("@quantity", Convert.ToInt32(numericQty.Text));
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(txtPrice.Text));
                command.Parameters.AddWithValue("@date", dtpOrderDate.Value.Date);
                command.Parameters.AddWithValue("@total", txtTotal.Text);

                command.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Product has been successfully added!");
                Clear();

                command = new SqlCommand("UPDATE Product SET Quantity = (Quantity - @quantity) WHERE ProductCode LIKE '" + txtProdCode.Text + "'", connect);
                command.Parameters.AddWithValue("@quantity", Convert.ToInt32(numericQty.Value));
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();


                viewItemList();
            }
        }

        public void getQty()
        {
            command = new SqlCommand("Select Quantity from Product WHERE ProductCode =(ProductCode, ProductName, ProductDesc, CategoryName, Quantity, Price, Date, ExpDate) LIKE '%" + txtSearchProd.Text + "%'", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i++;
                DGVinventory.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductName"].ToString(), reader["ProductDesc"].ToString(), reader["CategoryName"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString(), reader["Date"].ToString(), reader["ExpDate"].ToString());
            }
            reader.Close();
            connect.Close();
        }
    }
}
