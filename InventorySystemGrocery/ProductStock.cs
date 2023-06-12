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
    public partial class ProductStock : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;

        public ProductStock()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
            searchItems();
            loadProduct();
         
        }
        
        public void loadProduct()
        {
            int i = 0;
            DGVPurchaselist.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Product ",connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i++;
                DGVPurchaselist.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductName"].ToString(), reader["ProductDesc"].ToString(), reader["CategoryName"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString(), reader["Date"].ToString(), reader["ExpDate"].ToString());
            }
            reader.Close();
            connect.Close();

        }

        public void searchItems()
        {
            int i = 0;
            DGVPurchaselist.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Product WHERE CONCAT(ProductCode, ProductName, ProductDesc, CategoryName, Quantity, Price, Date, ExpDate) LIKE '%" + txtSearch.Text +"%'" , connect);
            connect.Open();
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                i++;
                DGVPurchaselist.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductName"].ToString(), reader["ProductDesc"].ToString(), reader["CategoryName"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString(), reader["Date"].ToString(), reader["ExpDate"].ToString());
            }
            reader.Close();
            connect.Close();
        }

        private void DGVPurchaselist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colname = DGVPurchaselist.Columns[e.ColumnIndex].Name;

            if (colname == "Edit")
            {
                Register addprod = new Register();
                addprod.txtProductCode.Text = DGVPurchaselist.Rows[e.RowIndex].Cells[1].Value.ToString();
                addprod.txtProductName.Text = DGVPurchaselist.Rows[e.RowIndex].Cells[2].Value.ToString();
                addprod.txtProductDesc.Text = DGVPurchaselist.Rows[e.RowIndex].Cells[3].Value.ToString();
                addprod.cbCategory.Text = DGVPurchaselist.Rows[e.RowIndex].Cells[4].Value.ToString();
                addprod.txtQuantity.Text = DGVPurchaselist.Rows[e.RowIndex].Cells[5].Value.ToString();
                addprod.txtPrice.Text = DGVPurchaselist.Rows[e.RowIndex].Cells[6].Value.ToString();
                addprod.dtpRegDate.Value = Convert.ToDateTime(DGVPurchaselist.Rows[e.RowIndex].Cells[7].Value.ToString());
                addprod.dtpExpiration.Value = Convert.ToDateTime(DGVPurchaselist.Rows[e.RowIndex].Cells[8].Value.ToString());

                addprod.btnAdd.Enabled = false;
                addprod.btnUpdate.Enabled = true;
                addprod.btnGenerate.Enabled = false;
                addprod.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("do you want to delete this Product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    command = new SqlCommand("DELETE FROM Product WHERE ProductCode LIKE '" + DGVPurchaselist.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Product Move to Achive!");
                }
            }
            loadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchItems();
        }
    }
}
