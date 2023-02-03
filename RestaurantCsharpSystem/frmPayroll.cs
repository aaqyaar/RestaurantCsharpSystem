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
    public partial class frmPayroll : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        public frmPayroll()
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
        private void getEmployees()
        {
            conn.Open();
            try
            {
                string query = "EXEC sp_listEmployees";
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbPayrollEmp.Items.Add(reader[1].ToString());
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

        private void frmPayroll_Load(object sender, EventArgs e)
        {
            getPayroll();
            getEmployees();
        }

        private void getPayroll()
        {
            // 
            try
            {
                string query = "EXEC sp_listPayroll";
                DataTable dataTable = new DataTable();
                command = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(command);
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
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            string _id = txtPayrolliD.Text;
            string employee = cmbPayrollEmp.Text;
            string unpaid_orders = txtUnpaidOrders.Text;
            string payroll_type = txtPayrollType.Text;
            string salary = txtEmpSalary.Text;
            string total_payroll = txtTotalPayroll.Text;
            string date = payroll_date.Text;

            if (_id == "" || employee == "" || payroll_type == "" || date == "" || salary == "" || total_payroll == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleUpdate(_id, employee, date, unpaid_orders, payroll_type, salary, total_payroll);
            }
        }
        private void HandleUpdate(string id, string emp, string date, string unpaid, string type, string salary, string total)
        {
            try
            {
                string empId = findEmployeeByName(emp);

                string query = "EXEC sp_updatePayroll @id = '"+id+"', @employee = '" + empId + "', @date = '" + date + "', @type = '" + type + "', @unpaid = '" + unpaid + "', @salary = '" + salary + "', @total = '" + total + "'";
                conn.Open();
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();

                // 
                getPayroll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string employee = cmbPayrollEmp.Text;
            string unpaid_orders = txtUnpaidOrders.Text;
            string payroll_type = txtPayrollType.Text;
            string salary = txtEmpSalary.Text;
            string total_payroll = txtTotalPayroll.Text;
            string date = payroll_date.Text;

            if (employee == "" || payroll_type == "" ||  date == "" || salary == "" || total_payroll == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                HandleSubmit(employee, date, unpaid_orders, payroll_type, salary, total_payroll);
            }
        }
        private void HandleSubmit(string emp, string date,string unpaid, string type, string salary, string total)
        {
            try
            {
                string empId = findEmployeeByName(emp);

                string query = "EXEC sp_createPayroll @employee = '"+empId+"', @date = '"+date+"', @type = '"+type+"', @unpaid = '"+unpaid+"', @salary = '"+salary+"', @total = '"+total+"'";
                conn.Open();
                command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();

                // 
                getPayroll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbPayrollEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employee = cmbPayrollEmp.Text;
            if (employee == "")
            {
                return;
            }
            string empId = findEmployeeByName(employee);
            findUnpaidOrdersByEmp(empId);


            decimal unpaid, salary;
            decimal.TryParse(txtUnpaidOrders.Text, out unpaid);
            decimal.TryParse(txtEmpSalary.Text, out salary);

            decimal total = unpaid != 0 ? salary - unpaid : salary;
            txtTotalPayroll.Text = total.ToString();
        }
        private void findUnpaidOrdersByEmp(string id)
        {
            string sql = "EXEC sp_unpaid_orders_emp '" + id + "'";
            conn.Open();
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtUnpaidOrders.Text = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
        }
        private string findEmployeeByName(string emp)
        {
            string id = "";
            string sql = "EXEC sp_findEmployeeByName '" + emp + "'";
            conn.Open();
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader[0].ToString();
                txtEmpSalary.Text = reader[4].ToString();
            }
            reader.Close();
            conn.Close();
            return id;
        }

        private void txtSearchPayroll_TextChanged(object sender, EventArgs e)
        {
            // @value
            if (txtSearchPayroll.Text == "")
            {
                getPayroll();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_searchPayroll @value='" + txtSearchPayroll.Text.ToString() + "'";
                    DataTable dataTable = new DataTable();
                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
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

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPayrolliD.Text = ordersGridView.CurrentRow.Cells[0].Value.ToString();
            cmbPayrollEmp.Text = ordersGridView.CurrentRow.Cells[1].Value.ToString();
            payroll_date.Text = ordersGridView.CurrentRow.Cells[2].Value.ToString();
            txtPayrollType.Text = ordersGridView.CurrentRow.Cells[3].Value.ToString();
            txtUnpaidOrders.Text = ordersGridView.CurrentRow.Cells[4].Value.ToString();
            txtEmpSalary.Text = ordersGridView.CurrentRow.Cells[5].Value.ToString();
            txtTotalPayroll.Text = ordersGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void resetForm()
        {
            txtPayrolliD.Clear();
            cmbPayrollEmp.Text = "";
            txtPayrollType.Clear();
            txtTotalPayroll.Clear();
            txtUnpaidOrders.Clear();
            payroll_date.Text = "";

            cmbPayrollEmp.Focus();
        }
        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            if (txtPayrolliD.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_deletePayroll @id = '" + txtPayrolliD.Text + "'";
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    resetForm();
                    command.Dispose();
                    conn.Close();
                    // refresh orders 
                    getPayroll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGeneralReport_Click(object sender, EventArgs e)
        {
            frmGeneralPayrollRpt rpt = new frmGeneralPayrollRpt();
            rpt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchPayrollByID search = new frmSearchPayrollByID();
            search.ShowDialog();
        }

        private void category_meni_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCategory().ShowDialog();
            this.Close();
        }
    }
}
