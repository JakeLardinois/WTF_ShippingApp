using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;
using Seagull.BarTender.Print;


namespace WTF_ShippingApp
{
    public partial class frmQuickLabelPrinter : Form
    {
        private List<TabPage> TabPages { get; set; }
        public int mintCustomerOrVendorNumber { get; set; }
        private int mintSelectedAddressIndex { get; set; }
        private BindingList<CustomerAddress> mobjCustomerAddressList { get; set; }
        private BindingList<VendorAddress> mobjVendorAddressList { get; set; }
        private const string CUSTOMERVALUE = "Customer";
        private const string VENDORVALUE = "Vendor";
        public BackgroundWorker bw;


        public frmQuickLabelPrinter()
        {
            InitializeComponent();

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            LabelFormatDocument format = null; // The currently open Format
            Messages messages;
            //int waitForCompletionTimeout = 10000; // 10 seconds
            Result result;
            string strData, strLabelPathAndName;


            using (Engine engine = new Engine())
            {
                engine.Start();
                //strLabelFile = Settings.GetLabelPath() + mobjSelectedLabel.LabelFile;
                strData = e.Argument.GetValueFromAnonymousType<string>("Data");
                strLabelPathAndName = e.Argument.GetValueFromAnonymousType<string>("LabelPathAndName");

                format = engine.Documents.Open(strLabelPathAndName);
                if (format.PrintSetup.SupportsIdenticalCopies)
                {
                    format.PrintSetup.IdenticalCopiesOfLabel = int.Parse(nudQuantity.Value.ToString());
                }
                foreach (var objSubString in format.SubStrings)
                {
                    switch (objSubString.Name)
                    {
                        case "Text":
                            format.SubStrings[objSubString.Name].Value = strData;
                            break;
                        case "Address":
                            format.SubStrings[objSubString.Name].Value = strData;
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
            if ((e.Cancelled == true)) { }
            else if (e.Error != null)
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //    MessageBox.Show(e.Result.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmQuickLabelPrinter_Load(object sender, EventArgs e)
        {
            TabPages = new List<TabPage>();
            foreach (TabPage objTabPage in tabForms.TabPages)
            {
                TabPages.Add(objTabPage);
                cmbLabelType.Items.Add(objTabPage.Text);
            }
            
            cmbLabelType.SelectedIndex = 0;
            cmbAddressType.Items.AddRange(new object[] { 
                new ComboBoxItem { Text = "Customer Address", Value = CUSTOMERVALUE }, 
                new ComboBoxItem { Text = "Vendor Address", Value = VENDORVALUE }});
            cmbAddressType.SelectedIndex = 0;
            GetSelectedTabPage();
            LoadPrinterList();
            this.WindowState = FormWindowState.Maximized;
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

        private void GetSelectedTabPage()
        {
            tabForms.TabPages.Clear();
            tabForms.TabPages.Add(TabPages[cmbLabelType.SelectedIndex]);
        }

        private void cmbLabelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedTabPage();
        }

        private void LoadCustomerAddresses()
        {
            mobjCustomerAddressList = CustomerAddress.Search(mintCustomerOrVendorNumber.ToString());

            mintSelectedAddressIndex = -1;

            if (mobjCustomerAddressList.Count > 0)
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

        private void LoadVendorAddresses()
        {
            mobjVendorAddressList = VendorAddress.Search(mintCustomerOrVendorNumber.ToString());

            mintSelectedAddressIndex = -1;

            if (mobjVendorAddressList.Count > 0)
            {
                SelectVendorAddress(0);
                grpAddress.Enabled = true;
            }
            else
            {
                MessageBox.Show("No addresses found for Vendor!", "No Addresses Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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

        private void SelectVendorAddress(int intIndexNo)
        {
            VendorAddress objVendorAddress;


            btnNextAddr.Enabled = intIndexNo < mobjVendorAddressList.Count - 1;
            btnPrevAddr.Enabled = intIndexNo > 0;
            lblAddrCt.Text = "Address " + (intIndexNo + 1).ToString() + " of " + mobjVendorAddressList.Count;
            lblAddrCt.Refresh();
            txtAddress.Text = "";

            objVendorAddress = mobjVendorAddressList[intIndexNo];

            txtAddress.Text = objVendorAddress.ToString();

            mintSelectedAddressIndex = intIndexNo;
        }

        private void txtNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    try
                    {
                        if (!string.IsNullOrEmpty(txtNo.Text))
                        {
                            switch (((ComboBoxItem)cmbAddressType.SelectedItem).Value)
                            {
                                case CUSTOMERVALUE:
                                    var objCustomerAddress = new CustomerAddress(txtNo.Text);
                                    mintCustomerOrVendorNumber = int.Parse(objCustomerAddress.CustomerNumber);
                                    LoadCustomerAddresses();
                                    break;
                                case VENDORVALUE:
                                    var objVendorAddress = new VendorAddress(txtNo.Text);
                                    mintCustomerOrVendorNumber = int.Parse(objVendorAddress.VendorNumber);
                                    LoadVendorAddresses();
                                    break;
                            }

                            txtNo.Text = mintCustomerOrVendorNumber.ToString();
                        }
                    }
                    catch
                    {
                        switch (((ComboBoxItem)cmbAddressType.SelectedItem).Value)
                        {
                            case CUSTOMERVALUE:
                                MessageBox.Show("Customer " + txtNo.Text + " Not Found", "No Customer Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                break;
                            case VENDORVALUE:
                                MessageBox.Show("Vendor " + txtNo.Text + " Not Found", "No Vendor Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                break;
                        }
                        
                    }
                    break;
            }
        }

        private void cmbAddressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyEventArgs objKeyEventArgs = new KeyEventArgs(Keys.Enter);

            txtNo_KeyDown(sender, objKeyEventArgs);
            lblNo.Text = ((ComboBoxItem)cmbAddressType.SelectedItem).Value.ToString() + ":";
        }

        private void btnNextAddr_Click(object sender, EventArgs e)
        {
            switch (((ComboBoxItem)cmbAddressType.SelectedItem).Value)
            {
                case CUSTOMERVALUE:
                    SelectCustomerAddress(mintSelectedAddressIndex + 1);
                    break;
                case VENDORVALUE:
                    SelectVendorAddress(mintSelectedAddressIndex + 1);
                    break;
            }
        }

        private void btnPrevAddr_Click(object sender, EventArgs e)
        {
            switch (((ComboBoxItem)cmbAddressType.SelectedItem).Value)
            {
                case CUSTOMERVALUE:
                    SelectCustomerAddress(mintSelectedAddressIndex - 1);
                    break;
                case VENDORVALUE:
                    SelectVendorAddress(mintSelectedAddressIndex - 1);
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int intTemp;


            switch (((ComboBoxItem)cmbAddressType.SelectedItem).Value)
            {
                case CUSTOMERVALUE:
                    frmCustomers objCustomersForm;


                    objCustomersForm = new frmCustomers(txtNo.Text);
                    objCustomersForm.ShowDialog();

                    if (objCustomersForm.SelectedCustomerAddress != null)
                    {
                        txtNo.Text = objCustomersForm.SelectedCustomerAddress.CustomerNumber;

                        if (int.TryParse(objCustomersForm.SelectedCustomerAddress.CustomerNumber, out intTemp))
                            mintCustomerOrVendorNumber = intTemp;
                        LoadCustomerAddresses();
                    }
                    break;
                case VENDORVALUE:
                    frmVendors objVendorsForm;


                    objVendorsForm = new frmVendors(txtNo.Text);
                    objVendorsForm.ShowDialog();

                    if (objVendorsForm.SelectedVendorAddress != null)
                    {
                        txtNo.Text = objVendorsForm.SelectedVendorAddress.VendorNumber;

                        if (int.TryParse(objVendorsForm.SelectedVendorAddress.VendorNumber, out intTemp))
                            mintCustomerOrVendorNumber = intTemp;
                        LoadVendorAddresses();
                    }
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy != true)
            {
                switch (tabForms.TabPages[0].Name)
                {
                    case "tabKanBan":
                        bw.RunWorkerAsync(new { PrinterName = cboPrinters.SelectedItem.ToString(), LabelPathAndName = Settings.GetLabelPath() + txtKanBanLabelName.Text,
                            Data = txtLabelText.Text });
                        break;
                    case "tabAddress":
                        bw.RunWorkerAsync(new { PrinterName = cboPrinters.SelectedItem.ToString(), LabelPathAndName = Settings.GetLabelPath() + txtAddressLabelName.Text,
                            Data = txtAddress.Text });
                        break;
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("Wait for background process to finish.  Try again later.", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    LabelVision.Application objLabelVisionApp;
        //    LabelVision.Label objLabelVisionLabel;
        //    string strLabelFile;


            
        //    try
        //    {
        //        objLabelVisionApp = new LabelVision.Application();

        //        switch (tabForms.TabPages[0].Name)
        //        {
        //            case "tabKanBan":
        //                strLabelFile = Settings.GetLabelPath() + txtKanBanLabelName.Text;
        //                objLabelVisionLabel = objLabelVisionApp.OpenLabel(strLabelFile);
        //                objLabelVisionLabel.LabelFields["Text"].Value = txtLabelText.Text;
        //                break;
        //            case "tabAddress":
        //                strLabelFile = Settings.GetLabelPath() + txtAddressLabelName.Text;
        //                objLabelVisionLabel = objLabelVisionApp.OpenLabel(strLabelFile);
        //                objLabelVisionLabel.LabelFields["Address"].Value = txtAddress.Text;
        //                break;
        //            default:
        //                objLabelVisionLabel = objLabelVisionApp.OpenLabel(string.Empty);
        //                break;
        //        }
        //        objLabelVisionLabel.BuiltInFields["Print Count"].Value = nudQuantity.Value;
        //        objLabelVisionLabel.PrintOut(true, true);
        //        objLabelVisionLabel.Close();
        //        objLabelVisionApp.Quit();
        //    }
        //    catch(Exception objEx)
        //    {
        //        MessageBox.Show("Error during label preparation: " + objEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        //    }
            
            
        //}
    }
}
