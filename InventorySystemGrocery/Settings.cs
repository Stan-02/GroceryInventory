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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

 

        private void btnRestor_Click(object sender, EventArgs e)
        {
            Restore res = new Restore();
            res.Show();
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup bac = new Backup();
            bac.Show();
        }

        private void btnSavedt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("timedate.cpl");
        }
    }
}
