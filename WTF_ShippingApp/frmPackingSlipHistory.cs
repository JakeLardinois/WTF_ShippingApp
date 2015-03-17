using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;
using System.Data.Linq;


namespace WTF_ShippingApp
{
    public partial class frmPackingSlipHistory : Form
    {
        private ExtraSytelineTableDb db { get; set; }
        private Timer mobjQueryTimer { get; set; }
        private Timer mobjFadingTimer { get; set; }
        int fade, r, g, b;
        int intStartR = 255, intStartG = 0, intStartB = 0;
        int intEndR = 255, intEndG = 255, intEndB = 255;


        public frmPackingSlipHistory()
        {
            InitializeComponent();

            db = new ExtraSytelineTableDb();

            mobjQueryTimer = new Timer();  // This timer is used to delay query until user is finished typing.
            mobjQueryTimer.Interval = 500; //1000 = 1sec
            mobjQueryTimer.Tick += new EventHandler(mobjQueryTimer_Tick);

            mobjFadingTimer = new Timer();  // This timer is used fade the messages displayed to a user.
            mobjFadingTimer.Interval = 10; //1000 = 1sec
            mobjFadingTimer.Tick += new EventHandler(mobjFadingTimer_Tick);
        }

        private void frmPackingSlipHistory_Load(object sender, EventArgs e)
        {


            dgvPackingSlips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPackingSlips.AutoGenerateColumns = false;

            //enables the multiline textbox for txtCustomerAddress
            dgvPackingSlips.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            txtCustomerAddress.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.WindowState = FormWindowState.Maximized;
            
            nudMaxRecordCount.Maximum = decimal.MaxValue;

            SetDGVDataSource();
        }

        private void SetDGVDataSource()
        {
            IEnumerable<PackingSlip> Query;
            int intRecordCount = (int)nudMaxRecordCount.Value;


            txtPrintDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            txtActualShipDate.DefaultCellStyle.Format = "dd/MM/yyyy";

            txtQtyOrdered.DefaultCellStyle.Format = "N0";
            txtQtyShipped.DefaultCellStyle.Format = "N0";
            txtQtyBackOrdered.DefaultCellStyle.Format = "N0";

            if (chkApplyFilter.Checked)
                Query = db.PackingSlips
                    .Where(d =>
                        d.PrintDate.Value.Year == dtmSearchPrintDate.Value.Year &&
                        d.PrintDate.Value.Month == dtmSearchPrintDate.Value.Month &&
                        d.PrintDate.Value.Day == dtmSearchPrintDate.Value.Day)
                    .Where(p => string.IsNullOrEmpty(txtSearchPackingSlipNo.Text) ? true : p.PackingSlipNo.ToUpper().Contains(txtSearchPackingSlipNo.Text.ToUpper()))
                    .Where(i => string.IsNullOrEmpty(txtSearchItem.Text) ? true : i.ItemID.ToUpper().Contains(txtSearchItem.Text.ToUpper()))
                    .Where(i => string.IsNullOrEmpty(txtSearchItemDescription.Text) ? true : i.ItemDescription.ToUpper().Contains(txtSearchItemDescription.Text.ToUpper()))
                    .Where(p => string.IsNullOrEmpty(txtSearchCustomerPO.Text) ? true : p.CustomerPO.ToUpper().Contains(txtSearchCustomerPO.Text.ToUpper()))
                    .Where(n => string.IsNullOrEmpty(txtSearchCustomerNo.Text) ? true : n.CustomerNumber.ToUpper().Contains(txtSearchCustomerNo.Text.ToUpper()))
                    .Where(a => string.IsNullOrEmpty(txtSearchCustomerAddress.Text) ? true : a.CustomerAddress.ToUpper().Contains(txtSearchCustomerAddress.Text.ToUpper()))
                    .Take(intRecordCount)
                    .ToList();
            else
                Query = db.PackingSlips
                    .Where(p => string.IsNullOrEmpty(txtSearchPackingSlipNo.Text) ? true : p.PackingSlipNo.ToUpper().Contains(txtSearchPackingSlipNo.Text.ToUpper()))
                    .Where(i => string.IsNullOrEmpty(txtSearchItem.Text) ? true : i.ItemID.ToUpper().Contains(txtSearchItem.Text.ToUpper()))
                    .Where(i => string.IsNullOrEmpty(txtSearchItemDescription.Text) ? true : i.ItemDescription.ToUpper().Contains(txtSearchItemDescription.Text.ToUpper()))
                    .Where(p => string.IsNullOrEmpty(txtSearchCustomerPO.Text) ? true : p.CustomerPO.ToUpper().Contains(txtSearchCustomerPO.Text.ToUpper()))
                    .Where(n => string.IsNullOrEmpty(txtSearchCustomerNo.Text) ? true : n.CustomerNumber.ToUpper().Contains(txtSearchCustomerNo.Text.ToUpper()))
                    .Where(a => string.IsNullOrEmpty(txtSearchCustomerAddress.Text) ? true : a.CustomerAddress.ToUpper().Contains(txtSearchCustomerAddress.Text.ToUpper()))
                    .Take(intRecordCount)
                    .ToList();

            dgvPackingSlips.DataSource = new SortableBindingList<PackingSlip>(Query);

            grpPackingSlipLines.Text = string.Format("Packing Slip Lines  --  {0,0:N0} Records", dgvPackingSlips.Rows.Count);
        }

        private void mobjQueryTimer_Tick(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            SetDGVDataSource();
        }

        private void mobjFadingTimer_Tick(object sender, EventArgs e)
        {
            // timer interval set to 10 to ensure smooth fading
            // declared int: r = 0, g = 215 and b = 180
            // target values are r = 32, g = 32 and b = 32 to match BackColor


            fade++;
            if (fade >= 200) // arbitrary duration set prior to initiating fade
            {
                if (r < 255) r++; // increase r value with each tick
                if (g < 255) g++; // decrease g value with each tick
                if (b < 255) b++; // decrease b value with each tick
                lblMessage.ForeColor = Color.FromArgb(255, r, g, b);
                if (r == intEndR && g == intEndG && b == intEndB) // arrived at target values
                {
                    // fade is complete - reset variables for next fade operation
                    lblMessage.ForeColor = Color.FromArgb(255, intStartR, intStartG, intStartB);
                    lblMessage.Text = "";
                    fade = 0;
                    r = intStartR;
                    g = intStartG;
                    b = intStartB;
                    mobjFadingTimer.Enabled = false;
                }
            }
        }

        private void chkApplyFilter_CheckedChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void dtmSearchPrintDate_ValueChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void txtSearchPackingSlipNo_TextChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void txtSearchCustomerPO_TextChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void txtSearchCustomerNo_TextChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void txtSearchItemDescription_TextChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void txtSearchCustomerAddress_TextChanged(object sender, EventArgs e)
        {
            mobjQueryTimer.Stop();
            mobjQueryTimer.Start();
        }

        private void MarkCurrentRowDeleted()
        {
            PackingSlip objPackingSlipLine = dgvPackingSlips.CurrentRow.DataBoundItem as PackingSlip;

            db.Entry(objPackingSlipLine).State = EntityState.Deleted;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkCurrentRowDeleted();
            dgvPackingSlips.Rows.RemoveAt(dgvPackingSlips.CurrentRow.Index);
        }

        private void dgvPackingSlips_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MarkCurrentRowDeleted();
        }

        private void dgvPackingSlips_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //I just need to have this event wired up for the scenario where I delete the last row in a gridview... Otherwise an exception gets thrown to the user.
        }

        private bool DataWasModified()
        {
            //http://blog.oneunicorn.com/2011/04/03/rejecting-changes-to-entities-in-ef-4-1/
            int intModificationCount = 0;

            intModificationCount = db.ChangeTracker.Entries()
                .Where(s => s.State == EntityState.Modified || s.State == EntityState.Added || s.State == EntityState.Deleted)
                .Count();

            return intModificationCount > 0;
        }

        private void frmPackingSlipHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DataWasModified())
                {
                    if ((MessageBox.Show("Do You want to save your changes?", "Save Changes", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        SaveChanges();
                        this.Dispose();
                    }
                    else
                        this.Dispose();
                }
                else
                    this.Dispose();
            }
            catch
            {
                mobjFadingTimer.Stop();
                MessageBox.Show("There was an error and your transactions were not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMessage.Text = "Transactions NOT Saved!";
                mobjFadingTimer.Start();
            }

            
        }

        private void SaveChanges()
        {
            try
            {
                db.SaveChanges();
                mobjFadingTimer.Stop();
                lblMessage.Text = "Transactions Saved...";
                fade = 0;
                r = intStartR;
                g = intStartG;
                b = intStartB;
                lblMessage.ForeColor = Color.FromArgb(255, r, g, b);
                mobjFadingTimer.Start();
            }
            catch(Exception objException){ throw objException;}

        }

        private void DiscardChanges()
        {
            foreach (var objPackingslip in db.PackingSlips)
                db.Entry(objPackingslip).State = EntityState.Unchanged;

            mobjFadingTimer.Stop();
            lblMessage.Text = "All Changes are discarded...";
            fade = 0;
            r = intStartR;
            g = intStartG;
            b = intStartB;
            lblMessage.ForeColor = Color.FromArgb(255, r, g, b);
            mobjFadingTimer.Start();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
            SetDGVDataSource();
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            DiscardChanges();
            SetDGVDataSource();
        }

    }
}
