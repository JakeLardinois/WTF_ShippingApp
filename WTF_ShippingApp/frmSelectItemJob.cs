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

    public partial class frmSelectItemJob : Form
    {
        private Item mobjItem { get; set; }
        public Job SelectedJob { get; set; }
        public FormStatus FormStatus { get; set; }


        public frmSelectItemJob(Item objItem )
        {
            InitializeComponent();

            mobjItem = objItem;
        }

        private void frmSelectItemJob_Load(object sender, EventArgs e)
        {
            dgvJobs.Visible = false;
            dgvJobs.AutoGenerateColumns = false;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblItem.Text = mobjItem.ItemID;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            SetDataSource();
            if (FormStatus == WTFClassLibrary.FormStatus.Errored)
                this.Dispose();

            if (dgvJobs.RowCount > 0)
            {
                dgvJobs.Visible = true;
                btnOK.Enabled = true;
                btnCancel.Enabled = true;
                lblLoading.Visible = false;
            }
            else
            {

                MessageBox.Show("No jobs found.", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                FormStatus = WTFClassLibrary.FormStatus.Cancelled;
                this.Dispose();
            }
        }

        private void SetDataSource()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                dgvJobs.DataSource = mobjItem.Jobs;
            }
            catch { }

            dgvJobs.Refresh();
            Cursor.Current = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormStatus = WTFClassLibrary.FormStatus.Cancelled;
            this.Dispose();
        }

        private void dgvJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedJob = dgvJobs.CurrentRow.DataBoundItem as Job;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedJob = dgvJobs.CurrentRow.DataBoundItem as Job;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }
    }
}
