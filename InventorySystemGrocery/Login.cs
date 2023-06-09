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
            string _username = "";
            string _password = "";
            bool found = false;
            try
            {
                connect.Open();
                command = new SqlCommand("select * from tblAccount where UserName = @username and Password = @password", connect);
                command.Parameters.AddWithValue("@UserName", username.Text);
                command.Parameters.AddWithValue("@Password", password.Text);


                reader = command.ExecuteReader();
                reader.Read();
               
                /*if (reader.HasRows)
                {
                    _username = reader["username"].ToString();
                _password = reader["password"].ToString();

                    found = true;
                }
                else
                {
                    found = true;
                }*/

                if (username.Text == _username && password.Text == _password) 
                {
                    MessageBox.Show("Logging in", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    username.Clear();
                    password.Clear();
                    this.Hide();
                    dashboard main = new dashboard();
                    main.Show();

                    //MessageBox.Show("Invalid username or password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                    //MessageBox.Show("Empty field! ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connect.Close();


                }
                else if(username.Text == " " && password.Text == " ")
                {
                    MessageBox.Show("Empty field! ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connect.Close();
                    //MessageBox.Show("Invalid username or password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                }
                else
                {
                    MessageBox.Show("Invalid username or password ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connect.Close();
                    /*MessageBox.Show("Logging in", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    username.Clear();
                    password.Clear();
                    this.Hide();
                    dashboard main = new dashboard();
                    main.Show();*/
                }
            }
            catch(Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit application? ", "Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }
    }
}
