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
            command = new SqlCommand("Select * from Product WHERE CONCAT(ProductCode,ProductDesc, CategoryName, Quantity, Price, Date, ExpDate) LIKE '%" + txtSearchProd.Text + "%'", connect);
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

        private void DGVinventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVinventory.Columns[e.ColumnIndex].Name;

            if (colname == "Edit")
            {
                Register addprod = new Register();
                //addprod.lblProductID.Text = DGVPurchaselist.Rows[e.RowIndex].Cells[1].Value.ToString();
                addprod.txtProductCode.Text = DGVinventory.Rows[e.RowIndex].Cells[1].Value.ToString();
                addprod.txtProductName.Text = DGVinventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                addprod.cbCategory.Text = DGVinventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                addprod.txtQuantity.Text = DGVinventory.Rows[e.RowIndex].Cells[4].Value.ToString();
                addprod.txtPrice.Text = DGVinventory.Rows[e.RowIndex].Cells[5].Value.ToString();
                addprod.dtpRegDate.Text = DGVinventory.Rows[e.RowIndex].Cells[6].Value.ToString();
                addprod.dtpExpiration.Text = DGVinventory.Rows[e.RowIndex].Cells[7].Value.ToString();

                addprod.btnAdd.Enabled = false;
                //addprod.btnUpdate.Enabled = true;
                addprod.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    command = new SqlCommand("DELETE FROM Category WHERE ProductCode LIKE '" + DGVinventory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Open();
                    MessageBox.Show("Category has been successfully delete!");
                }
            }
            viewItemList();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            /*if(Convert.ToInt32(nudQuantity.Value) > qty) 
            {
                MessageBox.Show("The Quantity is not enough!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQuantity.Value = nudQuantity.Value - 1;
                return;
            }
            int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(nudQuantity.Value);
            txtTotal.Text = total.ToString();*/
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            StockOutHistory stckHistory = new StockOutHistory();
            stckHistory.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        
    }
}
