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
    public partial class frmForgotPassword : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlDataReader reader;
        SqlCommand command;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                return;
            } else
            {
              try
                {
                    string query = "SELECT password FROM Users WHERE username = '" + txtUsername.Text + "'";
                    conn.Open();
                    command = new SqlCommand(query, conn);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtPassword.Text = reader[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                    conn.Close();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }
    }
}
