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
            getEmployees();
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
    }
}
