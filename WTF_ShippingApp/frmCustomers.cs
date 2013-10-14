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
    public partial class frmCustomers : Form
    {
        public CustomerAddress SelectedCustomerAddress { get; set; }
        private const int MINTMAXRECORDCOUNT = 100;


        public frmCustomers(string strCustomerNumber)
        {
            InitializeComponent();

            txtCustomer.Text = strCustomerNumber.Trim();
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Customer Number", Value = "cust_num" });
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Customer Name", Value = "Name" });
            cboSortSearch.SelectedIndex = 0;

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetCustomers();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CustomerAddress objCustomerAddress;


            if (dgvCustomers.SelectedRows.Count == 0)
                MessageBox.Show("No Customer selected!", "Job", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                objCustomerAddress = dgvCustomers.CurrentRow.DataBoundItem as CustomerAddress;
                SelectedCustomerAddress = objCustomerAddress;
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GetCustomers()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvCustomers.Visible = false;

            SortableSearchableBindingList<CustomerAddress> objCustomerAddressList = CustomerAddress.Search(txtCustomer.Text.Trim(), 
                MINTMAXRECORDCOUNT, ((ComboBoxItem)cboSortSearch.SelectedItem).Value);

            if (objCustomerAddressList.Count == 0)
                MessageBox.Show(((ComboBoxItem)cboSortSearch.SelectedItem).Text + " " + txtCustomer.Text + " not found!", "No Customer Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            Cursor.Current = Cursors.Default;
            dgvCustomers.Visible = true;
            dgvCustomers.DataSource = objCustomerAddressList;
            dgvCustomers.Refresh();
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    GetCustomers();
                    break;
            }
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerAddress objCustomerAddress = dgvCustomers.CurrentRow.DataBoundItem as CustomerAddress;

            SelectedCustomerAddress = objCustomerAddress;
            this.Dispose();
        }
    }
}
