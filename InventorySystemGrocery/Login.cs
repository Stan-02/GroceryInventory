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

       
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "";
            string _password = "";
            bool found = false;
            try
            {
                connect.Open();
                command = new SqlCommand("select * from tblAccount where UserName = @UserName and Password = @Password", connect);
                command.Parameters.AddWithValue("@UserName", username.Text);
                command.Parameters.AddWithValue("@Password", password.Text);


                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    _username = reader["UserName"].ToString();
                    _password = reader["Password"].ToString();

                    found = true;
                }
                else
                {
                    found = true;
                }

                if (found == true)
                {
                    MessageBox.Show(_username, "Access granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    username.Clear();
                    password.Clear();
                    this.Hide();
                    
                    

                }
                else
                {
                    MessageBox.Show("Invalid username or password ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
            catch(Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
