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
    public partial class frmBOL : Form
    {
        public Order mobjOrder { get; set; }
        private BillOfLading mobjBOL { get; set; }
        private int mintCustomerNumber { get; set; }
        private int mintSelectedAddressIndex { get; set; }
        private BindingList<CustomerAddress> mobjCustomerAddressList { get; set; }
        public FormStatus FormStatus { get; set; }
        private StringBuilder mstrbldrErrors = new StringBuilder();


        public frmBOL(Order objOrder, BillOfLading objBOL)
        {
            InitializeComponent();

            mobjOrder = objOrder;
            mobjBOL = objBOL;
        }

        private void frmBOL_Load(object sender, EventArgs e)
        {
            int intTemp = 0;


            if (mobjOrder != null)
            {
                txtOrder.Text = mobjOrder.CustomerOrderNumber.Trim();
                int.TryParse(mobjOrder.CustomerNumber, out intTemp);
            }
            mintCustomerNumber = intTemp;

            if (mintCustomerNumber != 0)
                LoadCustomerAddresses();

            LoadCarriers();
            LoadShipClassifications();
            LoadFreightCharges();

            txtCustomer.Text = mintCustomerNumber.ToString();

            txtGrossWgt.Text = mobjBOL.GrossWeight.ToString();
            txtPalletCt.Text = mobjBOL.PalletCount.ToString();
        }

        private void LoadCarriers()
        {
            cboCarrier.Items.Add(new ComboBoxItem { Text = "--- Select Carrier ---", Value = "0" });
            foreach (ComboBoxItem objComboBoxItem in mobjBOL.ShippingCarriers)
                cboCarrier.Items.Add(objComboBoxItem);
            cboCarrier.SelectedIndex = 0;
        }

        private void LoadShipClassifications()
        {
            cboShipClass.Items.Add(new ComboBoxItem { Text = "--- Select Ship Classification ---", Value = "0" });
            foreach (ComboBoxItem objComboBoxItem in mobjBOL.ShippingClassifications)
                cboShipClass.Items.Add(objComboBoxItem);
            cboShipClass.SelectedIndex = 0;
        }

        private void LoadFreightCharges()
        {
            cboFreightCharges.Items.Add(new ComboBoxItem { Text = "--- Select Freight Charges ---", Value = "0" });
            cboFreightCharges.Items.Add(new ComboBoxItem { Text = "Pre-Paid", Value = "1" });
            cboFreightCharges.Items.Add(new ComboBoxItem { Text = "Collect", Value = "2" });
            cboFreightCharges.Items.Add(new ComboBoxItem { Text = "Third Party", Value = "3" });
            cboFreightCharges.SelectedIndex = 0;
        }

        private void LoadCustomerAddresses()
        {
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter;
            SqlCommand objSQLCommand;
            CustomerAddress objCustomerAddress;
            string strSQL;


            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectCustomerAddresses", new string[] { mintCustomerNumber.ToString() });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
            objDataAdapter = new SqlDataAdapter(objSQLCommand);
            objDataAdapter.Fill(objDataTable);

            mobjCustomerAddressList = new BindingList<CustomerAddress>();

            foreach (DataRow objRow in objDataTable.Rows)
            {
                objCustomerAddress = new CustomerAddress();

                objCustomerAddress.Name = objRow["Name"].ToString();
                objCustomerAddress.AddressLine1 = objRow["Addr##1"].ToString();
                objCustomerAddress.AddressLine2 = objRow["Addr##2"].ToString();
                objCustomerAddress.AddressLine3 = objRow["Addr##3"].ToString();
                objCustomerAddress.AddressLine4 = objRow["Addr##4"].ToString();
                objCustomerAddress.City = objRow["City"].ToString();
                objCustomerAddress.State = objRow["State"].ToString();
                objCustomerAddress.ZipCode = objRow["ZIP"].ToString();

                mobjCustomerAddressList.Add(objCustomerAddress);
            }

            mintSelectedAddressIndex = -1;

            if (objDataTable.Rows.Count > 0)
            {
                SelectCustomerAddress(0);
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
            StringBuilder objStrBldr;
            CustomerAddress objCustomerAddress;



            btnNextAddr.Enabled = intIndexNo < mobjCustomerAddressList.Count - 1;
            btnPrevAddr.Enabled = intIndexNo > 0;
            lblAddrCt.Text = "Address " + (intIndexNo + 1).ToString() + " of " + mobjCustomerAddressList.Count;
            lblAddrCt.Refresh();
            txtAddress.Text = "";

            objStrBldr = new StringBuilder();
            objCustomerAddress = mobjCustomerAddressList[intIndexNo];

            objStrBldr.Append(objCustomerAddress.Name);
            objStrBldr.Append(objCustomerAddress.AddressLine1.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine1 : string.Empty);
            objStrBldr.Append(objCustomerAddress.AddressLine2.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine2 : string.Empty);
            objStrBldr.Append(objCustomerAddress.AddressLine3.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine3 : string.Empty);
            objStrBldr.Append(objCustomerAddress.AddressLine4.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine4 : string.Empty);
            objStrBldr.Append("\r\n" + objCustomerAddress.City + ", " + objCustomerAddress.State + " " + objCustomerAddress.ZipCode);

            txtAddress.Text = objStrBldr.ToString();

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

        private void Combobox_DropDown(object sender, EventArgs e)
        {
            ComboBox objComboBox = (ComboBox)sender;

            if (((ComboBoxItem)objComboBox.Items[0]).Value.Equals("0"))
                objComboBox.Items.Remove(objComboBox.Items[0]);
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            frmCustomers objCustomersForm;
            int intTemp;


            objCustomersForm = new frmCustomers(txtCustomer.Text);
            objCustomersForm.ShowDialog();

            if (objCustomersForm.SelectedCustomerAddress != null)
            {
                txtCustomer.Text = objCustomersForm.SelectedCustomerAddress.CustomerNumber.Trim();

                if (int.TryParse(objCustomersForm.SelectedCustomerAddress.CustomerNumber, out intTemp))
                    mintCustomerNumber = intTemp;
                LoadCustomerAddresses();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmBillOfLadingReport objBillOfLadingReportForm;
            LocalReport objLocalReport;
            ReportParameter[] objParameterArray;


            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            objBillOfLadingReportForm = new frmBillOfLadingReport();
            objBillOfLadingReportForm.rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            objBillOfLadingReportForm.rptViewer.ShowDocumentMapButton = false;

            objLocalReport = objBillOfLadingReportForm.rptViewer.LocalReport;
            objLocalReport.ReportPath = "ReportTemplates\\BillOfLading.rdlc";

            objBillOfLadingReportForm.rptViewer.SetDisplayMode(DisplayMode.PrintLayout);

            objParameterArray = new ReportParameter[9];
            objParameterArray[0] = new ReportParameter("CarrierDescription", ((ComboBoxItem)cboCarrier.SelectedItem).Text);
            objParameterArray[1] = new ReportParameter("FreightCharges", ((ComboBoxItem)cboFreightCharges.SelectedItem).Text);
            objParameterArray[2] = new ReportParameter("TotalCharges", "");
            objParameterArray[3] = new ReportParameter("PalletCount", txtPalletCt.Text);
            objParameterArray[4] = new ReportParameter("GrossWeight", txtGrossWgt.Text);
            objParameterArray[5] = new ReportParameter("ShipClassification", ((ComboBoxItem)cboShipClass.SelectedItem).Text);
            objParameterArray[6] = new ReportParameter("Notes", txtNotes.Text);
            objParameterArray[7] = new ReportParameter("CustomerAddress", txtAddress.Text);
            objParameterArray[8] = new ReportParameter("CustomerOrderNumber", txtOrder.Text);
            objLocalReport.SetParameters(objParameterArray);

            objBillOfLadingReportForm.ShowDialog();

            btnCancel.Text = "Finish";
        }

        private void Validate(object sender, CancelEventArgs e)
        {
            string strType = sender.GetType().ToString();


            //strbldrMessage = new StringBuilder();
            switch (strType.Substring(strType.LastIndexOf('.') + 1))
            {
                case "ComboBox":
                    ComboBox objComboBox = (ComboBox)sender;
                    
                    if (objComboBox.SelectedIndex == -1 || ((ComboBoxItem)objComboBox.Items[0]).Value.Equals("0"))
                        switch (objComboBox.Name)
                        {
                            case "cboCarrier":
                                mstrbldrErrors.Append("\r\n- No \"Carrier\" selected");
                                lblCarrierError.Text = "X";
                                break;
                            case "cboShipClass":
                                mstrbldrErrors.Append("\r\n- No \"Ship Classification\" selected");
                                lblShipClassificationError.Text = "X";
                                break;
                            case "cboFreightCharges":
                                mstrbldrErrors.Append("\r\n- No \"Freight Charges\" selected");
                                lblFreightChargesError.Text = "X";
                                break;
                        }
                    else
                        switch (objComboBox.Name)
                        {
                            case "cboCarrier":
                                lblCarrierError.Text = string.Empty;
                                break;
                            case "cboShipClass":
                                lblShipClassificationError.Text = string.Empty;
                                break;
                            case "cboFreightCharges":
                                lblFreightChargesError.Text = string.Empty;
                                break;
                        }
                        //objComboBox.BackColor = Color.FromKnownColor(KnownColor.ControlText);
                    break;
                case "TextBox":
                    TextBox objTextBox = (TextBox)sender;
                    double dblTemp;

                    switch (objTextBox.Name)
                    {
                        case "txtOrder":
                            if (objTextBox.Text.Length == 0)
                            {
                                mstrbldrErrors.Append("\r\n- Missing \"Order\"");
                                lblOrderError.Text = "X";
                            }
                            else
                                lblOrderError.Text = string.Empty;
                            break;
                        case "txtGrossWgt":
                            if (objTextBox.Text.Length == 0 || !double.TryParse(objTextBox.Text, out dblTemp))
                            {
                                mstrbldrErrors.Append("\r\n- Invalid or missing \"Gross Wgt\".");
                                lblGrossWeightError.Text = "X";
                            }
                            else
                                lblGrossWeightError.Text = string.Empty;
                            break;
                        case "txtPalletCt":
                            if (objTextBox.Text.Length == 0 || !double.TryParse(objTextBox.Text, out dblTemp))
                            {
                                mstrbldrErrors.Append("\r\n- Invalid or missing \"# of Pallets\"");
                                lblPalletCountError.Text = "X";
                            }
                            else
                                lblPalletCountError.Text = string.Empty;
                            break;
                        case "txtAddress":
                            if (objTextBox.Text.Length == 0)
                            {
                                mstrbldrErrors.Append("\r\n- No \"Customer Address\" specified");
                                lblAddressError.Text = "X";
                            }
                            else
                                lblAddressError.Text = string.Empty;
                            break;
                    }
                    break;
            }

            //if (strbldrMessage.Length != 0)
            //{
            //    //MessageBox.Show("The following information is missing or invalid:" +
            //    //    strbldrMessage.ToString(), "Information Missing or Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //    e.Cancel = true;
            //}
            
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
                            lblCustomerError.Text = string.Empty;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Customer " + txtCustomer.Text + " Not Found", "No Customer Found", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        lblCustomerError.Text = "X";
                    }
                    break;
            }
        }
    }
}
