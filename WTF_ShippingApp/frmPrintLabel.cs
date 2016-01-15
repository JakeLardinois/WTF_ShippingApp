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
using Seagull.BarTender.Print;


namespace WTF_ShippingApp
{
    //public partial class frmPrintLabel : Form
    //{
    //    private Item mobjItem { get; set; }
    //    private BillOfLading mobjBOL { get; set; }
    //    private BindingList<CustomerAddress> mobjCustomerAddressList { get; set; }
    //    private int mintCustomerNumber { get; set; }
    //    private string mstrCustomerName { get; set; }
    //    private WTFClassLibrary.Label mobjSelectedLabel { get; set; }
    //    private int mintSelectedAddressIndex { get; set; }
    //    private StringBuilder mstrbldrErrors = new StringBuilder();


    //    public frmPrintLabel(Item objItem, BillOfLading objBOL )
    //    {
    //        int intTemp = 0;


    //        InitializeComponent();
            
    //        mobjItem = objItem;
    //        mobjBOL = objBOL;

    //        if (int.TryParse(mobjItem.SelectedOrder.CustomerNumber, out intTemp))
    //            mintCustomerNumber = intTemp;
    //        else if (int.TryParse(mobjItem.SelectedJob.CustomerNumber, out intTemp))
    //            mintCustomerNumber = intTemp;

    //        mstrCustomerName = mobjItem.SelectedJob.CustomerName;

    //        mobjSelectedLabel = new WTFClassLibrary.Label();

    //        grpMultiple.Enabled = false;
    //        chkMultiple.Checked = false;
    //    }

    //    private void LoadLabelFormatsList()
    //    {
    //        ExtraSytelineTablesSettings objExtraSytelineTableSettings;
    //        DataTable objDataTable = new DataTable();
    //        SqlDataAdapter objDataAdapter;
    //        SqlCommand objSQLCommand;
    //        WTFClassLibrary.Label objLabel;
    //        string strSQL;
    //        long lngTemp;
    //        int intTemp;


    //        objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();

    //        strSQL = QueryDefinitions.GetQuery("SelectCustomerLabels", new string[] { mintCustomerNumber.ToString() });
    //        objExtraSytelineTableSettings.SQLConnection.Open();
    //        objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
    //        objSQLCommand.CommandText = strSQL;
    //        objDataAdapter = new SqlDataAdapter(objSQLCommand);
    //        objDataAdapter.Fill(objDataTable);

    //        cboLabels.Items.Clear();

    //        objLabel = new WTFClassLibrary.Label();
    //        objLabel.Description = "--- Select Label Format ---";

    //        cboLabels.Items.Add(objLabel);

    //        foreach (DataRow objRow in objDataTable.Rows)
    //        {
    //            objLabel = new WTFClassLibrary.Label();

    //            if (long.TryParse(objRow["CustomerLabelID"].ToString(), out lngTemp))
    //                objLabel.CustomerLabelID = lngTemp;
    //            else
    //                objLabel.CustomerLabelID = 0;

    //            if (int.TryParse(objRow["AddrLineCt"].ToString(), out intTemp))
    //                objLabel.AddressLineCount = intTemp;
    //            else
    //                objLabel.AddressLineCount = 0;

    //            objLabel.Description = objRow["Description"].ToString();
    //            objLabel.LabelFile = objRow["LabelFile"].ToString();
    //            objLabel.SupplierNumber = objRow["SupplierNumber"].ToString();

    //            if (long.TryParse(objRow["Sequence"].ToString(), out lngTemp))
    //                objLabel.Sequence = lngTemp;
    //            else
    //                objLabel.Sequence = 0;

    //            cboLabels.Items.Add(objLabel);
    //        }

    //        cboLabels.SelectedIndex = 0;
    //    }

    //    private void frmPrintLabel_Load(object sender, EventArgs e)
    //    {
    //        lblItem.Text = mobjItem.ItemID + " - " + mobjItem.Description;
    //        txtCustomer.Text = mintCustomerNumber.ToString();

    //        LoadLabelFormatsList();

    //        if (mintCustomerNumber != 0)
    //            LoadCustomerAddresses();

    //    }

    //    private void LoadCustomerAddresses()
    //    {
    //        SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
    //        DataTable objDataTable = new DataTable();
    //        SqlDataAdapter objDataAdapter;
    //        SqlCommand objSQLCommand;
    //        CustomerAddress objCustomerAddress;
    //        string strSQL;
            

    //        objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
    //        strSQL = QueryDefinitions.GetQuery("SelectCustomerAddresses", new string[] { mintCustomerNumber.ToString() });
    //        objSL8_WTF_DataBaseSettings.SQLConnection.Open();
    //        objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
    //        objDataAdapter = new SqlDataAdapter(objSQLCommand);
    //        objDataAdapter.Fill(objDataTable);

    //        mobjCustomerAddressList = new BindingList<CustomerAddress>();

    //        foreach (DataRow objRow in objDataTable.Rows)
    //        {
    //            objCustomerAddress = new CustomerAddress();

    //            objCustomerAddress.Name = objRow["Name"].ToString();
    //            objCustomerAddress.AddressLine1 = objRow["Addr##1"].ToString();
    //            objCustomerAddress.AddressLine2 = objRow["Addr##2"].ToString();
    //            objCustomerAddress.AddressLine3 = objRow["Addr##3"].ToString();
    //            objCustomerAddress.AddressLine4 = objRow["Addr##4"].ToString();
    //            objCustomerAddress.City = objRow["City"].ToString();
    //            objCustomerAddress.State = objRow["State"].ToString();
    //            objCustomerAddress.ZipCode = objRow["ZIP"].ToString();

    //            mobjCustomerAddressList.Add(objCustomerAddress);
    //        }

    //        mintSelectedAddressIndex = -1;

    //        if (objDataTable.Rows.Count > 0)
    //        {
    //            SelectCustomerAddress(0);
    //            grpAddress.Enabled = (mobjSelectedLabel.AddressLineCount > 0);
    //        }
    //        else
    //        {
    //            MessageBox.Show("No addresses found for customer!", "No Addresses Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
    //            lblAddrCt.Text = "";
    //            grpAddress.Enabled = false;
    //        }
                
    //    }

    //    private void SelectCustomerAddress(int intIndexNo)
    //    {
    //        StringBuilder objStrBldr;
    //        CustomerAddress objCustomerAddress;
            

            
    //        btnNextAddr.Enabled = intIndexNo < mobjCustomerAddressList.Count - 1 && mobjSelectedLabel.AddressLineCount > 0;
    //        btnPrevAddr.Enabled = intIndexNo > 0;
    //        lblAddrCt.Text = "Address " + (intIndexNo + 1).ToString() + " of " + mobjCustomerAddressList.Count;
    //        lblAddrCt.Refresh();
    //        txtAddress.Text = "";

    //        if (mobjSelectedLabel.AddressLineCount > 0)
    //        {
    //            objStrBldr = new StringBuilder();
    //            objCustomerAddress = mobjCustomerAddressList[intIndexNo];

    //            objStrBldr.Append(objCustomerAddress.Name);
    //            objStrBldr.Append(mobjSelectedLabel.AddressLineCount >= 3 && objCustomerAddress.AddressLine1.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine1 : string.Empty);
    //            objStrBldr.Append(mobjSelectedLabel.AddressLineCount >= 4 && objCustomerAddress.AddressLine2.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine2 : string.Empty);
    //            objStrBldr.Append(mobjSelectedLabel.AddressLineCount >= 5 && objCustomerAddress.AddressLine3.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine3 : string.Empty);
    //            objStrBldr.Append(mobjSelectedLabel.AddressLineCount == 6 && objCustomerAddress.AddressLine4.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine4 : string.Empty);
    //            objStrBldr.Append("\r\n" + objCustomerAddress.City + ", " + objCustomerAddress.State + " " + objCustomerAddress.ZipCode);

    //            txtAddress.Text = objStrBldr.ToString();
    //        }

    //        mintSelectedAddressIndex = intIndexNo;
    //    }

    //    private void btnCustomerSearch_Click(object sender, EventArgs e)
    //    {
    //        frmCustomers objCustomersForm;
    //        int intTemp;


    //        objCustomersForm = new frmCustomers(txtCustomer.Text);
    //        objCustomersForm.ShowDialog();

    //        if (objCustomersForm.SelectedCustomerAddress != null)
    //        {
    //            txtCustomer.Text = objCustomersForm.SelectedCustomerAddress.CustomerNumber;

    //            if (int.TryParse(objCustomersForm.SelectedCustomerAddress.CustomerNumber, out intTemp))
    //                mintCustomerNumber = intTemp;
    //            LoadCustomerAddresses();
    //            LoadLabelFormatsList();
    //        }
    //    }

    //    private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
    //    {
    //        int intTemp = 0;


    //        switch (e.KeyCode)
    //        {
    //            case Keys.Return:
    //                if (int.TryParse(txtCustomer.Text, out intTemp))
    //                {
    //                    mintCustomerNumber = intTemp;
    //                    txtCustomer.Text = intTemp.ToString();
    //                    mintCustomerNumber = intTemp;
    //                    LoadCustomerAddresses();
    //                    LoadLabelFormatsList();
    //                }
    //                else
    //                {
    //                    MessageBox.Show("Invalid Customer Number");
    //                }
    //                break;
    //        }
    //    }

    //    private void cboLabels_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        mobjSelectedLabel = cboLabels.SelectedItem as WTFClassLibrary.Label;

    //        if (cboLabels.SelectedIndex == 0 || mobjCustomerAddressList == null)
    //        {
    //            grpAddress.Enabled = false;
    //            lblAddrCt.Text = "";
    //        }
    //        else
    //        {
    //            txtSupplier.Text = mobjSelectedLabel.SupplierNumber;
    //            lblAddrLineCt.Text = "IMPORTANT:  Maximum number of address lines for the label is " + mobjSelectedLabel.AddressLineCount;
    //            txtAddress.Text = "";
    //            grpAddress.Enabled = (mobjSelectedLabel.AddressLineCount > 0);
    //            SelectCustomerAddress(mintSelectedAddressIndex);
    //        }
    //    }

    //    private void btnNextAddr_Click(object sender, EventArgs e)
    //    {
    //        SelectCustomerAddress(mintSelectedAddressIndex + 1);
    //    }

    //    private void btnPrevAddr_Click(object sender, EventArgs e)
    //    {
    //        SelectCustomerAddress(mintSelectedAddressIndex - 1);
    //    }

    //    private void btnCancel_Click(object sender, EventArgs e)
    //    {
    //        this.Dispose();
    //    }

    //    private void chkMultiple_CheckedChanged(object sender, EventArgs e)
    //    {
    //        grpMultiple.Enabled = chkMultiple.Checked;
    //    }

    //    private void btnPrint_Click(object sender, EventArgs e)
    //    {
    //        LabelVision.Application objLabelVisionApp;
    //        LabelVision.Label objLabelVisionLabel;
    //        string strLabelFile;


    //        mstrbldrErrors.Clear();
    //        this.ValidateChildren();
    //        if (mstrbldrErrors.Length > 0)
    //            return;

    //        //else if (cboLabels.SelectedIndex <= 0)
    //        //{
    //        //    MessageBox.Show("No label selected!", "Select a Label", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
    //        //    return;
    //        //}


    //        try
    //        {
    //            objLabelVisionApp = new LabelVision.Application();
    //            strLabelFile = Settings.GetLabelPath() + mobjSelectedLabel.LabelFile;
    //            objLabelVisionLabel = objLabelVisionApp.OpenLabel(strLabelFile);

    //            objLabelVisionLabel.LabelFields["co.MfgOrder"].Value = mobjItem.SelectedJob.CustomerOrderNumber;

    //            if (chkMultiple.Checked)
    //            {
    //                objLabelVisionLabel.BuiltInFields["Print Count"].Value = int.Parse(txtQty.Text);
    //                objLabelVisionLabel.BuiltInFields["Duplicate Count"].Value = udCopies.Value;
    //            }
    //            else
    //            {
    //                mobjItem.LabelSequence = mobjSelectedLabel.GetNextSequence();
    //                objLabelVisionLabel.LabelFields["CustomerLabel.sequence"].Value = mobjItem.LabelSequence;
    //            }

    //            objLabelVisionLabel.LabelFields["item.item"].Value = mobjItem.ItemID;
    //            objLabelVisionLabel.LabelFields["co.MfgOrder"].Value = mobjItem.SelectedOrder.CustomerOrderNumber + mobjItem.SelectedJob.JobNumber;
    //            objLabelVisionLabel.LabelFields["item.description"].Value = mobjItem.Description;
    //            objLabelVisionLabel.LabelFields["co.order"].Value = mobjItem.SelectedOrder.CustomerOrderNumber;
    //            objLabelVisionLabel.LabelFields["co.custpartno"].Value = mobjItem.CustomerItem; //.Replace("#", "")
    //            objLabelVisionLabel.LabelFields["bol.grossweight"].Value = mobjBOL.GrossWeight;
    //            objLabelVisionLabel.LabelFields["bol.tareweight"].Value = mobjBOL.TareWeight;
    //            objLabelVisionLabel.LabelFields["bol.netweight"].Value = mobjBOL.NetWeight;
    //            objLabelVisionLabel.LabelFields["bol.piecect"].Value = mobjBOL.Quantity;
    //            objLabelVisionLabel.LabelFields["bol.avepcweight"].Value = mobjBOL.AveragePieceWeight.ToString("F3");
    //            objLabelVisionLabel.LabelFields["co.supplier"].Value = txtSupplier.Text;
    //            objLabelVisionLabel.LabelFields["bol.cartons"].Value = txtCartons.Text;
    //            objLabelVisionLabel.LabelFields["item.drawing-nbr"].Value = mobjItem.DrawingNumber;

    //            try
    //            {
    //                objLabelVisionLabel.LabelFields["item.revision"].Value = mobjItem.Revision;
    //            }
    //            catch { }//--- Do nothing.  Ignore error because field is not on all labels.

    //            objLabelVisionLabel.LabelFields["Co.Cust-nbr"].Value = txtCustomer.Text;
    //            objLabelVisionLabel.LabelFields["co.Cust-po"].Value = mobjItem.SelectedOrder.CustomerPO;

    //            if (!string.IsNullOrEmpty(txtAddress.Text))
    //                objLabelVisionLabel.LabelFields["CustomerAddress.address"].Value = txtAddress.Text;

    //            objLabelVisionLabel.PrintOut(true, true);
    //            objLabelVisionLabel.Close();
    //            objLabelVisionApp.Quit();

    //            btnCancel.Text = "Finish";
    //        }
    //        catch (Exception objEx)
    //        {
    //            MessageBox.Show("Error during label preparation: " + objEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
    //        }
            
    //    }

    //    private void Validate(object sender, CancelEventArgs e)
    //    {
    //        int intTemp;
    //        TextBox objTextBox;
    //        ComboBox objComboBox;


    //        if (sender is TextBox)
    //        {
    //            objTextBox = (TextBox)sender;

    //            if (objTextBox.Text.Length == 0 || !int.TryParse(objTextBox.Text, out intTemp) || intTemp == 0)
    //                switch (objTextBox.Name)
    //                {
    //                    case "txtQty":
    //                        mstrbldrErrors.Append("Invalid Label Quantity");
    //                        lblQtyError.Text = "X";
    //                        break;
    //                }
    //            else
    //            {
    //                switch (objTextBox.Name)
    //                {
    //                    case "txtQty":
    //                        lblQtyError.Text = string.Empty;
    //                        break;
    //                }
    //            }
    //        }
    //        else if (sender is ComboBox)
    //        {
    //            objComboBox = (ComboBox)sender;

    //            if (objComboBox.SelectedIndex <= 0)
    //            {
    //                mstrbldrErrors.Append("No label has been selected");
    //                lblLabelError.Text = "X";
    //            }
    //            else
    //                lblLabelError.Text = string.Empty;
    //        }
    //    }
    //}

    public partial class frmPrintLabel : Form
    {
        private Item mobjItem { get; set; }
        private BillOfLading mobjBOL { get; set; }
        private BindingList<CustomerAddress> mobjCustomerAddressList { get; set; }
        private int mintCustomerNumber { get; set; }
        private string mstrCustomerName { get; set; }
        private WTFClassLibrary.Label mobjSelectedLabel { get; set; }
        private int mintSelectedAddressIndex { get; set; }
        private StringBuilder mstrbldrErrors = new StringBuilder();
        public BackgroundWorker bw;


        public frmPrintLabel(Item objItem, BillOfLading objBOL)
        {
            int intTemp = 0;


            InitializeComponent();

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            mobjItem = objItem;
            mobjBOL = objBOL;

            if (int.TryParse(mobjItem.SelectedOrder.CustomerNumber, out intTemp))
                mintCustomerNumber = intTemp;
            else if (int.TryParse(mobjItem.SelectedJob.CustomerNumber, out intTemp))
                mintCustomerNumber = intTemp;

            mstrCustomerName = mobjItem.SelectedJob.CustomerName;

            mobjSelectedLabel = new WTFClassLibrary.Label();

            grpMultiple.Enabled = false;
            chkMultiple.Checked = false;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            LabelFormatDocument format = null; // The currently open Format
            Messages messages;
            //int waitForCompletionTimeout = 10000; // 10 seconds
            Result result;
            string strLabelFile;


            using (Engine engine = new Engine())
            {
                engine.Start();
                strLabelFile = Settings.GetLabelPath() + mobjSelectedLabel.LabelFile;
                //strLabelFile = Settings.GetLabelPath() + "John_Deere.btw";

                format = engine.Documents.Open(strLabelFile);

                if (chkMultiple.Checked)
                {
                    if (format.PrintSetup.SupportsIdenticalCopies)
                    {
                        //format.SubStrings["Print Count"].Value = int.Parse(txtQty.Text);
                        format.PrintSetup.IdenticalCopiesOfLabel = int.Parse(udCopies.Value.ToString());
                    }
                    if (format.PrintSetup.SupportsSerializedLabels)
                    {
                        /*For the below to work, you need to define serialization on the transforms tab of the barcode properties in Bartender*/
                        //format.SubStrings["Duplicate Count"].Value = udCopies.Value;
                        format.PrintSetup.NumberOfSerializedLabels = int.Parse(txtQty.Text);
                    }
                }
                else
                {
                    mobjItem.LabelSequence = mobjSelectedLabel.GetNextSequence();
                    try{ format.SubStrings["customerlabel.Sequence"].Value = mobjItem.LabelSequence.ToString(); }catch{}
                }

                foreach (var objSubString in format.SubStrings)
                {
                    switch (objSubString.Name)
                    {
                        /*I had to make all the text uppercase on "item.Item" or else barcoded labels in bartender wouldn't recognize the text
                         UPDATED - made "item.Item" uppercase by using the bartender software instead of code here*/
                        case "item.Item":
                            format.SubStrings[objSubString.Name].Value = mobjItem.ItemID.Trim();
                            break;
                        case "item.Description":
                            format.SubStrings[objSubString.Name].Value = mobjItem.Description.Trim();
                            break;
                        case "item.DrawingNmbr":
                            format.SubStrings[objSubString.Name].Value = mobjItem.DrawingNumber.Trim();
                            break;
                        case "item.ShippingAppItemNo":
                            format.SubStrings[objSubString.Name].Value = mobjItem.ShippingAppItemNo.Trim();
                            break;
                        case "item.Revision":
                            format.SubStrings[objSubString.Name].Value = mobjItem.Revision.Trim();
                            break;
                        case "co.MfgOrder":
                            format.SubStrings[objSubString.Name].Value = mobjItem.SelectedOrder.CustomerOrderNumber.Trim() + mobjItem.SelectedJob.JobNumber.Trim();
                            break;
                        case "co.Order":
                            format.SubStrings[objSubString.Name].Value = mobjItem.SelectedOrder.CustomerOrderNumber.Trim();
                            break;
                        case "co.CustPartNo":
                            format.SubStrings[objSubString.Name].Value = mobjItem.CustomerItem.Trim(); //.Replace("#", "")
                            break;
                        case "co.Supplier":
                            format.SubStrings[objSubString.Name].Value = txtSupplier.Text.Trim();
                            break;
                        case "co.CustNo":
                            format.SubStrings[objSubString.Name].Value = txtCustomer.Text;
                            break;
                        case "co.CustPO":
                            format.SubStrings[objSubString.Name].Value = mobjItem.SelectedOrder.CustomerPO.Trim();
                            break;
                        case "bol.GrossWeight":
                            format.SubStrings[objSubString.Name].Value = mobjBOL.GrossWeight.ToString();
                            break;
                        case "bol.TareWeight":
                            format.SubStrings[objSubString.Name].Value = mobjBOL.TareWeight.ToString();
                            break;
                        case "bol.NetWeight":
                            format.SubStrings[objSubString.Name].Value = mobjBOL.NetWeight.ToString();
                            break;
                        case "bol.PieceCt":
                            format.SubStrings[objSubString.Name].Value = mobjBOL.Quantity.ToString();
                            break;
                        case "bol.AvgPcWeight":
                            format.SubStrings[objSubString.Name].Value = mobjBOL.AveragePieceWeight.ToString("F3");
                            break;
                        case "bol.Cartons":
                            format.SubStrings[objSubString.Name].Value = txtCartons.Text.Trim();
                            break;
                        case "customeraddress.Address":
                            format.SubStrings[objSubString.Name].Value = txtAddress.Text.Trim();
                            break;
                    }
                }

                format.PrintSetup.PrinterName = e.Argument.GetValueFromAnonymousType<string>("PrinterName");

                //result = format.Print("WTF Shipping Application", waitForCompletionTimeout, out messages);
                result = format.Print("WTF Shipping Application", out messages);
                string messageString = "\n\nMessages:";
                foreach (Seagull.BarTender.Print.Message message in messages)
                    messageString += "\n\n" + message.Text;

                if (result == Result.Failure)
                    throw new Exception(messageString);
                else
                    e.Result = messageString;
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true)){}
            else if (e.Error != null)
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                btnCancel.Text = "Finish";
                //MessageBox.Show(e.Result.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadLabelFormatsList()
        {
            ExtraSytelineTablesSettings objExtraSytelineTableSettings;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter;
            SqlCommand objSQLCommand;
            WTFClassLibrary.Label objLabel;
            string strSQL;
            long lngTemp;
            int intTemp;


            objExtraSytelineTableSettings = new ExtraSytelineTablesSettings();

            strSQL = QueryDefinitions.GetQuery("SelectCustomerLabels", new string[] { mintCustomerNumber.ToString() });
            objExtraSytelineTableSettings.SQLConnection.Open();
            objSQLCommand = objExtraSytelineTableSettings.SQLConnection.CreateCommand();
            objSQLCommand.CommandText = strSQL;
            objDataAdapter = new SqlDataAdapter(objSQLCommand);
            objDataAdapter.Fill(objDataTable);

            cboLabels.Items.Clear();

            objLabel = new WTFClassLibrary.Label();
            objLabel.Description = "--- Select Label Format ---";

            cboLabels.Items.Add(objLabel);

            foreach (DataRow objRow in objDataTable.Rows)
            {
                objLabel = new WTFClassLibrary.Label();

                if (long.TryParse(objRow["CustomerLabelID"].ToString(), out lngTemp))
                    objLabel.CustomerLabelID = lngTemp;
                else
                    objLabel.CustomerLabelID = 0;

                if (int.TryParse(objRow["AddrLineCt"].ToString(), out intTemp))
                    objLabel.AddressLineCount = intTemp;
                else
                    objLabel.AddressLineCount = 0;

                objLabel.Description = objRow["Description"].ToString();
                objLabel.LabelFile = objRow["LabelFile"].ToString();
                objLabel.SupplierNumber = objRow["SupplierNumber"].ToString();

                if (long.TryParse(objRow["Sequence"].ToString(), out lngTemp))
                    objLabel.Sequence = lngTemp;
                else
                    objLabel.Sequence = 0;

                cboLabels.Items.Add(objLabel);
            }

            cboLabels.SelectedIndex = 0;
        }

        private void frmPrintLabel_Load(object sender, EventArgs e)
        {
            lblItem.Text = mobjItem.ItemID + " - " + mobjItem.Description;
            txtCustomer.Text = mintCustomerNumber.ToString();

            LoadLabelFormatsList();
            LoadPrinterList();

            if (mintCustomerNumber != 0)
                LoadCustomerAddresses();

        }

        private void LoadPrinterList()
        {
            Printers printers = new Printers();
            foreach (Printer printer in printers)
            {
                cboPrinters.Items.Add(printer.PrinterName);
            }
            if (printers.Count > 0)
            {
                // Automatically select the default printer.
                cboPrinters.SelectedItem = printers.Default.PrinterName;
            }
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
                objCustomerAddress.Country = objRow["Country"].ToString();

                mobjCustomerAddressList.Add(objCustomerAddress);
            }

            mintSelectedAddressIndex = -1;

            if (objDataTable.Rows.Count > 0)
            {
                SelectCustomerAddress(0);
                grpAddress.Enabled = (mobjSelectedLabel.AddressLineCount > 0);
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



            btnNextAddr.Enabled = intIndexNo < mobjCustomerAddressList.Count - 1 && mobjSelectedLabel.AddressLineCount > 0;
            btnPrevAddr.Enabled = intIndexNo > 0;
            lblAddrCt.Text = "Address " + (intIndexNo + 1).ToString() + " of " + mobjCustomerAddressList.Count;
            lblAddrCt.Refresh();
            txtAddress.Text = "";

            if (mobjSelectedLabel.AddressLineCount > 0)
            {
                objStrBldr = new StringBuilder();
                objCustomerAddress = mobjCustomerAddressList[intIndexNo];

                objStrBldr.Append(objCustomerAddress.Name);
                objStrBldr.Append(mobjSelectedLabel.AddressLineCount >= 3 && objCustomerAddress.AddressLine1.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine1 : string.Empty);
                objStrBldr.Append(mobjSelectedLabel.AddressLineCount >= 4 && objCustomerAddress.AddressLine2.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine2 : string.Empty);
                objStrBldr.Append(mobjSelectedLabel.AddressLineCount >= 5 && objCustomerAddress.AddressLine3.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine3 : string.Empty);
                objStrBldr.Append(mobjSelectedLabel.AddressLineCount == 6 && objCustomerAddress.AddressLine4.Length > 0 ? "\r\n" + objCustomerAddress.AddressLine4 : string.Empty);
                objStrBldr.Append("\r\n" + objCustomerAddress.City + ", " + objCustomerAddress.State + " " + objCustomerAddress.ZipCode + " " + objCustomerAddress.Country);

                txtAddress.Text = objStrBldr.ToString();
            }

            mintSelectedAddressIndex = intIndexNo;
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
                LoadLabelFormatsList();
            }
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            int intTemp = 0;


            switch (e.KeyCode)
            {
                case Keys.Return:
                    if (int.TryParse(txtCustomer.Text, out intTemp))
                    {
                        mintCustomerNumber = intTemp;
                        txtCustomer.Text = intTemp.ToString();
                        mintCustomerNumber = intTemp;
                        LoadCustomerAddresses();
                        LoadLabelFormatsList();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Customer Number");
                    }
                    break;
            }
        }

        private void cboLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            mobjSelectedLabel = cboLabels.SelectedItem as WTFClassLibrary.Label;

            if (cboLabels.SelectedIndex == 0 || mobjCustomerAddressList == null)
            {
                grpAddress.Enabled = false;
                lblAddrCt.Text = "";
            }
            else
            {
                txtSupplier.Text = mobjSelectedLabel.SupplierNumber;
                lblAddrLineCt.Text = "IMPORTANT:  Maximum number of address lines for the label is " + mobjSelectedLabel.AddressLineCount;
                txtAddress.Text = "";
                grpAddress.Enabled = (mobjSelectedLabel.AddressLineCount > 0);
                SelectCustomerAddress(mintSelectedAddressIndex);
            }
        }

        private void btnNextAddr_Click(object sender, EventArgs e)
        {
            SelectCustomerAddress(mintSelectedAddressIndex + 1);
        }

        private void btnPrevAddr_Click(object sender, EventArgs e)
        {
            SelectCustomerAddress(mintSelectedAddressIndex - 1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkMultiple_CheckedChanged(object sender, EventArgs e)
        {
            grpMultiple.Enabled = chkMultiple.Checked;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync(new { PrinterName = cboPrinters.SelectedItem.ToString() });
            }
            else
                MessageBox.Show("Wait for background process to finish.  Try again later.", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Validate(object sender, CancelEventArgs e)
        {
            int intTemp;
            TextBox objTextBox;
            ComboBox objComboBox;


            if (sender is TextBox)
            {
                objTextBox = (TextBox)sender;

                if (objTextBox.Text.Length == 0 || !int.TryParse(objTextBox.Text, out intTemp) || intTemp == 0)
                    switch (objTextBox.Name)
                    {
                        case "txtQty":
                            mstrbldrErrors.Append("Invalid Label Quantity");
                            lblQtyError.Text = "X";
                            break;
                    }
                else
                {
                    switch (objTextBox.Name)
                    {
                        case "txtQty":
                            lblQtyError.Text = string.Empty;
                            break;
                    }
                }
            }
            else if (sender is ComboBox)
            {
                objComboBox = (ComboBox)sender;

                if (objComboBox.SelectedIndex <= 0)
                {
                    mstrbldrErrors.Append("No label has been selected");
                    lblLabelError.Text = "X";
                }
                else
                    lblLabelError.Text = string.Empty;
            }
        }

        private void frmPrintLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
                btnPrint_Click(new object(), new EventArgs());
            else if (e.Control && e.KeyCode == Keys.C)
                btnCancel_Click(new object(), new EventArgs());
        }
    }
}
