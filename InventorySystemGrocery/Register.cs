using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGrocery
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductCode.Clear();
            txtProductDesc.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rndCode = new Random();
            int serialCode = rndCode.Next();

            txtProductCode.Text = serialCode.ToString();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
