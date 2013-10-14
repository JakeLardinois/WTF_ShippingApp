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
    public partial class frmSelectOrder : Form
    {
        private Item mobjItem { get; set; }
        public Order SelectedOrder { get; set; }
        public FormStatus FormStatus { get; set; }

        /*Currently this form needs a selected job in objItem in order to look up an order.*/
        public frmSelectOrder(Item objItem)
        {
            InitializeComponent();

            mobjItem = objItem;
            mobjItem.SearchFilledOrders = false;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedOrder = dgvOrders.CurrentRow.DataBoundItem as Order;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }

        private void SetDGVDataSource()
        {
            SortableSearchableBindingList<Order> objTempOrderList;


            if (string.IsNullOrEmpty(mobjItem.SelectedJob.JobOrderNumber))
                if (string.IsNullOrEmpty(mobjItem.SelectedJob.CustomerOrderNumber))
                    mobjItem.SelectedJob.JobOrderNumber = string.Empty;
                else
                    mobjItem.SelectedJob.JobOrderNumber = mobjItem.SelectedJob.CustomerOrderNumber;


            //string strOrder = string.IsNullOrEmpty(mobjItem.SelectedJob.JobOrderNumber) ? string.Empty : mobjItem.SelectedJob.CustomerOrderNumber.Trim();//if there is no order on the job then get the order from the customerordernumber field.

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                objTempOrderList = mobjItem.Orders;

                if (chkFilterOrdersByJobOrder.Checked)
                {    //first check if the filtered values return anything...
                    if (objTempOrderList.Where(O => O.CustomerOrderNumber.Trim().Equals(mobjItem.SelectedJob.JobOrderNumber.Trim())).ToList().Count == 0)
                    {
                        //chkFilterOrdersByJobOrder.Checked = false;//I had a bit of a recursion problem when I was setting the checkbox, because it would fire the checkboxchanged event which also called the setdgvdatasource function.
                        chkFilterOrdersByJobOrder.Enabled = false;  //So I just disable the checkbox when filtering doesn't work
                        dgvOrders.DataSource = objTempOrderList;
                    }
                    else
                    {
                        chkFilterOrdersByJobOrder.Enabled = true;
                        //If yes, then return the filtered list.
                        dgvOrders.DataSource = objTempOrderList
                            .Where(O => O.CustomerOrderNumber.Trim().Equals(mobjItem.SelectedJob.JobOrderNumber.Trim()))
                            .ToList();
                    }
                }
                else
                    dgvOrders.DataSource = objTempOrderList;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                FormStatus = WTFClassLibrary.FormStatus.Errored;
                this.Dispose();
            }

            dgvOrders.Refresh();
            Cursor.Current = Cursors.Default;
        }

        private void frmSelectOrder_Load(object sender, EventArgs e)
        {
            dgvOrders.Visible = false;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblItem.Text = mobjItem.ItemID;
            lblJob.Text = mobjItem.SelectedJob.JobNumber;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            SetDGVDataSource();

            if (dgvOrders.RowCount > 0)
            {
                dgvOrders.Visible = true;
                btnOK.Enabled = true;
                btnCancel.Enabled = true;
                lblLoading.Visible = false;
            }
            else
            {
                if (MessageBox.Show("No open orders found.\r\n\r\nSearch for filled orders?", "Order Select", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //chkFilterOrdersByJobOrder.Checked = true;//This get's unckecked by the first iteration which looks for unfilled orders, so it needs to be checked to attempt to apply the filter again.
                    mobjItem.SearchFilledOrders = true;
                    SetDGVDataSource();

                    if (dgvOrders.RowCount > 0)
                    {
                        dgvOrders.Visible = true;
                        btnOK.Enabled = true;
                        btnCancel.Enabled = true;
                        lblLoading.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No open or filled orders found.", "Order Select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        FormStatus = WTFClassLibrary.FormStatus.Cancelled;
                        this.Dispose();
                    }
                }
                else
                {
                    SelectedOrder = null;
                    FormStatus = WTFClassLibrary.FormStatus.Cancelled;
                    this.Dispose();
                }
                    
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedOrder = dgvOrders.CurrentRow.DataBoundItem as Order;
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedOrder = null;
            FormStatus = WTFClassLibrary.FormStatus.Cancelled;
            this.Dispose();
        }

        private void chkFilterOrdersByJobOrder_CheckedChanged(object sender, EventArgs e)
        {
            SetDGVDataSource();
        }
    }
}
