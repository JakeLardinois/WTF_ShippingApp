using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WTF_ShippingApp
{
    public partial class frmBillOfLadingReport : Form
    {
        public frmBillOfLadingReport()
        {
            InitializeComponent();
        }

        private void frmBillOfLadingReport_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
        }
    }
}
