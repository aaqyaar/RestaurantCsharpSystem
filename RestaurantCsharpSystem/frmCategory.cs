using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantCsharpSystem.Database;
using System.Data.SqlClient;

namespace RestaurantCsharpSystem
{
    public partial class frmCategory : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            getCategories();
        }
        private void getCategories()
        {
            try
            {
                conn.Open();
                string query = "EXEC sp_listCategory";
                DataTable dataTable = new DataTable();
                command = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(command);
                commandBuilder = new SqlCommandBuilder(adapter);
                dataTable.Clear();
                adapter.Fill(dataTable);
                categoryDataGridView.DataSource = dataTable;
                categoryDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                categoryDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);

                categoryDataGridView.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void HandleSubmit(
            string name
            )
        {
            conn.Open();
            try
            {

                string query = "EXEC sp_createCategory @name";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", name);
           

                command.ExecuteNonQuery();
                resetForm();

                command.Dispose();
                conn.Close();
                // refresh products 
                getCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void resetForm()
        {
            txtCategoryId.Clear();

            txtCategoryName.Clear();
            txtCategoryName.Focus();
        }


        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryId.Text = categoryDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = categoryDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {

            string _name = txtCategoryName.Text;


            if (_name == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleSubmit(_name);
            }
        }

      
        private void HandleUpdate(string id,
              string name
              )
        {
            conn.Open();
            try
            {

                string query = "EXEC sp_updateCategory @id = @catId, @name = @catName";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@catId", id);
                command.Parameters.AddWithValue("@catName", name);
             

                command.ExecuteNonQuery();
                resetForm();

                command.Dispose();
                conn.Close();
                // refresh products 
                getCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string _id = txtCategoryId.Text;
            string _name = txtCategoryName.Text;


            if (_id == "" || _name == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleUpdate(_id, _name);
            }
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryId.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_deleteCategory @id = '" + txtCategoryId.Text + "'";
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    resetForm();
                    command.Dispose();
                    conn.Close();
                    // refresh products 
                    getCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCategory.Text == "")
            {
                getCategories();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_searchCategory @value='" + txtSearchCategory.Text.ToString() + "'";
                    DataTable dataTable = new DataTable();
                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    categoryDataGridView.DataSource = dataTable;
                    categoryDataGridView.Refresh();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void user_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUsers().ShowDialog();
            this.Close();
        }

        private void dashboard_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDashboard().ShowDialog();
            this.Close();
        }

        private void products_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProducts().ShowDialog();
            this.Close();
        }

        private void orders_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOrders().ShowDialog();
            this.Close();
        }

        private void employees_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmEmployees().ShowDialog();
            this.Close();
        }

        private void payroll_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPayroll().ShowDialog();
            this.Close();
        }
    }


}
