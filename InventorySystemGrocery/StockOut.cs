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

        int qty = 0;

        private void DGVinventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdName.Text = DGVinventory.Rows[e.RowIndex].Cells[2].Value.ToString();
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
            int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(numericQty.Value);
            txtTotal.Text = total.ToString();
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
            txtProdName.Clear();
            txtTotal.Clear();
            
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            viewItemList();
        }
    }
}
