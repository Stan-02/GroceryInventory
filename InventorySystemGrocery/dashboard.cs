﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGrocery
{
    public partial class dashboard : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        public dashboard()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
            
            
        }
        //load form to main panel
        public void load_form(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();


       
        }
        private void btnupMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnupEnlarge_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnupExit_Click(object sender, EventArgs e)
        {
            DialogResult logout;
            logout = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                this.Dispose();
                Login form = new Login();
                form.Show();

            }
            else
            {
                this.Show();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Settings setdate = new Settings();
            
            forTimer.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");
          
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            load_form(new Settings());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            load_form(new ProductStock());
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            load_form(new Register());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            load_form(new home());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            load_form(new StockOut());
        }

        public void CheckItemQuantity()
        {

            using (SqlConnection connection = new SqlConnection(dbcon.connectdb()))
            {


                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ProductName, Quantity FROM Product", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string item_name = reader.GetString(0);
                    int itemQyt = reader.GetInt32(1);

                    if (itemQyt < 10)
                    {
                        MessageBox.Show("The stock quantity of " + item_name + " is below threshold", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
                    }
                }

               
            }
           
        }
    }
}
