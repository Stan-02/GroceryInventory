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

namespace InventorySystemGrocery
{
    public partial class Purchase : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;

        public Purchase()
        {
            InitializeComponent();
            connect = new SqlConnection(dbcon.connectdb());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {

            }
            catch(Exception ex)
            {

            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard maindash = new dashboard();
            maindash.load_form(new purchaseHistory());
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductCode.Clear();
            txtProductDesc.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rndcode = new Random();
            int serialnumber = rndcode.Next();


            txtProductCode.Text = serialnumber.ToString();
        }
    }
}
