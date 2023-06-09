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
    public partial class CategoryList : Form
    {
        public CategoryList()
        {
            InitializeComponent();
        }

    

        private void btnCatExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DGVCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
