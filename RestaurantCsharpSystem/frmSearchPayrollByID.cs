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
    public partial class frmSearchPayrollByID : Form
    {
        SqlConnection conn = DBConnection.conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        public frmSearchPayrollByID()
        {
            InitializeComponent();
        }

        private void btnGeneralRpt_Click(object sender, EventArgs e)
        {
            if (txtPayrollID.Text == "")
            {
                return;
            }
            else
            {
                string query = "EXEC sp_getPayrollByID '" + txtPayrollID.Text + "'";
                conn.Open();
                command = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                adapter.Fill(dataTable);
                rptSinglePayrollByID rpt = new rptSinglePayrollByID();
                rpt.SetDataSource(dataTable);

                frmSinglePayrollRpt report = new frmSinglePayrollRpt();
                report.crystalReportViewer1.ReportSource = rpt;
                report.ShowDialog();
                conn.Close();
            }
        }
    }
}
