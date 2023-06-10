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
         
        }

        public void viewItemList()
        {
            int i = 0;
            DGVPurchaseHist.Rows.Clear();
            command = new SqlCommand("Select * from Product", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                i++;
                DGVPurchaseHist.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductDesc"].ToString(), reader["Category"].ToString(), reader["Price"].ToString(), reader["Quantity"].ToString(), reader["Date"].ToString(), reader["ExpDate  "].ToString());
            }
            reader.Close();
            connect.Close();
        }

        private void DGVPurchaseHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
