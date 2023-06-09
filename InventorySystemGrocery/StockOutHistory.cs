﻿using System;
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
            connect = new SqlConnection(dbcon.connectdb());
            loadOrder();
            searchOrder();
        }

        public void searchOrder()
        {
            int i = 0;
            DGVHisInvent.Rows.Clear();
            command = new SqlCommand("SELECT * FROM StockOut WHERE CONCAT(StockoutID, ProductCode, ProductDesc, Quantity, Price, Date, Total) LIKE '%" + txtSearchHistory.Text + "%'", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i++;
                DGVHisInvent.Rows.Add(i, reader["StockoutID"].ToString(), reader["ProductCode"].ToString(), reader["ProductDesc"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString(), reader["Date"].ToString(), reader["Total"].ToString());
            }
            reader.Close();
            connect.Close();
        }
        public void loadOrder()
        {
            int i = 0;
            DGVHisInvent.Rows.Clear();
            command = new SqlCommand("SELECT * FROM StockOut ", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i++;
                DGVHisInvent.Rows.Add(i, reader["StockoutID"].ToString(), reader["ProductCode"].ToString(), reader["ProductDesc"].ToString(), reader["Quantity"].ToString(), reader["Price"].ToString(), reader["Date"].ToString(), reader["Total"].ToString());
            }
            reader.Close();
            connect.Close();
        }



        private void txtSearchHistory_TextChanged(object sender, EventArgs e)
        {
            searchOrder();
        }

        private void DGVHisInvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            StockOut stockOut = new StockOut();
            stockOut.lblStockID.Text = DGVHisInvent.Rows[e.RowIndex].Cells[1].Value.ToString();
            stockOut.txtProdCode.Text = DGVHisInvent.Rows[e.RowIndex].Cells[2].Value.ToString();
            stockOut.txtProdDesc.Text = DGVHisInvent.Rows[e.RowIndex].Cells[3].Value.ToString();
            stockOut.numericQty.Value = Convert.ToInt32(DGVHisInvent.Rows[e.RowIndex].Cells[4].Value.ToString());
            stockOut.txtPrice.Text = DGVHisInvent.Rows[e.RowIndex].Cells[5].Value.ToString();
            stockOut.dtpOrderDate.Value = Convert.ToDateTime(DGVHisInvent.Rows[e.RowIndex].Cells[6].Value.ToString());
            stockOut.txtTotal.Text = DGVHisInvent.Rows[e.RowIndex].Cells[7].Value.ToString();
            
         
            stockOut.ShowDialog();
            //loadOrder(); 
        }

        private void btnCatExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
