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
        dashboard dash = new dashboard();

        string code, pname, pdesc, pprice, pqty, pcat, pdate, pExpDate;
        public ProductStock()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
            searchItems();
            loadProduct();
            dash.CheckItemQuantity();
         
        }
        
        //Created Methods
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
     
        //End of Created Methods

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
                if (MessageBox.Show("Do you want to delete this product?", "Delete the record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == DGVPurchaselist.Columns["Delete"].Index && e.RowIndex >= 0)
                    {
                        int id = Convert.ToInt32(DGVPurchaselist.Rows[e.RowIndex].Cells["ProductCode"].Value);
                        using (SqlConnection connection = new SqlConnection(dbcon.connectdb()))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("UPDATE Product SET Archive = 1 WHERE ProductCode = @productCode", connection))
                            {
                                command.Parameters.AddWithValue("@productCode", id);
                                command.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                        DGVPurchaselist.Rows.RemoveAt(e.RowIndex);
                        
                        
                    }
                }
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchItems();
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            RecycleBinProduct arhvProd = new RecycleBinProduct();
            arhvProd.Show();
        }

        private void DGVPurchaselist_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                int i;
                code = DGVPurchaselist[1, i].Value.ToString();
                pname= DGVPurchaselist[2, i].Value.ToString();
                pdesc = DGVPurchaselist[3, i].Value.ToString();
                pcat = DGVPurchaselist[4, i].Value.ToString();
                pqty = DGVPurchaselist[5, i].Value.ToString();
                pprice = DGVPurchaselist[6, i].Value.ToString();
                //Convert.ToDateTime(DGVPurchaselist[7, i].Value.ToString(pdate));
                //Convert.ToDateTime(DGVPurchaselist[8, i].Value.ToString(pExpDate));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
