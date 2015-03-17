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
using Microsoft.Reporting.WinForms;


namespace WTF_ShippingApp
{
    public partial class frmPackingSlip : Form
    {
        private Order mobjOrder { get; set; }
        private BillOfLading mobjBOL { get; set; }
        private int mintCustomerNumber { get; set; }
        private int mintSelectedAddressIndex { get; set; }
        private BindingList<CustomerAddress> mobjCustomerAddressList { get; set; }
        private SortableSearchableBindingList<OrderLine> mobjOrderLines { get; set; }
        public FormStatus FormStatus { get; set; }
        private string mstrJobNumber { get; set; }
        private StringBuilder mstrbldrErrors = new StringBuilder();


        public frmPackingSlip(Order objOrder, BillOfLading objBOL = null, string strJobNumber = "")
        {
            InitializeComponent();

            /*sets the notes cell on the datagridview to multiline. Subsequently this is what also allows my custom control's (CustomDataGridView) overridden method to insert a newline when the enter key is pressed*/
            txtNotes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            mobjOrder = objOrder;
            mobjBOL = objBOL;
            mstrJobNumber = strJobNumber;//added per tonyj 10-10-12;if printing from order then this field will be empty.
        }

        private void frmPackingSlip_Load(object sender, EventArgs e)
        {
            int intTemp = 0;


            dgvOrderLines.AutoGenerateColumns = false;
            AddOrderReleaseColumn();
            dgvOrderLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtOrder.Text = mobjOrder.CustomerOrderNumber.Trim();
            lblPackingSlipSuffix.Text = mobjOrder.PackingSlipPrintSequence.ToString("D5");
            int.TryParse(mobjOrder.CustomerNumber, out intTemp);
            mintCustomerNumber = intTemp;

            if (mintCustomerNumber != 0)
                LoadCustomerAddresses();
            txtCustomer.Text = mintCustomerNumber.ToString();

            SetDGVDataSource();

            if (mobjBOL != null)
            {
                txtGrossWgt.Text = mobjBOL.GrossWeight.ToString();
                txtPalletCt.Text = mobjBOL.PalletCount.ToString();
            }

            ToolTip tltipSavePackingSlip = new ToolTip();
            tltipSavePackingSlip.AutoPopDelay = 5000;
            tltipSavePackingSlip.InitialDelay = 1000;
            tltipSavePackingSlip.ReshowDelay = 500;
            tltipSavePackingSlip.ShowAlways = true;
            tltipSavePackingSlip.SetToolTip(chkStorePackingSlip, "Check this to store the Packing Slip after the 'Print' button is pressed...");

        }

        private void AddOrderReleaseColumn()
        {
            if (mobjOrder.IsBlanketOrder)
            {
                DataGridViewTextBoxColumn objOrderReleaseColumn = new DataGridViewTextBoxColumn { HeaderText = "Release", Name = "txtOrderRelease", DataPropertyName = "CustomerOrderRelease" };
                dgvOrderLines.Columns.Insert(1, objOrderReleaseColumn);
            }
        }

        private void LoadCustomerAddresses()
        {
            //mobjCustomerAddressList = CustomerAddress.Search(mintCustomerNumber.ToString());
            mobjCustomerAddressList = CustomerAddress.Find(mintCustomerNumber.ToString());//Changed this implementation so this form will only display the addresses for the exact customer; search does a match...

            mintSelectedAddressIndex = -1;

            if (mobjCustomerAddressList.Count > 0)
            {
                //SelectCustomerAddress(0);
                SelectCustomerAddress(mobjOrder.SelectedAddressNo);//changed implementation to select address indicated as "ship to" on the order. added field "cust_seq" to property "SelectedAddressNo"
                grpAddress.Enabled = true;
            }
            else
            {
                MessageBox.Show("No addresses found for customer!", "No Addresses Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                lblAddrCt.Text = "";
                grpAddress.Enabled = false;
            }

        }

        private void SelectCustomerAddress(int intIndexNo)
        {
            CustomerAddress objCustomerAddress;


            btnNextAddr.Enabled = intIndexNo < mobjCustomerAddressList.Count - 1;
            btnPrevAddr.Enabled = intIndexNo > 0;
            lblAddrCt.Text = "Address " + (intIndexNo + 1).ToString() + " of " + mobjCustomerAddressList.Count;
            lblAddrCt.Refresh();
            txtAddress.Text = "";

            objCustomerAddress = mobjCustomerAddressList[intIndexNo];

            txtAddress.Text = objCustomerAddress.ToString();

            mintSelectedAddressIndex = intIndexNo;
        }

        private void btnNextAddr_Click(object sender, EventArgs e)
        {
            SelectCustomerAddress(mintSelectedAddressIndex + 1);
        }

        private void btnPrevAddr_Click(object sender, EventArgs e)
        {
            SelectCustomerAddress(mintSelectedAddressIndex - 1);
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            frmCustomers objCustomersForm;
            int intTemp;


            objCustomersForm = new frmCustomers(txtCustomer.Text);
            objCustomersForm.ShowDialog();

            if (objCustomersForm.SelectedCustomerAddress != null)
            {
                txtCustomer.Text = objCustomersForm.SelectedCustomerAddress.CustomerNumber;

                if (int.TryParse(objCustomersForm.SelectedCustomerAddress.CustomerNumber, out intTemp))
                    mintCustomerNumber = intTemp;
                LoadCustomerAddresses();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPackingSlipReport objPackingSlipReportForm;
            LocalReport objLocalReport;
            ReportParameter[] objParameterArray;
            ReportDataSource objOrderLinesDataSource;


            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;
                

            objPackingSlipReportForm = new frmPackingSlipReport();
            objPackingSlipReportForm.rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            objPackingSlipReportForm.rptViewer.ShowDocumentMapButton = false;

            objLocalReport = objPackingSlipReportForm.rptViewer.LocalReport;
            objLocalReport.ReportPath = "ReportTemplates\\PackingSlip.rdlc";

            objPackingSlipReportForm.rptViewer.SetDisplayMode(DisplayMode.PrintLayout);

            objParameterArray = new ReportParameter[11];
            objParameterArray[0] = new ReportParameter("OrderLinePrefix", chkEnableOrderLinePrefix.Checked ? txtOrderLinePrefix.Text : string.Empty);//need to introduce logic
            objParameterArray[1] = new ReportParameter("CustomerOrderNumber", txtOrder.Text.Trim());
            objParameterArray[2] = new ReportParameter("OrderNotes", mobjOrder.Notes);
            objParameterArray[3] = new ReportParameter("CustomerAddress", txtAddress.Text); // mobjCustomerAddressList[mintSelectedAddressIndex].ToString());
            objParameterArray[4] = new ReportParameter("CustomerNumber", txtCustomer.Text.Trim());
            objParameterArray[5] = new ReportParameter("CustomerOrderSuffix", mobjOrder.PackingSlipPrintSequence.ToString("D5"));
            objParameterArray[6] = new ReportParameter("ActualShipDate", dtmActualShipDate.Value.ToShortDateString());
            objParameterArray[7] = new ReportParameter("GrossWeight", txtGrossWgt.Text);
            objParameterArray[8] = new ReportParameter("NoOfCartons", txtCartonCt.Text);
            objParameterArray[9] = new ReportParameter("NoOfPallets", txtPalletCt.Text);
            objParameterArray[10] = new ReportParameter("JobNumber", mstrJobNumber);

            objLocalReport.SetParameters(objParameterArray);

            objOrderLinesDataSource = new ReportDataSource("OrderLines", mobjOrderLines);
            objLocalReport.DataSources.Add(objOrderLinesDataSource);

            objPackingSlipReportForm.ShowDialog();

            if (chkStorePackingSlip.Checked)
                StorePackingSlip(objParameterArray);

            if (MessageBox.Show("Did you print the packing slip?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                IncrememtPackingSlipSuffix();
                btnCancel.Text = "Finish";
            }
                
        }

        private void StorePackingSlip(ReportParameter[] objParameterArray)
        {
            decimal decTemp;


            var objPackingSlipLines = new List<PackingSlip>();
            foreach (var objOrder in mobjOrderLines)
            {
                objPackingSlipLines.Add(new PackingSlip
                {
                    PackingSlipNo = objParameterArray[1].Values[0] + "-" + objParameterArray[5].Values[0],
                    OrderLinePrefix = objParameterArray[0].Values[0],
                    CustomerOrderNumber = objParameterArray[1].Values[0],
                    OrderNotes = objParameterArray[2].Values[0],
                    CustomerAddress = objParameterArray[3].Values[0],
                    CustomerNumber = objParameterArray[4].Values[0],
                    CustomerOrderSuffix = objParameterArray[5].Values[0],
                    ActualShipDate = dtmActualShipDate.Value, // objParameterArray[6].Values[0],
                    GrossWeight = decimal.TryParse(objParameterArray[7].Values[0], out decTemp) ? decTemp : 0.0M,
                    NoOfCartons = decimal.TryParse(objParameterArray[8].Values[0], out decTemp) ? decTemp : 0.0M,
                    NoOfPallets = decimal.TryParse(objParameterArray[9].Values[0], out decTemp) ? decTemp : 0.0M,
                    JobNumber = objParameterArray[10].Values[0],
                    PrintDate = DateTime.Now,
                    CustomerOrderLine = objOrder.CustomerOrderLine,
                    CustomerOrderRelease = objOrder.CustomerOrderRelease,
                    PromiseDate = objOrder.PromiseDate,
                    ItemID = objOrder.ItemID,
                    ItemDescription = objOrder.ItemDescription,
                    QtyOrdered = objOrder.QtyOrdered,
                    QtyShipped = objOrder.QtyShipped,
                    QtyBackOrdered = objOrder.QtyBackOrdered,
                    Revision = objOrder.ItemRevision,
                    CustomerPO = objOrder.CustomerPO
                });
            }
            mobjOrder.SavePackingSlips(objPackingSlipLines);
        }


        //private void Validate(object sender, CancelEventArgs e)
        //{
        //    string strType = sender.GetType().ToString();


        //    //strbldrMessage = new StringBuilder();
        //    switch (strType.Substring(strType.LastIndexOf('.') + 1))
        //    {
        //        case "ComboBox":
        //            ComboBox objComboBox = (ComboBox)sender;
                    
        //            if (objComboBox.SelectedIndex == -1 || ((ComboBoxItem)objComboBox.Items[0]).Value.Equals("0"))
        //                switch (objComboBox.Name)
        //                {
        //                    case "cboCarrier":
        //                        mstrbldrErrors.Append("\r\n- No \"Carrier\" selected");
        //                        lblCarrierError.Text = "X";
        //                        break;
        //                    case "cboShipClass":
        //                        mstrbldrErrors.Append("\r\n- No \"Ship Classification\" selected");
        //                        lblShipClassificationError.Text = "X";
        //                        break;
        //                    case "cboFreightCharges":
        //                        mstrbldrErrors.Append("\r\n- No \"Freight Charges\" selected");
        //                        lblFreightChargesError.Text = "X";
        //                        break;
        //                }
        //            else
        //                switch (objComboBox.Name)
        //                {
        //                    case "cboCarrier":
        //                        lblCarrierError.Text = string.Empty;
        //                        break;
        //                    case "cboShipClass":
        //                        lblShipClassificationError.Text = string.Empty;
        //                        break;
        //                    case "cboFreightCharges":
        //                        lblFreightChargesError.Text = string.Empty;
        //                        break;
        //                }
        //                //objComboBox.BackColor = Color.FromKnownColor(KnownColor.ControlText);
        //            break;
        //        case "TextBox":
        //            TextBox objTextBox = (TextBox)sender;
        //            double dblTemp;

        //            switch (objTextBox.Name)
        //            {
        //                case "txtOrder":
        //                    if (objTextBox.Text.Length == 0)
        //                    {
        //                        mstrbldrErrors.Append("\r\n- Missing \"Order\"");
        //                        lblOrderError.Text = "X";
        //                    }
        //                    else
        //                        lblOrderError.Text = string.Empty;
        //                    break;
        //                case "txtGrossWgt":
        //                    if (objTextBox.Text.Length == 0 || !double.TryParse(objTextBox.Text, out dblTemp))
        //                    {
        //                        mstrbldrErrors.Append("\r\n- Invalid or missing \"Gross Wgt\".");
        //                        lblGrossWeightError.Text = "X";
        //                    }
        //                    else
        //                        lblGrossWeightError.Text = string.Empty;
        //                    break;
        //                case "txtPalletCt":
        //                    if (objTextBox.Text.Length == 0 || !double.TryParse(objTextBox.Text, out dblTemp))
        //                    {
        //                        mstrbldrErrors.Append("\r\n- Invalid or missing \"# of Pallets\"");
        //                        lblPalletCountError.Text = "X";
        //                    }
        //                    else
        //                        lblPalletCountError.Text = string.Empty;
        //                    break;
        //                case "txtAddress":
        //                    if (objTextBox.Text.Length == 0)
        //                    {
        //                        mstrbldrErrors.Append("\r\n- No \"Customer Address\" specified");
        //                        lblAddressError.Text = "X";
        //                    }
        //                    else
        //                        lblAddressError.Text = string.Empty;
        //                    break;
        //            }
        //            break;
        //    }

            //if (strbldrMessage.Length != 0)
            //{
            //    //MessageBox.Show("The following information is missing or invalid:" +
            //    //    strbldrMessage.ToString(), "Information Missing or Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //    e.Cancel = true;
            //}
            
        //}

        private void SetDGVDataSource()
        {
            mobjOrderLines = new SortableSearchableBindingList<OrderLine>();

            if (chkLastFilledOrder.Checked)/*I added this implementation so that Tony could create a packing slip for -mfg items that are going to a plater under a filled order */
            {                               /*Since there would not be an open order for a -mfg item under which they could ship.*/
                mobjOrderLines.Add(mobjOrder.OrderLines
                    .Where(o => o.LineOrReleaseStatus == "F")
                    .OrderByDescending(l => l.CustomerOrderLine)
                    .OrderByDescending(l => l.CustomerOrderRelease)
                    .Take(1)
                    .SingleOrDefault());

                if (mobjOrderLines[0] == null)//if there is no value returned from the above query then a null orderline is added to the collection.
                    mobjOrderLines.Clear();     //I cleare it out so that it doesn't show on my datagrid as an empty row.
            }
            else
                foreach (OrderLine objOrderLine in mobjOrder.OrderLines.Where(o => o.LineOrReleaseStatus == "O").ToList())
                {
                    objOrderLine.Notes = objOrderLine.GetInternalNotes();
                    mobjOrderLines.Add(objOrderLine);
                }

            dgvOrderLines.DataSource = mobjOrderLines;
        }

        private void Validate(object sender, CancelEventArgs e)
        {
            //string strType = sender.GetType().ToString();


            ////strbldrMessage = new StringBuilder();
            //switch (strType.Substring(strType.LastIndexOf('.') + 1))
            //{
            //    case "ComboBox":
            //        ComboBox objComboBox = (ComboBox)sender;

            //        if (objComboBox.SelectedIndex == -1 || ((ComboBoxItem)objComboBox.Items[0]).Value.Equals("0"))
            //            switch (objComboBox.Name)
            //            {
            //                case "cboCarrier":
            //                    mstrbldrErrors.Append("\r\n- No \"Carrier\" selected");
            //                    lblCarrierError.Text = "X";
            //                    break;
            //                case "cboShipClass":
            //                    mstrbldrErrors.Append("\r\n- No \"Ship Classification\" selected");
            //                    lblShipClassificationError.Text = "X";
            //                    break;
            //                case "cboFreightCharges":
            //                    mstrbldrErrors.Append("\r\n- No \"Freight Charges\" selected");
            //                    lblFreightChargesError.Text = "X";
            //                    break;
            //            }
            //        else
            //            switch (objComboBox.Name)
            //            {
            //                case "cboCarrier":
            //                    lblCarrierError.Text = string.Empty;
            //                    break;
            //                case "cboShipClass":
            //                    lblShipClassificationError.Text = string.Empty;
            //                    break;
            //                case "cboFreightCharges":
            //                    lblFreightChargesError.Text = string.Empty;
            //                    break;
            //            }
            //        //objComboBox.BackColor = Color.FromKnownColor(KnownColor.ControlText);
            //        break;
            //    case "TextBox":
            //        TextBox objTextBox = (TextBox)sender;
            //        double dblTemp;

            //        switch (objTextBox.Name)
            //        {
            //            case "txtOrder":
            //                if (objTextBox.Text.Length == 0)
            //                {
            //                    mstrbldrErrors.Append("\r\n- Missing \"Order\"");
            //                    lblOrderError.Text = "X";
            //                }
            //                else
            //                    lblOrderError.Text = string.Empty;
            //                break;
            //            case "txtGrossWgt":
            //                if (objTextBox.Text.Length == 0 || !double.TryParse(objTextBox.Text, out dblTemp))
            //                {
            //                    mstrbldrErrors.Append("\r\n- Invalid or missing \"Gross Wgt\".");
            //                    lblGrossWeightError.Text = "X";
            //                }
            //                else
            //                    lblGrossWeightError.Text = string.Empty;
            //                break;
            //            case "txtPalletCt":
            //                if (objTextBox.Text.Length == 0 || !double.TryParse(objTextBox.Text, out dblTemp))
            //                {
            //                    mstrbldrErrors.Append("\r\n- Invalid or missing \"# of Pallets\"");
            //                    lblPalletCountError.Text = "X";
            //                }
            //                else
            //                    lblPalletCountError.Text = string.Empty;
            //                break;
            //            case "txtAddress":
            //                if (objTextBox.Text.Length == 0)
            //                {
            //                    mstrbldrErrors.Append("\r\n- No \"Customer Address\" specified");
            //                    lblAddressError.Text = "X";
            //                }
            //                else
            //                    lblAddressError.Text = string.Empty;
            //                break;
            //        }
            //        break;
            //}
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    try
                    {
                        if (!string.IsNullOrEmpty(txtCustomer.Text))
                        {
                            var objCustomerAddress = new CustomerAddress(txtCustomer.Text);// objCustomersForm.SelectedCustomerAddress.CustomerNumber;

                            mintCustomerNumber = int.Parse(objCustomerAddress.CustomerNumber);
                            txtCustomer.Text = mintCustomerNumber.ToString();
                            LoadCustomerAddresses();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Customer " +txtCustomer.Text + " Not Found","No Customer Found", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    break;
            }
        }

        private void btnIncrementSuffix_Click(object sender, EventArgs e)
        {
            IncrememtPackingSlipSuffix();
        }

        private void IncrememtPackingSlipSuffix()
        {
            if (mobjOrder.IncrementPackingSlipSuffix())
            {
                ++mobjOrder.PackingSlipPrintSequence;
                lblPackingSlipSuffix.Text = mobjOrder.PackingSlipPrintSequence.ToString("D5");
            }
        }

        private void chkLastFilledOrder_CheckedChanged(object sender, EventArgs e)
        {
            SetDGVDataSource();
        }
    }
}
