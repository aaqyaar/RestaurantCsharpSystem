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
    public partial class frmEmployees : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        public frmEmployees()
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

        private void payroll_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPayroll().ShowDialog();
            this.Close();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            txtEmpID.Enabled = false;
            getEmployees();
        }
        private void getEmployees() {
            try
            {
                conn.Open();
                string query = "EXEC sp_listEmployees";
                DataTable dataTable = new DataTable();
                command = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(command);
                commandBuilder = new SqlCommandBuilder(adapter);
                dataTable.Clear();
                adapter.Fill(dataTable);
                employeesGridView.DataSource = dataTable;
                employeesGridView.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {

            string _name = txtEmpName.Text;
            string _phone = txtEmpPhone.Text;
            string _address = txtEmpAddress.Text;
            string _salary = txtEmpSalary.Text;

            if (_name == "" || _phone == "" || _address == "" || _salary == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleSubmit(_name, _phone, _address, _salary);
            }
        }
        
        
        private void HandleSubmit(
            string name, string phone, string address, string salary
            )
        {
            conn.Open();
            try
            {
               
                string query = "EXEC sp_createEmployee @name = @EmpName, @phone = @EmpPhone, @address = @EmpAddress, @salary = @EmpSalary";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@EmpName", name);
                command.Parameters.AddWithValue("@EmpPhone", phone);
                command.Parameters.AddWithValue("@EmpAddress", address);
                command.Parameters.AddWithValue("@EmpSalary", salary);

                command.ExecuteNonQuery();
                resetForm();

                command.Dispose();
                conn.Close();
                // refresh products 
                getEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void resetForm()
        {
            txtEmpName.Clear();
            txtEmpPhone.Clear();
            txtEmpSalary.Clear();
            txtEmpID.Clear();
            txtEmpAddress.Clear();
            txtSearchEmp.Clear();

            txtEmpName.Focus();
        }

        private void employeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpID.Text = employeesGridView.CurrentRow.Cells[0].Value.ToString();
            txtEmpName.Text = employeesGridView.CurrentRow.Cells[1].Value.ToString();
            txtEmpPhone.Text = employeesGridView.CurrentRow.Cells[2].Value.ToString();
            txtEmpAddress.Text = employeesGridView.CurrentRow.Cells[3].Value.ToString();
            txtEmpSalary.Text = employeesGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_deleteEmployee @id = '" + txtEmpID.Text + "'";
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    resetForm();
                    command.Dispose();
                    conn.Close();
                    // refresh employees 
                    getEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            string _id = txtEmpID.Text;
            string _name = txtEmpName.Text;
            string _phone = txtEmpPhone.Text;
            string _address = txtEmpAddress.Text;
            string _salary = txtEmpSalary.Text;

            if (_id == "" || _name == "" || _phone == "" || _address == "" || _salary == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleUpdate(_id, _name, _phone, _address, _salary);
            }
        }

        private void HandleUpdate(string id,
           string name, string phone, string address, string salary
           )
        {
            conn.Open();
            try
            {

                string query = "EXEC sp_updateEmployee @id = @EmpId, @name = @EmpName, @phone = @EmpPhone, @address = @EmpAddress, @salary = @EmpSalary";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@EmpId", id);
                command.Parameters.AddWithValue("@EmpName", name);
                command.Parameters.AddWithValue("@EmpPhone", phone);
                command.Parameters.AddWithValue("@EmpAddress", address);
                command.Parameters.AddWithValue("@EmpSalary", salary);

                command.ExecuteNonQuery();
                resetForm();

                command.Dispose();
                conn.Close();
                // refresh employees
                getEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnListEmps_Click(object sender, EventArgs e)
        {
            getEmployees();
        }

        private void txtSearchEmp_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmp.Text == "")
            {
                getEmployees();
            }
            else
            {
                conn.Open();
                try
                {
                    
                    string query = "EXEC sp_searchEmployees @value='" + txtSearchEmp.Text.ToString() + "'";
                    DataTable dataTable = new DataTable();
                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    employeesGridView.DataSource = dataTable;
                    employeesGridView.Refresh();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGeneralEmployeesRpt rpt = new frmGeneralEmployeesRpt();
            rpt.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchSingleEmployee frmSingleEmp = new frmSearchSingleEmployee();
            frmSingleEmp.ShowDialog();
        }
    }
}
