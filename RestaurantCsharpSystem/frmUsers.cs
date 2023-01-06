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


namespace RestaurantCsharpSystem
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void dashboard_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDashboard().ShowDialog();
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAddUser().ShowDialog();
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
            string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Restaurant_DB; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            string query = "SELECT * FROM Users";
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = null;
                conn.Close();
                dataGridView1.DataSource = dataTable;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
