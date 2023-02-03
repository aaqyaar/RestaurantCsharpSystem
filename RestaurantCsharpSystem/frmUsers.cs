using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestaurantCsharpSystem.Database;


namespace RestaurantCsharpSystem
{
    public partial class frmUsers : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlDataAdapter adapter;
        SqlCommand command;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void dashboard_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDashboard().ShowDialog();
            //this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
      //      new frmAddUser().ShowDialog();
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

       

        private void frmUsers_Load(object sender, EventArgs e)
        {
            getUsers();

        }
        private void getUsers() {
            string query = "SELECT * FROM Users";
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
                usersDataGridView.DataSource = null;
                conn.Close();

                usersDataGridView.DataSource = dataTable;
                usersDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                usersDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                usersDataGridView.Columns[2].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                usersDataGridView.Columns[3].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                usersDataGridView.Columns[4].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);
                usersDataGridView.Columns[5].HeaderCell.Style.Font = new Font("Inter", 14, FontStyle.Regular);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string _name = txtName.Text;
            string _username = txtUsername.Text;
            string _password = txtPassword.Text;
            string _confirmPassword = txtConfirmPassword.Text;
            string _phone = txtPhone.Text;
            string _role = cmbUserRole.Text;

            if (_name == "" || _username == "" || _password == "" || _confirmPassword == "" || _phone == "" || _role == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleSubmit(_name, _username, _password, _phone, _role);
            }
        }

        private void HandleSubmit(string name, string username, string password, string phone, string role)
        {
          
            try
            {
                conn.Open();
                string query = "INSERT INTO Users VALUES(@name, @username, @password, @phone, @role)";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@role", role.ToLower());

                command.ExecuteNonQuery();
                MessageBox.Show("User is successfuly created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.Dispose();
                conn.Close();

                // refresh users
                getUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HandleUpdate(string id, string name, string username, string password, string phone, string role)
        {

            try
            {
                conn.Open();
                string query = "EXEC sp_updateUser @id = @userId, @name = @fullName, @user = @username, @pass = @password, @phone = @phone, @role = @role";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", id);
                command.Parameters.AddWithValue("@fullName", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@role", role.ToLower());

                command.ExecuteNonQuery();
                MessageBox.Show("User is successfuly created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
                command.Dispose();
                conn.Close();

                // refresh users
                getUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string _id = txtUserId.Text;
            string _name = txtName.Text;
            string _username = txtUsername.Text;
            string _password = txtPassword.Text;
            string _confirmPassword = txtConfirmPassword.Text;
            string _phone = txtPhone.Text;
            string _role = cmbUserRole.Text;

            if (_id == "" || _name == "" || _username == "" || _password == "" || _confirmPassword == "" || _phone == "" || _role == "")
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HandleUpdate(_id, _name, _username, _password, _phone, _role);
            }
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserId.Text = usersDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = usersDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text = usersDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = usersDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = usersDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtConfirmPassword.Text = usersDataGridView.CurrentRow.Cells[3].Value.ToString();
            cmbUserRole.Text = usersDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_deleteUser @id = '" + txtUserId.Text + "'";
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    resetForm();
                    command.Dispose();
                    conn.Close();
                    // refresh products 
                    getUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void resetForm()
        {
            txtUserId.Clear();

            txtUsername.Clear();
            txtPhone.Clear();
            txtSearchUser.Clear();
            txtPassword.Clear();
            txtName.Clear();
           
            txtName.Focus();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text == "")
            {
                getUsers();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "EXEC sp_searchUser @value='" + txtSearchUser.Text.ToString() + "'";
                    DataTable dataTable = new DataTable();
                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    usersDataGridView.DataSource = dataTable;
                    usersDataGridView.Refresh();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGeneralRpt_Click(object sender, EventArgs e)
        {
            frmGeneralUsersReport report = new frmGeneralUsersReport();
            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchUserByID frmUserId = new frmSearchUserByID();
            frmUserId.ShowDialog();
        }
    }
}
