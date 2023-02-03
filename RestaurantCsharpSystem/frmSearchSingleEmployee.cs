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
    public partial class frmSearchSingleEmployee : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlDataAdapter adapter;
        SqlCommand command;
        public frmSearchSingleEmployee()
        {
            InitializeComponent();
        }

        private void btnGeneralRpt_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                return;
            }
            else
            {
                string query = "EXEC sp_getEmployeeByID '" + txtUserId.Text + "'";
                conn.Open();
                command = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                adapter.Fill(dataTable);
                rptSingleUserByID rpt = new rptSingleUserByID();
                rpt.SetDataSource(dataTable);

                frmSingleEmployeeRpt report = new frmSingleEmployeeRpt();
                report.crystalReportViewer1.ReportSource = rpt;
                report.ShowDialog();
                conn.Close();
            }
        }
    }
}
