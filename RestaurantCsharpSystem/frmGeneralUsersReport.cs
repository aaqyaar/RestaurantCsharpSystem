using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantCsharpSystem
{
    public partial class frmGeneralUsersReport : Form
    {
        public frmGeneralUsersReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptGeneralUsers rpt = new rptGeneralUsers();
            rpt.Refresh();
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
