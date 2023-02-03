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
    public partial class frmDashboard : Form
    {
      static  SqlConnection conn = DBConnection.conn;
       static SqlCommand command;
       static SqlDataReader reader;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             getTotalProducts();
             getTotalOrders();
            getTotalPaidOrders();
            getTotalUnpaidOrders();
            getTotalCancelledOrders();
             getTotalEmployees();
        }

        public void getTotalProducts()
        {
          
            try
            {
                string query = "EXEC sp_total_products";
                command = new SqlCommand(query, conn);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    total_products_in_store.Text = reader[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
       
    }
        public void getTotalCancelledOrders()
        {
            try
            {
                string query = "EXEC sp_total_cancelled_orders";
                command = new SqlCommand(query, conn);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    total_cancelled_orders.Text = reader[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void getTotalUnpaidOrders()
        {
            try
            {
                string query = "EXEC sp_total_unpaid_orders";
                command = new SqlCommand(query, conn);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    total_unpaid_orders.Text = reader[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void getTotalPaidOrders()
        {
            try
            {
                string query = "EXEC sp_total_paid_orders";
                command = new SqlCommand(query, conn);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    total_paid_orders.Text = reader[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  void getTotalOrders()
        {
            try
            {
                string query = "EXEC sp_total_orders";
                command = new SqlCommand(query, conn);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    total_orders.Text = reader[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getTotalEmployees()
        {
            try
            {
                string query = "EXEC sp_total_employees";
                command = new SqlCommand(query, conn);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    total_employees.Text = reader[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void user_menu_Click(object sender, EventArgs e)
        {
              this.Hide();
            new frmUsers().ShowDialog();
         //   this.Close();
        }

        private void products_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProducts().ShowDialog();
           // this.Close();
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

        private void category_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCategory().ShowDialog();
            this.Close();
        }

        private void total_products_in_store_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
