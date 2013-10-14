using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;
using System.Data.SqlClient;


namespace WTF_ShippingApp
{
    public partial class frmVendors : Form
    {
        public VendorAddress SelectedVendorAddress { get; set; }
        private const int MINTMAXRECORDCOUNT = 100;


        public frmVendors(string strCustomerNumber)
        {
            InitializeComponent();

            txtVendor.Text = strCustomerNumber.Trim();
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Vendor Number", Value = "vend_num" });
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Vendor Name", Value = "Name" });
            cboSortSearch.SelectedIndex = 0;

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            GetVendors();
            dgvVendors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            VendorAddress objVendorAddress;


            if (dgvVendors.SelectedRows.Count == 0)
                MessageBox.Show("No Customer selected!", "Job", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                objVendorAddress = dgvVendors.CurrentRow.DataBoundItem as VendorAddress;
                SelectedVendorAddress = objVendorAddress;
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GetVendors()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvVendors.Visible = false;

            SortableSearchableBindingList<VendorAddress> objVendorAddressList = VendorAddress.Search(txtVendor.Text.Trim(), 
                MINTMAXRECORDCOUNT, ((ComboBoxItem)cboSortSearch.SelectedItem).Value);

            if (objVendorAddressList.Count == 0)
                MessageBox.Show(((ComboBoxItem)cboSortSearch.SelectedItem).Text + " " + txtVendor.Text + " not found!", "No Customer Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            Cursor.Current = Cursors.Default;
            dgvVendors.Visible = true;
            dgvVendors.DataSource = objVendorAddressList;
            dgvVendors.Refresh();
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    GetVendors();
                    break;
            }
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VendorAddress objVendorAddress = dgvVendors.CurrentRow.DataBoundItem as VendorAddress;

            SelectedVendorAddress = objVendorAddress;
            this.Dispose();
        }
    }
}
