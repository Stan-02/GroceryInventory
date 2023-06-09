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
    public partial class CategoryList : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader reader;
        public CategoryList()
        {
            InitializeComponent();
        }

        public void loadCategory()
        {
            int i = 0;
            DGVCategory.Rows.Clear();
            command = new SqlCommand("Select * from Category", connect);
            connect.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                i += 1;
                DGVCategory.Rows.Add(i, reader["CategoryID"].ToString(), reader["CategoryName"].ToString());
            }
            reader.Close();
            connect.Close();
        }

        private void btnCatExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DGVCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVCategory.Columns[e.ColumnIndex].Name;
            
            if(colname == "Edit")
            {
                AddCategory addCat = new AddCategory();
                
            }
        }
    }
}
