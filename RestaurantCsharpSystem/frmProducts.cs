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
    public partial class frmProducts : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        SqlDataReader reader;
        public frmProducts()
        {
            InitializeComponent();
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

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            string _name = txtProductName.Text;
            string _category = cmbCategory.Text;
            string _qty = txtProductQty.Text;
            string _cost = txtProductCost.Text;
            string _price = txtProductPrice.Text;

            if (_name == "" || _category == "" || _qty == "" || _cost == "" || _price =="")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                HandleSubmit(_name, _category, _qty, _cost, _price);
            }
        }
        private string findCategoryByName(string category)
        {
            string id = "";
            string sql = "EXEC sp_findCategoryByName '" + category + "'";
            conn.Open();
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader[0].ToString();
            }

            reader.Close();
            conn.Close();

            return id;
        }
        private void HandleSubmit(
            string name, string category, string qty, string originalPrice, string salePrice
            ) {
            
            try
            {
                string categoryId = findCategoryByName(category);
                conn.Open();
                string query = "EXEC sp_createProduct @name = @prodName, @category = @prodCategory, @quantity = @prodQty, @originalPrice = @prodCost, @salePrice = @prodPrice";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@prodName", name);
                command.Parameters.AddWithValue("@prodCategory", categoryId);
                command.Parameters.AddWithValue("@prodQty", qty);
                command.Parameters.AddWithValue("@prodCost", originalPrice);
                command.Parameters.AddWithValue("@prodPrice", salePrice);

                command.ExecuteNonQuery();
                resetForm();
                reader.Close();
                command.Dispose();
                conn.Close();
                // refresh products 
                getProducts();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
            conn.Close();
        }

        private void resetForm()
        {
            txtProductName.Clear();
            cmbCategory.Text = "";
            txtProductCost.Clear();
            txtProductId.Clear();
            txtProductPrice.Clear();
            txtProductCost.Clear();
            txtProductQty.Clear();

            txtProductName.Focus();
        }


        private void getProducts()
        {
            try
            {
                conn.Open();
                string query = "EXEC sp_listProducts";
                DataTable dataTable = new DataTable();
                command = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(command);
                commandBuilder = new SqlCommandBuilder(adapter);
                dataTable.Clear();
                adapter.Fill(dataTable);       
                productsGridView.DataSource = dataTable;
                productsGridView.Columns[0].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                productsGridView.Columns[1].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                productsGridView.Columns[2].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                productsGridView.Columns[3].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                productsGridView.Columns[4].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                productsGridView.Columns[5].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                productsGridView.Columns[6].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                productsGridView.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = false;
            getProducts();
            getCategories();

        }

        private void getCategories()
        {
            conn.Close();
            conn.Open();
            try
            {
                string query = "EXEC sp_listCategory";
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbCategory.Items.Add(reader[1].ToString());
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            getProducts();
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_deleteProduct @id = '" + txtProductId.Text + "'";
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    resetForm();
                    command.Dispose();
                    conn.Close();
                    // refresh products 
                    getProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = productsGridView.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = productsGridView.CurrentRow.Cells[1].Value.ToString();
            cmbCategory.Text = productsGridView.CurrentRow.Cells[2].Value.ToString();
            txtProductQty.Text = productsGridView.CurrentRow.Cells[3].Value.ToString();
            txtProductCost.Text = productsGridView.CurrentRow.Cells[4].Value.ToString();
            txtProductPrice.Text = productsGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "")
            {
                getProducts();
            } else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_searchProduct @value='"+txtSearchProduct.Text.ToString()+"'";
                    DataTable dataTable = new DataTable();
                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    productsGridView.DataSource = dataTable;
                    productsGridView.Refresh();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string _id = txtProductId.Text;
            string _name = txtProductName.Text;
            string _category = cmbCategory.Text;
            string _qty = txtProductQty.Text;
            string _cost = txtProductCost.Text;
            string _price = txtProductPrice.Text;

            if (_id == "" || _name == "" || _category == "" || _qty == "" || _cost == "" || _price == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleUpdate(_id, _name, _category, _qty, _cost, _price);
            }
        }

        private void HandleUpdate(string id,
              string name, string category, string qty, string originalPrice, string salePrice
              )
        {
           
            try
            {
                // 
                string categoryId = findCategoryByName(category);
                conn.Open();
                string query = "EXEC sp_updateProduct @id = @prodId, @name = @prodName, @category = @prodCategory, @quantity = @prodQty, @originalPrice = @prodCost, @salePrice = @prodPrice";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@prodId", id);
                command.Parameters.AddWithValue("@prodName", name);
                command.Parameters.AddWithValue("@prodCategory", categoryId);
                command.Parameters.AddWithValue("@prodQty", qty);
                command.Parameters.AddWithValue("@prodCost", originalPrice);
                command.Parameters.AddWithValue("@prodPrice", salePrice);

                command.ExecuteNonQuery();
                resetForm();

                command.Dispose();
                conn.Close();
                // refresh products 
                getProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnGeneralProductsRpt_Click(object sender, EventArgs e)
        {
            frmGeneralProductsRpt report = new frmGeneralProductsRpt();
            report.ShowDialog();
        }

        private void category_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCategory().ShowDialog();
            this.Close();
        }
    }
}
