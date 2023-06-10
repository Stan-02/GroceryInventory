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
            viewItemList();
        }

        public void viewItemList()
        {
            int i = 0;
            DGVinventory.Rows.Clear();
            command = new SqlCommand("Select * from Product WHERE CONCAT(ProductID,ProductDescription,Quantity,Price,CategoryID) LIKE '%" + txtSearchProd.Text + "%'", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i++;
                DGVinventory.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductDesc"].ToString(), reader["Category"].ToString(), reader["Price"].ToString(), reader["Quantity"].ToString(), reader["Date"].ToString(), reader["ExpDate  "].ToString());
            }
            reader.Close();
            connect.Close();
        }

        int qty = 0;

        private void DGVinventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdCode.Text = DGVinventory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtProdDesc.Text = DGVinventory.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = DGVinventory.Rows[e.RowIndex].Cells[5].Value.ToString();
            qty = Convert.ToInt32(DGVinventory.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(nudQuantity.Value) > qty) 
            {
                MessageBox.Show("The Quantity is not enough!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQuantity.Value = nudQuantity.Value - 1;
                return;
            }
            int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(nudQuantity.Value);
            txtTotal.Text = total.ToString();
        }

      
    }
}
