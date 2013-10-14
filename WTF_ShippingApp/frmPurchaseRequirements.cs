using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;
using System.IO;


namespace WTF_ShippingApp
{
    public partial class frmPurchaseRequirements : Form
    {
        public PurchasedItemList PurchasedItemList { get; set; }
        private BindingSource bs1 = new BindingSource();
        private BindingSource bs2 = new BindingSource();
        private BindingSource bs3 = new BindingSource();
        private System.Drawing.Printing.PrintDocument objPrintDocument;
        public BackgroundWorker bw;


        public frmPurchaseRequirements()
        {
            InitializeComponent();

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            picLoading.BringToFront();
            picLoading.Visible = true;
            bw.RunWorkerAsync();

            objPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.objPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.objPrintDocument_PrintPage);
        }

        private void frmTimePhasedInventory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dgvRequirements.AutoGenerateColumns = false;
            dgvRequirements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequirements.Columns["txtProjectedOnHandColumn"].DefaultCellStyle.Format = "N2";
            dgvRequirements.Columns["txtOutstandingRequirementColumn"].DefaultCellStyle.Format = "N2";
            dgvRequirements.Columns["txtOutstandingRecieptColumn"].DefaultCellStyle.Format = "N2";
            dgvRequirements.Columns["txtDueDateColumn"].DefaultCellStyle.Format = "d";

            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Purchased Item", Value = "PurchasedItem" });
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Status (O or R)", Value = "Status" });
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Shortfalls (Y or N)", Value = "OperationID" });
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Purchase Order", Value = "PurchaseOrder" });
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Manufactured Item", Value = "ItemID" });
            cboSortSearch.SelectedIndex = 0;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            PurchasedItemList = new PurchasedItemList();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                picLoading.Visible = false;
            }
            else if (!(e.Error == null))
            {
                picLoading.Visible = false;
            }
            else
            {
                BindData();
                picLoading.Visible = false;
            }
        }

        private void BindData()
        {
            bs1.DataSource = PurchasedItemList;
            bs2.DataSource = bs1;
            bs2.DataMember = "RepletionsAndDepletions";

            lstItems.DataSource = bs1;
            dgvRequirements.DataSource = bs2;

            lblItemID.DataBindings.Add("Text", bs1, "ItemID");
            lblDescription.DataBindings.Add("Text", bs1, "ItemDescription");
            lblQtyOnHand.DataBindings.Add("Text", bs1, "QtyOnHand");
            lblQtyOnHand.DataBindings[0].Format += new ConvertEventHandler(lblQtyOnHand_Format);
            lblUnitOfMeasure.DataBindings.Add("Text", bs1, "UnitOfMeasure");
            //lblNetQtyRequired.DataBindings.Add("Text", bs1, "NetQtyRequired");
            //lblNetQtyRequired.DataBindings[0].Format += new ConvertEventHandler(lblQtyOnHand_Format);

        }

        private void lblQtyOnHand_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                e.Value = ((decimal)e.Value).ToString("N2");
            }
            catch { }
        }

        private void WriteDocument()
        {
            StreamWriter objStreamWriter;
            string strFileNameAndPath = Directory.GetCurrentDirectory() + "\\PurchaseRequirements.txt";
            string strReportText;


            strReportText = GetReportText();
            objStreamWriter = new StreamWriter(strFileNameAndPath);
            objStreamWriter.Write(strReportText);
            objStreamWriter.Close();
            System.Diagnostics.Process.Start(strFileNameAndPath);
        }

        private void PrintDocument()
        {
            frmSelectPrinter objSelectPrinter = new frmSelectPrinter();

            objSelectPrinter.ShowDialog();

            if (objSelectPrinter.FormsStatus == FormStatus.Succeeded)
            {
                objPrintDocument.PrinterSettings.PrinterName = objSelectPrinter.SelectedPrinter;
                objPrintDocument.DefaultPageSettings.Landscape = true;
                objPrintDocument.PrinterSettings.Copies = (short)objSelectPrinter.NoOfCopies; // short.Parse(objSelectPrinter.NoOfCopies.ToString());
                objPrintDocument.Print();
            }
        }

        private string GetReportText()
        {
            StringBuilder objStringBuilder = new StringBuilder();
            string strHeader = "Purchase Requirmements";
            TimePhasedItem objPurchasedItem;

            objStringBuilder.Append(strHeader + Environment.NewLine + Environment.NewLine);
            foreach (var objItem in lstItems.CheckedItems)
            {
                objPurchasedItem = objItem as TimePhasedItem;

                objStringBuilder.Append(objPurchasedItem.ItemID + Environment.NewLine);
                objStringBuilder.Append(String.Format("\t{0,8}{1,10}{2,10}{3,10}  {4,-15}{5,-20}{6,-25}" + Environment.NewLine,
                            "DueDate", "OnHand", "Req", "Rec", "WC", "Item", "Data"));

                foreach (var objRepletionDepletionItem in objPurchasedItem.RepletionsAndDepletions)
                {
                    objStringBuilder.Append(String.Format("\t{0,8:MM/dd}{1,10:F1}{2,10:F1}{3,10:F1}  {4,-15}{5,-20}{6,-25}" + Environment.NewLine,
                        objRepletionDepletionItem.DueDate, objRepletionDepletionItem.ProjectedOnHand, objRepletionDepletionItem.OutstandingRequirement,
                        objRepletionDepletionItem.OutstandingReciept, objRepletionDepletionItem.WorkCenter, objRepletionDepletionItem.ItemID, objRepletionDepletionItem.ReferenceData));

                }
                objStringBuilder.Append(Environment.NewLine);
            }

            return objStringBuilder.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            WriteDocument();
        }

        private void objPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strFontName = "Arial";
            string strReportText;


            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font(strFontName, 8))
                {
                    strReportText = GetReportText();
                    g.DrawString(strReportText, fnt, System.Drawing.Brushes.Black, 0, 0);
                }
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            IEnumerable<TimePhasedItem> objQuery;

            if (PurchasedItemList == null)
                return;

            switch (cboSortSearch.SelectedIndex)
            {
                case 0:
                    objQuery = PurchasedItemList
                        .Where(i => i.ItemID.ToUpper().Contains(txtSearch.Text.ToUpper()))
                        .ToList();
                    break;
                case 1:
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                        objQuery = PurchasedItemList
                            .Where(i => i.RepletionsAndDepletions.Any(s => !string.IsNullOrEmpty(s.Status) && s.Status.Equals(txtSearch.Text.ToUpper())))
                            .ToList();
                    else
                        objQuery = PurchasedItemList;
                    break;
                case 2:
                    if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.ToUpper().Contains('Y'))
                        objQuery = PurchasedItemList
                            .Where(i => i.RepletionsAndDepletions.Any(q => q.ProjectedOnHand < 0))
                            .ToList();
                    else if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.ToUpper().Contains('N'))
                        objQuery = PurchasedItemList
                            .Where(i => i.RepletionsAndDepletions.All(q => q.ProjectedOnHand > 0))
                            .ToList();
                    else
                        objQuery = PurchasedItemList;
                    break;
                case 3:
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                        objQuery = PurchasedItemList
                            .Where(i => i.RepletionsAndDepletions.Any(s => !string.IsNullOrEmpty(s.Status) &&
                                s.Status.Equals("O"))) //check for Ordered Items
                            .Where(i => i.RepletionsAndDepletions.Any(s => !string.IsNullOrEmpty(s.ReferenceData) &&
                                s.ReferenceData.ToUpper().Contains(txtSearch.Text.ToUpper())))
                            .ToList();
                    else
                        objQuery = PurchasedItemList;
                    break;
                case 4:
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                        objQuery = PurchasedItemList
                            .Where(i => i.RepletionsAndDepletions.Any(s => !string.IsNullOrEmpty(s.ItemID) &&
                                s.ItemID.ToUpper().Contains((txtSearch.Text.ToUpper()))))
                            .ToList();
                    else
                        objQuery = PurchasedItemList;
                    break;
                default:
                    objQuery = PurchasedItemList;
                    break;
            }

            bs1.DataSource = new SortableBindingList<TimePhasedItem>(objQuery);
        }

        private void cmiCheckAll_Click(object sender, EventArgs e)
        {
            SetChecks(true);
        }

        private void cmiUncheckAll_Click(object sender, EventArgs e)
        {
            SetChecks(false);
        }

        private void SetChecks(bool blnCheckState)
        {
            for (int i = 0; i < lstItems.Items.Count; i++)
                lstItems.SetItemChecked(i, blnCheckState);
        }

    }
}
