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
    public partial class frmShipItem : Form
    {
        private Item mobjItem { get; set; }
        public BillOfLading mobjBOL { get; set; }
        public FormStatus FormStatus { get; set; }
        private StringBuilder mstrbldrErrors = new StringBuilder();


        public frmShipItem(Item objItem)
        {
            InitializeComponent();

            mobjItem = objItem;
            mobjBOL = new BillOfLading();
        }

        private void PopulateBOL()
        {
            //Zero out BOL Values
            mobjBOL.GrossWeight = 0;
            mobjBOL.Quantity = 0;
            mobjBOL.PalletCount = 0;

            //Repopulate them
            if (mobjItem.IsPulledFromInventory)
                foreach (ItemHistoryTransaction objTransaction in mobjItem.SelectedHistoryTransactions)
                {
                    mobjBOL.GrossWeight += objTransaction.GrossWeight; //dblTotalWeight += objTransaction.GrossWeight;
                    mobjBOL.Quantity += objTransaction.Quantity;
                    mobjBOL.PalletCount += objTransaction.PalletCount;
                }
            
        }

        private void frmShipItem_Load(object sender, EventArgs e)
        {
            lblItem.Text = mobjItem.ItemID;
            lblItemDesc.Text = mobjItem.Description;
            lblJob.Text = mobjItem.SelectedJob.JobNumber;
            lblOrder.Text = mobjItem.SelectedOrder.CustomerOrderNumber;
            SetOperationValues();

            if (mobjItem.IsPulledFromInventory)
            {
                lblQtyAvail.Text = "Available";
                lblQtyAvailRel.Text = mobjItem.SelectedItemHistoryJob.TotalQuantity.ToString();
                PopulateBOL();

                txtQuantity.Text = mobjBOL.Quantity.ToString();
                txtTotalWgt.Text = mobjBOL.GrossWeight.ToString();
                txtQuantity.ReadOnly = true;
                txtTotalWgt.ReadOnly = true;
            }
            else
            {
                lblQtyAvail.Text = "Released";
                lblQtyAvailRel.Text = mobjItem.SelectedJob.QtyReleased.ToString();
                //txtQuantity.Text =
                //txtTotalWgt.Text =
            }
            lblQtyAvail.Text = mobjItem.IsPulledFromInventory ? "Available" : "Released";
            lblQtyAvailRel.Text = mobjItem.IsPulledFromInventory ? mobjItem.SelectedItemHistoryJob.TotalQuantity.ToString() : mobjItem.SelectedJob.QtyReleased.ToString();

            //txtQuantity.Text =
            //txtTotalWgt.Text = 

            //cboLocation.DataSource = JobTransaction.StockLocations;//removed this implementation to accomodate appropriate locations for a given item.
            //cboLocation.SelectedIndex = cboLocation.FindStringExact("STOCK");
            cboLocation.DataSource = mobjItem.ItemStockroomLocations;
            cboLocation.SelectedIndex = 0; //order is determined in sql

            if (mobjItem.SelectedOrder.IsBlanketOrder)
            {
                lblLineReleaseLbl.Text = "Release";
                lblLineRelease.Text = mobjItem.SelectedOrderLine.CustomerOrderRelease.ToString();
            }
            else
            {
                lblLineReleaseLbl.Text = "Line";
                lblLineRelease.Text = mobjItem.SelectedOrderLine.CustomerOrderLine.ToString();
            }

        }

        private void SetOperationValues()
        {
            lblOperation.Text = mobjItem.SelectedJob.SelectedOperation.OperationNumber;
            lblCompleted.Text = mobjItem.SelectedJob.SelectedOperation.QtyComplete.ToString();
            lblMoved.Text = mobjItem.SelectedJob.SelectedOperation.QtyComplete.ToString();
            lblScrapped.Text = mobjItem.SelectedJob.SelectedOperation.QtyScrapped.ToString();
            lblWorkCode.Text = mobjItem.SelectedJob.SelectedOperation.WorkCenter;
            if (mobjItem.SelectedJob.SelectedOperation.OperationNumber.Equals(mobjItem.SelectedJob.LastOperation.OperationNumber))
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            JobTransaction objJobTransaction;


            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            objJobTransaction = new JobTransaction();
            try
            {
                objJobTransaction.CompleteOperation = chkCompleteOperation.Checked;
                objJobTransaction.CloseJob = chkCloseJob.Checked;
                objJobTransaction.JobNumber = mobjItem.SelectedJob.FormattedJobNumber;//mobjItem.SelectedJob.JobNumber;//To accomodate job field length difference between SL4 & SL8
                objJobTransaction.Location = cboLocation.SelectedItem as StockLocation;
                objJobTransaction.Operation = mobjItem.SelectedJob.SelectedOperation;
                objJobTransaction.Warehouse = "MAIN";
                objJobTransaction.UserCode = "SHA";
                objJobTransaction.TransactionClass = 'J';
                objJobTransaction.TransactionType = 'M';
                objJobTransaction.Suffix = mobjItem.SelectedJob.Suffix;
                objJobTransaction.QtyMoved = double.Parse(txtQuantity.Text);
                objJobTransaction.QtyComplete = double.Parse(txtQuantity.Text);
                objJobTransaction.NextOperation = mobjItem.SelectedJob.SelectedOperation.NextOperation;

                objJobTransaction.Insert();

                if (mobjItem.IsPulledFromInventory)
                    foreach (ItemHistoryTransaction objTransaction in mobjItem.SelectedHistoryTransactions)
                        Item.ShipItemFromInventory(objTransaction);
            }
            catch(Exception objEx)
            {
                MessageBox.Show(objEx.Message);
                FormStatus = WTFClassLibrary.FormStatus.Errored;
                this.Dispose();
                return;
            }
            FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormStatus = WTFClassLibrary.FormStatus.Cancelled;
            this.Dispose();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            frmSelectOperation objSelectOperationForm;


            objSelectOperationForm = new frmSelectOperation(mobjItem.SelectedJob);
            objSelectOperationForm.ShowDialog();
            if (objSelectOperationForm.FormStatus == FormStatus.Succeeded)
            {
                mobjItem.SelectedJob.SelectedOperation = objSelectOperationForm.SelectedOperation;
                SetOperationValues();
            }
        }

        private void btnPrintBOL_Click(object sender, EventArgs e)
        {
            frmBOL objBOLForm;


            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            PopulateBOL();//zero out values and get the palletcount
            mobjBOL.GrossWeight = double.Parse(txtTotalWgt.Text);//reset the values to the textbox-note values have been validated
            mobjBOL.Quantity = int.Parse(txtQuantity.Text);
             

            objBOLForm = new frmBOL(mobjItem.SelectedOrder, mobjBOL);
            objBOLForm.ShowDialog();
        }

        private void Validate(object sender, CancelEventArgs e)
        {
            double dblTemp;
            TextBox objTextBox;


            if (sender is TextBox)
            {
                objTextBox = (TextBox)sender;


                if (objTextBox.Text.Length == 0 || !double.TryParse(objTextBox.Text, out dblTemp) || dblTemp == 0)
                    switch (objTextBox.Name)
                    {
                        case "txtQuantity":
                            mstrbldrErrors.Append("Invalid Quantity");
                            lblQuantityError.Text = "X";
                            break;
                        case "txtTotalWgt":
                            mstrbldrErrors.Append("Invalid Piece Weight");
                            lblTotalWeightError.Text = "X";
                            break;
                    }
                else
                    switch (objTextBox.Name)
                    {
                        case "txtQuantity":
                            lblQuantityError.Text = string.Empty;
                            break;
                        case "txtTotalWgt":
                            lblTotalWeightError.Text = string.Empty;
                            break;
                    }
            }
        }

        private void btnPackingSlip_Click(object sender, EventArgs e)
        {
            frmPackingSlip objPackingSlipForm;

            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            PopulateBOL();//zero out values and get the palletcount
            mobjBOL.GrossWeight = double.Parse(txtTotalWgt.Text);//reset the values to the textbox-note values have been validated
            mobjBOL.Quantity = int.Parse(txtQuantity.Text);

            objPackingSlipForm = new frmPackingSlip(mobjItem.SelectedOrder, mobjBOL, mobjItem.SelectedJob.JobNumber);
            objPackingSlipForm.ShowDialog();
        }

        private void btnSelectInventory_Click(object sender, EventArgs e)
        {
            frmItemHistory objSelectItemHistoryForm;


            if (mobjItem.IsPulledFromInventory)
            {
                objSelectItemHistoryForm = new frmItemHistory(mobjItem, true);
                objSelectItemHistoryForm.ShowDialog();
                if (objSelectItemHistoryForm.FormStatus == FormStatus.Succeeded)
                {
                    mobjItem.SelectedHistoryTransactions = objSelectItemHistoryForm.SelectedItemHistoryJobs;

                    lblQtyAvailRel.Text = mobjItem.SelectedItemHistoryJob.TotalQuantity.ToString();

                    PopulateBOL();
                    txtQuantity.Text = mobjBOL.Quantity.ToString();
                    txtTotalWgt.Text = mobjBOL.GrossWeight.ToString();
                }
            }
        }
    }
}
