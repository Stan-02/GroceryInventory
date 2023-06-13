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
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;
       
        public Login()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
        }


        private void showHide_CheckedChanged(object sender, EventArgs e)
        {
            if (showHide.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar= true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
            username.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            //Logging in
            if (username.Text != "" & password.Text != "")
            {
               
                command = new SqlCommand("SELECT COUNT(*) FROM tblAccount "+ "WHERE UserName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = @userPassword COLLATE SQL_Latin1_General_CP1_CS_AS", connect);
                {
                    connect.Open();
                    command.Parameters.AddWithValue("@userName", username.Text);
                    command.Parameters.AddWithValue("@userPassword", password.Text);

                    int result = Convert.ToInt32(command.ExecuteScalar());
                    if(result > 0)
                    {
                        username.Clear();
                        password.Clear();
                        this.Hide();
                        dashboard main = new dashboard();
                        main.Show();
                        connect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty field! Please input", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connect.Close();
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Do you want to exit application? ", "Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Login log = new Login();
                log.Show();
            }
           
            
        }
    }
}
