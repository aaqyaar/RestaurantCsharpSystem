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
    public partial class frmOrders : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlDataReader reader;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void dashboard_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDashboard().ShowDialog();
            this.Close();
        }

        private void user_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUsers().ShowDialog();
            this.Close();
        }

        private void products_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProducts().ShowDialog();
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

        private void frmOrders_Load(object sender, EventArgs e)
        {
            getOrders();
            getEmployees();
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
                    cmbProductCategory.Items.Add(reader[1].ToString());
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
        private void getEmployees()
        {
            conn.Close();
            conn.Open();
            try
            {
                string query = "EXEC sp_listEmployees";
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbOrderRefEmployee.Items.Add(reader[1].ToString());
                }
                reader.Close();
                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void getOrders()
        {
            conn.Open();
            try
            {     
                string query = "EXEC sp_listOrders";
                DataTable dataTable = new DataTable();
                command = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(command);
                commandBuilder = new SqlCommandBuilder(adapter);
                dataTable.Clear();
                adapter.Fill(dataTable);
                ordersGridView.DataSource = dataTable;
                ordersGridView.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnListOrders_Click(object sender, EventArgs e)
        {
            getOrders();
        }

        private void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cmbProductCategory.Text;

            try
            {
                string query = "EXEC sp_findProductsByCategory '"+value+"'";
                conn.Open();
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                listBoxProducts.Items.Clear();
                while (reader.Read())
                {
                    listBoxProducts.Items.Add(reader[1].ToString());
                }
                reader.Close();
                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string product = listBoxProducts.GetItemText(listBoxProducts.SelectedItem);
            string refEmployee = cmbOrderRefEmployee.Text;
            string status = cmbOrderStatus.Text;
            string qty = txtOrderQty.Text;
            string price = txtOrderTotal.Text;
            if (product == "" || refEmployee == "" || status == "" || qty == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                HandleSubmit(product, refEmployee, status, qty, price);
            }

        }
        private string findProductByName(string product)
        {
            string id = "";
            string sql = "EXEC sp_findProductByName '" + product + "'";
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
        private string findEmployeeByName(string product)
        {
            string id = "";
            string sql = "EXEC sp_findEmployeeByName '" + product + "'";
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
            string product, string refEmployee, string status, string qty, string price
            )
        {
            try
            {
                decimal quantity;
                decimal total;
                decimal.TryParse(qty, out quantity);
                decimal.TryParse(price, out total);

                decimal order_total = total * quantity;

                // find product by name
                int productId = int.Parse(findProductByName(product));
                // find employee by name
                int employeeId = int.Parse(findEmployeeByName(refEmployee));
                // create order operation
                string query = "EXEC sp_createOrder '" + productId + "', '" + employeeId + "', '" + status + "', '" + quantity + "', '" + order_total + "'";
                conn.Open();
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Order is successfuly created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                command.Dispose();
                conn.Close();


                resetForm();
                // refresh orders
                getOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetForm()
        {
            cmbProductCategory.Text = "";
            txtOrderID.Clear();
          txtOrderTotal.Clear();
            txtOrderQty.Clear();
            cmbOrderStatus.Text = "";
            cmbOrderRefEmployee.Text = "";
            listBoxProducts.SelectedIndex = -1;

            cmbProductCategory.Focus();
        }

        private void txtOrderQty_TextChanged(object sender, EventArgs e)
        {
            if (txtOrderQty.Text == "")
            {
                lblCheckQuantity.Text = "";
            } else
            {

           
            try
            {
                string product = listBoxProducts.GetItemText(listBoxProducts.SelectedItem);
                int quantity;
                int.TryParse(txtOrderQty.Text, out quantity);
                conn.Open();
                string query = "EXEC sp_checkIsAvailable '"+product+"', '"+quantity+"'";
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    lblCheckQuantity.Text = "Not Available";
                    lblCheckQuantity.ForeColor = Color.IndianRed;
                    btnCreateOrder.Enabled = false;
                }
                else
                {
                    lblCheckQuantity.Text = "Available";
                    lblCheckQuantity.ForeColor = Color.LightGreen;
                    btnCreateOrder.Enabled = true;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOrderQty.Enabled = true;
            string product = listBoxProducts.GetItemText(listBoxProducts.SelectedItem);
            string sql = "EXEC sp_findProductByName '" + product + "'";
            conn.Open();
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtOrderTotal.Text = reader[5].ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            //   'Abdi Zamed'
            if (txtSearchOrder.Text == "")
            {
                getOrders();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_searchOrder @value='" + txtSearchOrder.Text.ToString() + "'";
                    DataTable dataTable = new DataTable();
                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    ordersGridView.DataSource = dataTable;
                    ordersGridView.Refresh();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_deleteOrder @id = '" + txtOrderID.Text + "'";
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    resetForm();
                    command.Dispose();
                    conn.Close();
                    // refresh orders 
                    getOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = ordersGridView.CurrentRow.Cells[0].Value.ToString();
        //    cmbProductCategory.Text = ordersGridView.CurrentRow.Cells[1].Value.ToString();
            listBoxProducts.Text = ordersGridView.CurrentRow.Cells[1].Value.ToString();
            cmbOrderRefEmployee.Text = ordersGridView.CurrentRow.Cells[2].Value.ToString();
            cmbOrderStatus.Text = ordersGridView.CurrentRow.Cells[3].Value.ToString();
            txtOrderQty.Text = ordersGridView.CurrentRow.Cells[4].Value.ToString();
            txtOrderTotal.Text = ordersGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            string _id = txtOrderID.Text;
            string product = listBoxProducts.GetItemText(listBoxProducts.SelectedItem);
            string refEmployee = cmbOrderRefEmployee.Text;
            string status = cmbOrderStatus.Text;
            string qty = txtOrderQty.Text;
            string price = txtOrderTotal.Text;
            if (_id == "" || product == "" || refEmployee == "" || status == "" || qty == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleUpdate(_id,product, refEmployee, status, qty, price);
            }
        }

        private void HandleUpdate(string id,
         string product, string refEmployee, string status, string qty, string price
         )
        {
            try
            {
                decimal quantity;
                decimal total;
                decimal.TryParse(qty, out quantity);
                decimal.TryParse(price, out total);

                decimal order_total = total * quantity;

                // find product by name
                int productId = int.Parse(findProductByName(product));
                // find employee by name
                int employeeId = int.Parse(findEmployeeByName(refEmployee));
                // create order operation
                string query = "EXEC sp_updateOrder '"+id+"', '" + productId + "', '" + employeeId + "', '" + status + "', '" + quantity + "', '" + order_total + "'";
                conn.Open();
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Order is successfuly updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.Dispose();
                conn.Close();
                resetForm();

                // refresh orders
                getOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeneralOrders_Click(object sender, EventArgs e)
        {
            frmGeneralOrdersRpt rpt = new frmGeneralOrdersRpt();
            rpt.ShowDialog();
        }
    }
}
