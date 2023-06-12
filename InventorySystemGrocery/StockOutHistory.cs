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
    public partial class StockOutHistory : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;

        public StockOutHistory()
        {
            InitializeComponent();
            loadOrder();
        }

        public void loadOrder()
        {
            int i = 0;
            DGVHisInvent.Rows.Clear();
            command = new SqlCommand("Select * from Product WHERE CONCAT(ProductCode, ProductName, ProductDesc, CategoryName, Quantity, Price, Date, ExpDate) LIKE '%" + txtSearchHistory.Text + "%'", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i++;
                DGVHisInvent.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductName"].ToString(), reader["ProductDesc"].ToString(), reader["CategoryName"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString(), reader["Date"].ToString(), reader["ExpDate"].ToString());
            }
            reader.Close();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
