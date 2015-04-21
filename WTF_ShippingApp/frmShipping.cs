using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;

using System.Text.RegularExpressions;


namespace WTF_ShippingApp
{
    public partial class frmShipping : Form
    {
        private Item mobjItem { get; set; }
        private BillOfLading mobjBOL { get; set; }
        private StringBuilder mstrbldrErrors = new StringBuilder();


        public frmShipping()
        {
            InitializeComponent();
        }

        private void SetDefaults()
        {
            mobjItem = null;
            mobjBOL = null;

            lblItemDescription.Text = "";
            mobjItem = null;
            txtItemNumber.SelectAll();
            chkIsSubItem.Checked = false;
            txtQtyOnHand.Text = string.Empty;

            txtTareWgt.Text = "0.0";// string.Empty;
            txtGrossWgt.Text = "0.0";// string.Empty;
            txtPieceWgt.Text = "0.0";// string.Empty;
            txtQuantity.Text = "0";// string.Empty;

            btnGetJobs.Enabled = false;

            txtJob.Text = "<none selected>";
            lblOrder.Text = string.Empty;
            lblCustomer.Text = string.Empty;
            lblDueDate.Text = string.Empty;
            lblQtyReleased.Text = string.Empty;
        }

        private void SetItemValues()
        {
            txtItemNumber.Text = mobjItem.ItemID;
            lblItemDescription.Text = mobjItem.Description;
            chkIsSubItem.Checked = mobjItem.IsSubItem;
            txtPieceWgt.Text = mobjItem.PieceWgt.ToString("#,##0.0000");
            //txtQtyOnHand.Text = mobjItem.QtyOnHand.ToString("N0");
            txtQtyOnHand.Text = mobjItem.QtyOnHand.ToString("#,#;( #,# );**Zero**");
            btnGetJobs.Enabled = true;
        }

        private void SetJobValues()
        {
            mobjBOL = null;

            txtJob.Text = mobjItem.SelectedJob.JobNumber;
            
            lblDueDate.Text = mobjItem.SelectedJob.DueDate.ToString("MM/dd/yy");
            lblQtyReleased.Text = mobjItem.SelectedJob.QtyReleased.ToString("#,##0.##");
            
            //txtJob.Text = mobjItem.SelectedJob.JobNumber;
            //lblOrder.Text = mobjItem.SelectedJob.SelectedOrder.CustomerOrderNumber;

            //lblCustomer.Text = mobjItem.SelectedJob.SelectedOrder.CustomerNumber.Trim();
            //if (mobjItem.SelectedJob.SelectedOrder.CustomerName.Length > 0)
            //    lblCustomer.Text = lblCustomer.Text + " - " + mobjItem.SelectedJob.SelectedOrder.CustomerName.Trim();

            //lblDueDate.Text = mobjItem.SelectedJob.DueDate.ToString("MM/dd/yy");
            //lblQtyReleased.Text = mobjItem.SelectedJob.QtyReleased.ToString("#,##0.##");
            
        }

        private void SetOrderValues()
        {
            mobjBOL = null;

            lblOrder.Text = mobjItem.SelectedOrder.CustomerOrderNumber;
            lblCustomer.Text = mobjItem.SelectedOrder.CustomerNumber.Trim();
            if (mobjItem.SelectedOrder.CustomerName.Length > 0)
                lblCustomer.Text = lblCustomer.Text + " - " + mobjItem.SelectedOrder.CustomerName.Trim();
        }

        private void RemoveOrderValues()
        {
            mobjBOL = null;

            lblOrder.Text = string.Empty;
            lblCustomer.Text = string.Empty;
        }

        private void txtItemNumber_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtItemNumber.ReadOnly = true;
                    txtItemNumber.Refresh();

                    Cursor.Current = Cursors.WaitCursor;
                    lblItemDescription.Text = "Searching for item...";
                    lblItemDescription.Refresh();

                    try
                    {
                        SetDefaults();
                        mobjItem = new Item(txtItemNumber.Text);
                        SetItemValues();

                    }
                    catch(Exception objEx)
                    {
                        MessageBox.Show(objEx.Message);
                        SetDefaults();
                    }

                    break;
            }

            lblItemDescription.Refresh();
            Cursor.Current = Cursors.Default;
            txtItemNumber.ReadOnly = false;

        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            frmPrintLabel objPrintLabel;


            if (mobjItem == null)
            {
                MessageBox.Show("No item selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (mobjItem.SelectedJob == null)
            {
                MessageBox.Show("No job selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            PopulateBOL(true);

            objPrintLabel = new frmPrintLabel(mobjItem, mobjBOL);
            objPrintLabel.ShowDialog();
        }

        private void PopulateBOL(bool blnUpdateAverageUnitWeightHistory = false)
        {
            Single sngPieceWeight;
            int intQuantity;


            if (mobjBOL == null)
                mobjBOL = new BillOfLading();

            sngPieceWeight = Single.Parse(txtPieceWgt.Text);
            intQuantity = int.Parse(txtQuantity.Text);

            mobjBOL.AveragePieceWeight = sngPieceWeight;
            mobjBOL.GrossWeight = double.Parse(txtGrossWgt.Text);
            mobjBOL.TareWeight = double.Parse(txtTareWgt.Text);
            mobjBOL.Quantity = intQuantity;

            if (blnUpdateAverageUnitWeightHistory)
                mobjItem.UpdateAvgUnitWeightHistory(sngPieceWeight, intQuantity);
        }

        private void frmShipping_Load(object sender, EventArgs e)
        {
            SetDefaults();
            this.WindowState = FormWindowState.Maximized;//If I don't do this, then the form isn't rendered properly until I resize the screen.
        }

        private void btnGetJobs_Click(object sender, EventArgs e)
        {
            frmSelectItemJob objSelectItemJobForm;
            frmSelectOrder objSelectOrderForm;
            Job objTempJob = mobjItem.SelectedJob;


            try
            {
                //Modified 4-21-2015 - allows user to specify a job so that they can recieve items into history for jobs that have closed.
                if (chkSpecifyJob.Checked)
                    using (var objFrmSpecifyJob = new frmSpecifyJob())
                        if (objFrmSpecifyJob.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            mobjItem.SpecifiedJob = objFrmSpecifyJob.objJob;
                        else
                            mobjItem.SpecifiedJob = null;
                else
                    mobjItem.SpecifiedJob = null;
                    
                    
                objSelectItemJobForm = new frmSelectItemJob(mobjItem);
                objSelectItemJobForm.ShowDialog();
                if (objSelectItemJobForm.FormStatus != FormStatus.Succeeded)//if user does not select a new job
                {
                    mobjItem.SelectedJob = objTempJob;//set values back to thier previous state
                    return;                           //and exit the function
                }

                mobjItem.SelectedJob = objSelectItemJobForm.SelectedJob;//else set the values to the new job
                if (mobjItem.SelectedJob != null)//
                {
                    objSelectOrderForm = new frmSelectOrder(mobjItem);
                    objSelectOrderForm.ShowDialog();

                    if (objSelectOrderForm.FormStatus != FormStatus.Succeeded)
                    {
                        mobjItem.SelectedJob = objTempJob;
                        return;
                    }
                    SetJobValues();
                    mobjItem.SelectedOrder = objSelectOrderForm.SelectedOrder;
                    if (mobjItem.SelectedOrder != null)
                    {
                        SetOrderValues();
                        //Below I set the joborder number to the selectedorder's customerordernumber when the jobordernumber is null.  that way my filtering will work properly when shipping the item and the frmSelectOrder form is used.
                        mobjItem.SelectedJob.JobOrderNumber = string.IsNullOrEmpty(mobjItem.SelectedJob.JobOrderNumber) ? mobjItem.SelectedOrder.CustomerOrderNumber : string.Empty;
                    }
                    else
                        RemoveOrderValues();
                }
            }
            catch (Exception objEx)
            {
                MessageBox.Show(objEx.Message);
            }
            
        }

        private void chkIsMFG_CheckedChanged(object sender, EventArgs e)
        {
            if (mobjItem != null)
                mobjItem.IsSubItem = chkIsSubItem.Checked;
        }

        private void ValidateTextBoxIsNumeric(object sender, CancelEventArgs e)
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
                        case "txtPieceWgt":
                            mstrbldrErrors.Append("Invalid Piece Weight");
                            lblPcWeightError.Text = "X";
                            break;
                        case "txtGrossWgt":
                            mstrbldrErrors.Append("Invalid Gross Weight");
                            lblGrossWeightError.Text = "X";
                            break;
                    }
                else
                    switch (objTextBox.Name)
                    {
                        case "txtQuantity":
                            lblQuantityError.Text = string.Empty;
                            break;
                        case "txtPieceWgt":
                            lblPcWeightError.Text = string.Empty;
                            break;
                        case "txtGrossWgt":
                            lblGrossWeightError.Text = string.Empty;
                            break;
                    }


                //if (!double.TryParse(objTextBox.Text, out dblTemp))
                //{
                //    MessageBox.Show("Invalid Entry, Must be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    objTextBox.SelectAll();
                //    e.Cancel = true;
                //}
                //else
                //{
                //    switch (objTextBox.Name)
                //    {
                //        case "txtQuantity":
                //            if (dblTemp == 0)
                //            {
                //                objTextBox.SelectAll();
                //                e.Cancel = true;
                //                MessageBox.Show("Invalid Quantity, Cannot be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            }
                //            break;
                //        case "txtPieceWgt":
                //            if (dblTemp == 0)
                //            {
                //                objTextBox.SelectAll();
                //                e.Cancel = true;
                //                MessageBox.Show("Invalid Piece Weight, Cannot be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            }
                //            break;
                //        case "txtGrossWgt":
                //            if (dblTemp == 0)
                //            {
                //                objTextBox.SelectAll();
                //                e.Cancel = true;
                //                MessageBox.Show("Invalid Gross Weight, Cannot be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            }
                //            break;
                //    }
                //}
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            frmConfirmRecieveitem objConfirmReceiveItem;


            if (mobjItem == null)
            {
                MessageBox.Show("No item selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (mobjItem.SelectedJob == null)
            {
                MessageBox.Show("No job selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (mobjItem.LabelSequence == 0)
            {
                MessageBox.Show("Must print label before receiving item into inventory!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!this.ValidateChildren())
                return;


            objConfirmReceiveItem = new frmConfirmRecieveitem(mobjItem, mobjBOL);
            objConfirmReceiveItem.ShowDialog();

            if (objConfirmReceiveItem.FormsStatus == FormStatus.Errored)
                MessageBox.Show("Unable to receive item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (objConfirmReceiveItem.FormsStatus == FormStatus.Succeeded)
                MessageBox.Show("Item " + mobjItem.ItemID + " received.", "Item Received", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);



            ////The below is for testing purposes
            //Item objItem = new Item();
            //Job objJob = new Job();
            //Order objOrder = new Order();
            //mobjBOL = new BillOfLading();

            //objItem.ItemID = "11218";

            //objItem.SelectedJob = objJob;
            //objJob.JobNumber = "Booby";

            //objItem.SelectedJob.SelectedOrder = objOrder;
            //objOrder.CustomerOrderNumber = "007";

            //mobjBOL.AveragePieceWeight = 60;// Single.Parse(txtPieceWgt.Text);
            //mobjBOL.GrossWeight = 70; //double.Parse(txtGrossWgt.Text);
            //mobjBOL.TareWeight = 80; //double.Parse(txtTareWgt.Text);
            //mobjBOL.Quantity = 90; //int.Parse(txtQuantity.Text);

            ////objItem.Recieve(100, "JL");
            ////objItem.AddToReceiveHistory(mobjBOL, "JL");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmItemHistory objItemHistoryForm;
            

            if (mobjItem == null)
                MessageBox.Show("No item selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                objItemHistoryForm = new frmItemHistory(mobjItem, false);
                objItemHistoryForm.MdiParent = this.MdiParent;

                objItemHistoryForm.Show();
            }
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            frmSelectItemJobFromInventory objSelectItemJobFromInventoryForm;
            frmSelectItemJob objSelectItemJobForm;
            frmSelectOrder objSelectOrderForm;
            frmSelectOrderLine objSelectOrderReleaseForm;
            frmItemHistory objSelectItemHistoryForm;
            frmSelectOperation objSelectOperationForm;
            frmShipItem objShipItemForm;
            Item objItem;


            if (mobjItem == null)
            {
                MessageBox.Show("No item selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else
                objItem = new Item { ItemID = mobjItem.ItemID, IsSubItem = chkIsSubItem.Checked };

            //Case where Item IS MFG and item IS pulled from Inventory
            if (objItem.IsSubItem)
            {
                //use a select case statement to perform looping so that a user can walk up and down the decision tree; leverage an intcounter to do the walking and set it to negative to cancel out of 
                    //the decision tree.

                objSelectItemJobFromInventoryForm = new frmSelectItemJobFromInventory(objItem);
                objSelectItemJobFromInventoryForm.ShowDialog();
                if (objSelectItemJobFromInventoryForm.FormStatus == FormStatus.Succeeded)
                {
                    objItem.SelectedItemHistoryJob = objSelectItemJobFromInventoryForm.SelectedItemHistoryJob;
                    objItem.SelectedJob = new Job { JobNumber = objItem.SelectedItemHistoryJob.JobNumber, JobOrderNumber= objItem.SelectedItemHistoryJob.JobOrderNumber };

                    objSelectOrderForm = new frmSelectOrder(objItem);
                    objSelectOrderForm.ShowDialog();
                    if (objSelectOrderForm.FormStatus == FormStatus.Succeeded)
                    {
                        objItem.SelectedOrder = objSelectOrderForm.SelectedOrder;

                        objItem.CustomerOrderNumber = objItem.SelectedOrder.CustomerOrderNumber;
                        objSelectOrderReleaseForm = new frmSelectOrderLine(objItem);
                        objSelectOrderReleaseForm.ShowDialog();
                        if (objSelectOrderReleaseForm.FormStatus == FormStatus.Succeeded)
                        {
                            objItem.SelectedOrderLine = objSelectOrderReleaseForm.SelectedOrderLine;

                            objSelectItemHistoryForm = new frmItemHistory(objItem, true);
                            objSelectItemHistoryForm.ShowDialog();
                            if (objSelectItemHistoryForm.FormStatus == FormStatus.Succeeded)
                            {
                                objItem.SelectedHistoryTransactions = objSelectItemHistoryForm.SelectedItemHistoryJobs;

                                objSelectOperationForm = new frmSelectOperation(objItem.SelectedJob);
                                objSelectOperationForm.ShowDialog();
                                if (objSelectOperationForm.FormStatus == FormStatus.Succeeded)
                                {
                                    objItem.SelectedJob.SelectedOperation = objSelectOperationForm.SelectedOperation;

                                    objItem.IsPulledFromInventory = true;
                                    objShipItemForm = new frmShipItem(objItem);
                                    objShipItemForm.ShowDialog();
                                    if (objShipItemForm.FormStatus == FormStatus.Succeeded)
                                        MessageBox.Show("The Material Transaction completed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    else if (objShipItemForm.FormStatus == FormStatus.Cancelled)
                                        return;
                                    else
                                        MessageBox.Show(objShipItemForm.FormStatus.ToString() + " \r\nThe Material Transaction did NOT completed Successfully!",
                                            "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                                }
                            }
                        }

                    }
                }
            }
            else
            {
                objSelectItemJobForm = new frmSelectItemJob(mobjItem);
                objSelectItemJobForm.ShowDialog();
                if (objSelectItemJobForm.FormStatus == FormStatus.Succeeded)
                {
                    objItem.SelectedJob = objSelectItemJobForm.SelectedJob;

                    objSelectOrderForm = new frmSelectOrder(objItem);
                    objSelectOrderForm.ShowDialog();
                    if (objSelectOrderForm.FormStatus == FormStatus.Succeeded)
                    {
                        objItem.SelectedOrder = objSelectOrderForm.SelectedOrder;

                        objItem.CustomerOrderNumber = objItem.SelectedOrder.CustomerOrderNumber;
                        objSelectOrderReleaseForm = new frmSelectOrderLine(objItem);
                        objSelectOrderReleaseForm.ShowDialog();
                        if (objSelectOrderReleaseForm.FormStatus == FormStatus.Succeeded)
                        {
                            objItem.SelectedOrderLine = objSelectOrderReleaseForm.SelectedOrderLine;

                            objSelectOperationForm = new frmSelectOperation(objItem.SelectedJob);
                            objSelectOperationForm.ShowDialog();
                            if (objSelectOperationForm.FormStatus == FormStatus.Succeeded)
                            {
                                objItem.SelectedJob.SelectedOperation = objSelectOperationForm.SelectedOperation;

                                objItem.IsPulledFromInventory = false;
                                objShipItemForm = new frmShipItem(objItem);
                                objShipItemForm.ShowDialog();
                                if (objShipItemForm.FormStatus == FormStatus.Succeeded)
                                    MessageBox.Show("The Material Transaction completed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                else if (objShipItemForm.FormStatus == FormStatus.Cancelled)
                                    return;
                                else
                                    MessageBox.Show(objShipItemForm.FormStatus.ToString() + " \r\nThe Material Transaction did NOT completed Successfully!",
                                        "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                }
            }

            
        }

        private void btnPrintBOL_Click(object sender, EventArgs e)
        {
            frmBOL objBOLForm;


            PopulateBOL();
            objBOLForm = new frmBOL(mobjItem == null ? null : mobjItem.SelectedOrder, mobjBOL);
            objBOLForm.ShowDialog();
        }

        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            frmItems objItemsForm;


            objItemsForm = new frmItems(txtItemNumber.Text);
            objItemsForm.ShowDialog();

            if (objItemsForm.SelectedItem != null)
            {
                SetDefaults();
                mobjItem = objItemsForm.SelectedItem;
                SetItemValues();
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            double dblTareWeight, dblGrossWeight, dblPieceWeight;


            double.TryParse(txtTareWgt.Text, out dblTareWeight);
            double.TryParse(txtGrossWgt.Text, out dblGrossWeight);
            double.TryParse(txtPieceWgt.Text, out dblPieceWeight);

            if (dblPieceWeight > 0.0)
                txtQuantity.Text = Math.Ceiling((dblGrossWeight - dblTareWeight) / dblPieceWeight).ToString();// ("#,##0.####");
        }

        private void btnWrongCount_Click(object sender, EventArgs e)
        {
            if (mobjItem != null)
            {
                mobjItem.AddWrongCount();
                MessageBox.Show("A Wrong Count has been Recorded...", "Wrong Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
    }
}
