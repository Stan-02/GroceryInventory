using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace InventorySystemGrocery
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dashboard());
        }



    }
    class DatabaseConnection
    {
        public string connectdb()
        {
            string conn = @"Data Source=JERICHO-GARCIA;Initial Catalog=ISGroceryStore;Integrated Security=True";
             //string conn = @"Data Source = DESKTOP - VKHU5QN\SQLEXPRESS; Initial Catalog = ISGroceryStore; Integrated Security = True";
            //string conn = @"Data Source=LAB-A-PC26\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True";
            return conn;
        }
    }
}
