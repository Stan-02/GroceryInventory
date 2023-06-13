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
    public partial class RecycleBinProduct : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;
        public RecycleBinProduct()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
            showBin();
            DGVProdBin.Refresh();
        }

        public void showBin()
        {
            int i = 0;
            DGVProdBin.Rows.Clear();
            connect.Open();
            command = new SqlCommand("Select * from Product WHERE Archive = 1", connect);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Archive"].ToString() == "1")
                {
                    i += 1;
                    DGVProdBin.Rows.Add(i, reader["ProductCode"].ToString(), reader["ProductName"], reader["ProductDesc"].ToString(), reader["CategoryName"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString());
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnCatExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void DGVProdBin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnProduct = DGVProdBin.Columns[e.ColumnIndex].Name;

            if (columnProduct == "Restore")
            {

                if (MessageBox.Show("Do you want to restore this product?", "Restore the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == DGVProdBin.Columns["Restore"].Index && e.RowIndex >= 0)
                    {
                        int id = Convert.ToInt32(DGVProdBin.Rows[e.RowIndex].Cells["ProductCode"].Value);
                        using (SqlConnection connection = new SqlConnection(dbcon.connectdb()))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("UPDATE Product SET Archive = @Archive WHERE ProductCode = @productCode", connection))
                            {
                                command.Parameters.AddWithValue("@productCode", id);
                                command.Parameters.AddWithValue("@Archive", 0);
                                command.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                        DGVProdBin.Rows.RemoveAt(e.RowIndex);
                        
                    }
                }

            }
            else if (columnProduct == "Delete")
            {
                if (MessageBox.Show("Are you sure to delete this permanently?", "Delete the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    command = new SqlCommand("DELETE from Product where ProductCode like '" + DGVProdBin[1, e.RowIndex].Value.ToString() + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("The selected record has been successfully deleted.", "Tea Hara", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showBin(); 
                }

            }
        }
    }
}
