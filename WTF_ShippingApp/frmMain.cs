using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Deployment.Application;


namespace WTF_ShippingApp
{
    /*I kept getting an exception thrown on the client (not on my development machine) of 
     * "this operation cannot be performed while an autofill column is being resized" the solution was to set the DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
     * property on the Load() event of the form instead of setting the property on the designer.  This is a flaw of the Datagrid... */
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MenuItem5_Click(object sender, EventArgs e)
        {
            frmShipping objFrmShipping = new frmShipping();
            LoadForm(objFrmShipping);
        }

        private void MenuItem8_Click(object sender, EventArgs e)
        {
            frmShipMultiple objShipMultipleForm = new frmShipMultiple();
            LoadForm(objShipMultipleForm);
        }

        private void MenuItem10_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            frmSettings objSettingsForm = new frmSettings();
            LoadForm(objSettingsForm);
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            frmCustomerLabels objCustomerLabelForm = new frmCustomerLabels();
            LoadForm(objCustomerLabelForm);
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            frmShipCarriers objShipCarriersForm = new frmShipCarriers();
            LoadForm(objShipCarriersForm);
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            frmShipClassifications objShipClassificationForm = new frmShipClassifications();
            LoadForm(objShipClassificationForm);
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            Version objVersion;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                objVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                MessageBox.Show(string.Format("ClickOnce published Version: v{0}.{1}.{2}.{3}", objVersion.Major, objVersion.Minor, objVersion.Build, objVersion.Revision),
                "Version", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            frmQuickLabelPrinter objQuickLabelPrinterForm = new frmQuickLabelPrinter();
            LoadForm(objQuickLabelPrinterForm);
        }

        private void menuItem10_Click_1(object sender, EventArgs e)
        {
            frmPurchaseRequirements objfrmPurchaseRequirements = new frmPurchaseRequirements();
            LoadForm(objfrmPurchaseRequirements);
        }

        private void LoadForm(Form objForm)
        {
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            frmTimePhasedInventory objfrmTimePhasedInventory = new frmTimePhasedInventory();
            LoadForm(objfrmTimePhasedInventory);
        }
    }
}
