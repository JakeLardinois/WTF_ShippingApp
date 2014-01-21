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
    public partial class frmSelectOperation : Form
    {
        private Job mobjJob { get; set; }
        public Operation SelectedOperation { get; set; }
        public FormStatus FormStatus { get; set; }


        public frmSelectOperation(Job objJob)
        {
            InitializeComponent();

            mobjJob = objJob;
        }

        private void frmSelectOperation_Load(object sender, EventArgs e)
        {
            dgvOperations.Visible = false;
            dgvOperations.AutoGenerateColumns = false;
            dgvOperations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblJob.Text = mobjJob.JobNumber;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            SetDataSource();
            if (FormStatus == WTFClassLibrary.FormStatus.Errored)
                this.Dispose();

            if (dgvOperations.RowCount > 0)
            {
                dgvOperations.Visible = true;
                btnOK.Enabled = true;
                btnCancel.Enabled = true;
                lblLoading.Visible = false;
            }
            else
            {
                MessageBox.Show("No Open Operations found found for Job " + mobjJob.JobNumber + "...",
                    "Job", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                FormStatus = WTFClassLibrary.FormStatus.Cancelled;
                this.Dispose();
            }
        }

        private void SetDataSource()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                /*MODIFIED 1/20/2014 As part of the last operation removal project, I removed the functionality where an open operation was required in order to proceed past this point by having the application
                 pull in the list of operations regardless of wether or not they were open.*/
                //dgvOperations.DataSource = mobjJob.OpenOperations;
                dgvOperations.DataSource = mobjJob.Operations;
            }
            catch { }

            dgvOperations.Refresh();
            Cursor.Current = Cursors.Default;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedOperation = dgvOperations.CurrentRow.DataBoundItem as Operation;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormStatus = WTFClassLibrary.FormStatus.Cancelled;
            this.Dispose();
        }

        private void dgvOperations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedOperation = dgvOperations.CurrentRow.DataBoundItem as Operation;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }
    }
}
