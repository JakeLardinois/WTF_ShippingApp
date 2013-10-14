using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;


namespace WTF_ShippingApp
{
    public partial class frmSelectOrderLine : Form
    {
        private Item mobjItem { get; set; }
        public OrderLine SelectedOrderLine { get; set; }
        public FormStatus FormStatus { get; set; }


        public frmSelectOrderLine(Item objItem)
        {
            InitializeComponent();

            //lblJob.Text = strJobNumber;
            mobjItem = objItem;
        }

        private void frmSelectOrderRelease_Load(object sender, EventArgs e)
        {
            dgvOrderReleases.Visible = false;
            dgvOrderReleases.AutoGenerateColumns = false;
            AddOrderReleaseColumn();
            dgvOrderReleases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblItem.Text = mobjItem.ItemID;
            lblJob.Text = mobjItem.SelectedJob.JobNumber;
            //lblOrder.Text = string.IsNullOrEmpty(mobjItem.SelectedJob.JobOrderNumber) ? mobjItem.SelectedOrder.CustomerOrderNumber.Trim() : mobjItem.SelectedJob.JobOrderNumber;
            lblOrder.Text = mobjItem.SelectedOrder == null ? mobjItem.SelectedJob.JobOrderNumber : mobjItem.SelectedOrder.CustomerOrderNumber.Trim();
            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            SetDGVDataSource();
            if (dgvOrderReleases.RowCount > 0)
            {
                dgvOrderReleases.Visible = true;
                btnOK.Enabled = true;
                btnCancel.Enabled = true;
                lblLoading.Visible = false;
            }
            else
            {
                if (mobjItem.SelectedOrder.IsBlanketOrder)
                    MessageBox.Show("No Releases found.", "Order Release Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("No Lines found.", "Order Line Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                FormStatus = WTFClassLibrary.FormStatus.Cancelled;
                this.Dispose();

            }
        }

        private void AddOrderReleaseColumn()
        {
            if (mobjItem.SelectedOrder.IsBlanketOrder)
            {
                DataGridViewTextBoxColumn objOrderReleaseColumn = new DataGridViewTextBoxColumn { HeaderText = "Release", Name = "txtOrderRelease", DataPropertyName = "CustomerOrderRelease" };
                dgvOrderReleases.Columns.Insert(2, objOrderReleaseColumn);
                this.Text = "Select Order Release";
                chkFilterLines.Text = "Filter Latest Release";
            }
        }

        private void SetDGVDataSource()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (chkFilterLines.Checked)
                {
                    dgvOrderReleases.DataSource = mobjItem.OrderLines
                        .OrderByDescending(l => l.CustomerOrderLine)
                        .OrderByDescending(l => l.CustomerOrderRelease)
                        .Take(1).ToList();
                }
                else
                    dgvOrderReleases.DataSource = mobjItem.OrderLines;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                FormStatus = WTFClassLibrary.FormStatus.Errored;
                this.Dispose();
            }

            dgvOrderReleases.Refresh();
            Cursor.Current = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedOrderLine = null;
            FormStatus = WTFClassLibrary.FormStatus.Cancelled;
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedOrderLine = dgvOrderReleases.CurrentRow.DataBoundItem as OrderLine;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }

        private void dgvOrderReleases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedOrderLine = dgvOrderReleases.CurrentRow.DataBoundItem as OrderLine;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }

        private void chkFilterLines_CheckedChanged(object sender, EventArgs e)
        {
            SetDGVDataSource();
        }
    }
}
