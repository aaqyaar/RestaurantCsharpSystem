using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using RestaurantCsharpSystem.Database;

namespace RestaurantCsharpSystem
{
    public partial class frmAddUser : Form
    {
        SqlConnection conn = DBConnection.conn;
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUsers().ShowDialog();
            this.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string _name = txtName.Text;
            string _username = txtUsername.Text;
            string _password = txtPassword.Text;
            string _confirmPassword = txtConfirmPassword.Text;
            string _phone = txtPhone.Text;
            string _role = comboRole.Text;

            if (_name == "" || _username == "" || _password == ""|| _confirmPassword == "" || _phone == "" || _role == "")
            {
                MessageBox.Show("All fields are required", "General Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                HandleSubmit(_name, _username, _password, _phone, _role);
            }
        }

        private void HandleSubmit(string name, string username, string password, string phone, string role)
        {
            SqlCommand command;
            SqlDataAdapter adapter;
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
                MessageBox.Show("User is successfuly created", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
                command.Dispose();
                conn.Close();

                this.Hide();
                new frmUsers().ShowDialog();
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
