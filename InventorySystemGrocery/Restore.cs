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
    public partial class Restore : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        public Restore()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                if (MessageBox.Show("Are you want to restore your Database? ", "Restoring the database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if ((txtLocation.Text == string.Empty) || (txtDatabase.Text == string.Empty) || (txtServer.Text == string.Empty))
                    {
                        MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        string servername = txtServer.Text;
                        string dbname = txtDatabase.Text;

                        SqlConnection connect = new SqlConnection(@"Data Source=" + servername + ";Initial Catalog=" + dbname + ";Integrated Security=True");

                        connect.Open();

                        string str = "USE master;";
                        string str1 = "ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                        string str2 = "RESTORE DATABASE " + dbname + " FROM DISK = '" + txtLocation.Text + "' WITH REPLACE ";

                        SqlCommand cmd = new SqlCommand(str, connect);
                        SqlCommand cmd1 = new SqlCommand(str1, connect);
                        SqlCommand cmd2 = new SqlCommand(str2, connect);

                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Database Restored Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect.Close();
                        this.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to Restore your Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Browse Text Files";

            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            ofd.DefaultExt = "BAK";
            ofd.Filter = "Text files (*.bak)|*.bak";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = ofd.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtServer.Clear();
            txtLocation.Clear();
            txtDatabase.Clear();

            txtLocation.Focus();
        }

        private void btnCatExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
