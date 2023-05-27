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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            forTimer.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
           //setdate.
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settfrm = new Settings() { TopLevel = false, TopMost = true };
            //settfrm.FormBorderStyle = (FormBorderStyle)cboFormStyle.SelectedIndex;
            this.pnAllform.Controls.Add(settfrm);
            settfrm.Show();
        }
    }
}
