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
    public partial class frmGeneralOrdersRpt : Form
    {
        public frmGeneralOrdersRpt()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptGeneralOrders rpt = new rptGeneralOrders();
            rpt.Refresh();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
