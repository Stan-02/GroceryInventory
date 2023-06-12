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
            connect = new SqlConnection(dbcon.connectdb());
            loadCategory();
        }

        public void loadCategory()
        {
            int i = 0;
            DGVCategory.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Category", connect);
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

       

        private void DGVCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVCategory.Columns[e.ColumnIndex].Name;
            
            if(colname == "Edit")
            {
                AddCategory addCat_form = new AddCategory();
                addCat_form.lblCatID.Text = DGVCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                addCat_form.txtCategory.Text = DGVCategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                addCat_form.btnAddCat.Enabled = false;
                addCat_form.btnUpdate.Enabled = true;
                addCat_form.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if(MessageBox.Show("Do you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    connect.Open();
                    command = new SqlCommand("DELETE FROM Category WHERE CategoryID LIKE '" + DGVCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Category has been successfully delete!");
                }
            }
            loadCategory();
        }
        private void btnCatExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCateg = new AddCategory();
            addCateg.Show();
        }
    }
}
