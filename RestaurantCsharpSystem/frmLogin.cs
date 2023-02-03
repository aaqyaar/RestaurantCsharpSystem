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
    public partial class frmLogin : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlCommand command;
        SqlDataReader reader;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            } else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = txtUsername.Text;
            string _password = txtPassword.Text;
            
            if (_username == "" || _password == "")
            {
                MessageBox.Show("Username or Password field is missed", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                HandleSubmit(_username, _password);
            }
        }
        private void HandleSubmit(string username, string password)
        {
            conn.Open();
            try
            {
                string query = "EXEC sp_login @user = '"+ username + "', @pass = '"+ password + "'";
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                  
                    
                    this.Hide();
                    frmDashboard dash = new frmDashboard();
                    dash.lblAuthedUser.Text = reader[0].ToString();
                    conn.Close();
                    dash.ShowDialog();
                    this.Close();
                } else
                {
                    MessageBox.Show("Username or Password is in correct", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmForgotPassword().ShowDialog();
            this.Close();
        }
    }
}
