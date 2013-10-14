using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Printing;
using WTFClassLibrary;


namespace WTF_ShippingApp
{
    public partial class frmSelectPrinter : Form
    {
        public FormStatus FormsStatus { get; set; }
        public string SelectedPrinter { get; set; }
        public int NoOfCopies { get; set; }


        public frmSelectPrinter()
        {
            InitializeComponent();
        }

        private void frmSelectPrinter_Load(object sender, EventArgs e)
        {
            StringBuilder objStringBuilder = new StringBuilder();
            PrinterSettings objPrinterSettings;


            objPrinterSettings = new PrinterSettings();
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                objStringBuilder.Append(PrinterSettings.InstalledPrinters[i]);
                cmbInstalledPrinters.Items.Add(objStringBuilder.ToString());
                objStringBuilder.Clear();
            }

            if (cmbInstalledPrinters.Items.Count > 0)
                cmbInstalledPrinters.SelectedIndex = cmbInstalledPrinters.FindString(objPrinterSettings.PrinterName);//sets it to default printer
            else
            {
                MessageBox.Show("No Installed Printers!", "Installed Printers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedPrinter = cmbInstalledPrinters.Text;
            NoOfCopies = 1;
            FormsStatus = FormStatus.Succeeded;
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormsStatus = FormStatus.Cancelled;
            this.Dispose();
        }
    }
}
