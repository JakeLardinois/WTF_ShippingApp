using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;
using Microsoft.Reporting.WinForms;

namespace WTF_ShippingApp
{
    public partial class frmItemHistory : Form
    {
        private Item mobjItem { get; set; }
        private CheckBox HeaderCheckBox { get; set; }
        private bool IsHeaderCheckBoxClicked { get; set; }
        private int TotalCheckBoxes { get; set; }
        private int TotalCheckedCheckBoxes { get; set; }
        private StringBuilder mstrbldrReportType = new StringBuilder();
        private bool mblnIsShipping { get; set; }//I added this so I can only show a particular job when the user is shipping an item.
        private int SelectedTotal { get; set; }//I added this so that I could count the total of the selected items
        public List<ItemHistoryTransaction> SelectedItemHistoryJobs { get; set; }
        public FormStatus FormStatus { get; set; }


        public frmItemHistory(Item objItem, bool blnIsShipping = false)//needs to be false by default
        {
            InitializeComponent();

            mobjItem = objItem;
            mblnIsShipping = blnIsShipping;
        }

        private void frmItemHistory_Load(object sender, EventArgs e)
        {
            dgvItemHistory.AutoGenerateColumns = false;
            dgvItemHistory.MultiSelect = true;
            dgvItemHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AddHeaderCheckBox();

            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvItemHistory.CellValueChanged += new DataGridViewCellEventHandler(dgvSelectAll_CellValueChanged);
            dgvItemHistory.CurrentCellDirtyStateChanged += new EventHandler(dgvSelectAll_CurrentCellDirtyStateChanged);
            dgvItemHistory.CellPainting += new DataGridViewCellPaintingEventHandler(dgvSelectAll_CellPainting);

            optReceiving.Checked = true;
            SetDefaults();
            if (mblnIsShipping)
            {
                pnlFilter.Visible = false;
                //btnPrint.Visible = false;
                btnFinish.Text = "Finish";
            }
        }

        private void SetDefaults()
        {
            lblItem.Text = mobjItem.ItemID;
            lblItemDesc.Text = mobjItem.Description;
            //lblQuantity.Text = mobjItem.AvailableInventory == 0 ? "0" : mobjItem.AvailableInventory.ToString("#,##0.####");//I was getting an "input string in incorrect format" exception on the client (not development machine) when this returned a 0
            lblQuantity.Text = mobjItem.AvailableInventory.ToString("#,#;( #,# );**Zero**");
            lblLastReceived.Text = mobjItem.LastReceiveDate;
            lblLastShipped.Text = mobjItem.LastShipDate;
            lblQtySelected.Text = SelectedTotal.ToString("#,#;( #,# );**Zero**");
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton objRad = (RadioButton)sender;

                if (objRad.Checked)
                    switch (objRad.Name)
                    {
                        case "optAll":
                            dgvItemHistory.DataSource = mobjItem.GetHistory(ItemHistoryView.All);
                            TotalCheckBoxes = dgvItemHistory.RowCount;
                            TotalCheckedCheckBoxes = 0;
                            HeaderCheckBox.Checked = false;
                            SelectedTotal = 0;
                            mstrbldrReportType.Clear().Append("All Transactions");
                            //MessageBox.Show("Fired " + objRad.Name);
                            break;
                        case "optReceiving":
                            if (mblnIsShipping)//This check was implemented to accomodate filtering by job when shipping an item.
                            {
                                var objQuery = mobjItem.GetHistory(ItemHistoryView.Recieved)
                                    .Where(t => t.FormattedJobNumber.Equals(mobjItem.SelectedJob.FormattedJobNumber) && t.Suffix == mobjItem.SelectedJob.Suffix)
                                    .ToList();
                                var objItemHistoryList = new SortableSearchableBindingList<ItemHistoryTransaction>();//create a new sortablesearchablebindinglist
                                foreach (ItemHistoryTransaction objItemHistoryTransaction in objQuery)//add each filtered item to the binding list
                                    objItemHistoryList.Add(objItemHistoryTransaction);
                                dgvItemHistory.DataSource = objItemHistoryList;
                            }
                            else
                                dgvItemHistory.DataSource = mobjItem.GetHistory(ItemHistoryView.Recieved);
                            TotalCheckBoxes = dgvItemHistory.RowCount;
                            TotalCheckedCheckBoxes = 0;
                            HeaderCheckBox.Checked = false;
                            SelectedTotal = 0;
                            mstrbldrReportType.Clear().Append("Recieving Transactions");
                            //MessageBox.Show("Fired " + objRad.Name);
                            break;
                        case "optShipping":
                            dgvItemHistory.DataSource = mobjItem.GetHistory(ItemHistoryView.Shipped);
                            TotalCheckBoxes = dgvItemHistory.RowCount;
                            TotalCheckedCheckBoxes = 0;
                            HeaderCheckBox.Checked = false;
                            SelectedTotal = 0;
                            mstrbldrReportType.Clear().Append("Shipping Transactions");
                            //MessageBox.Show("Fired " + objRad.Name);
                            break;
                    }
            }
        }

        private void btnMarkAsShipped_Click(object sender, EventArgs e)
        {
            RadioButton objRad;
            string strMessage = string.Empty;
            int intCounter = 0;
            ItemHistoryTransaction objItemHistoryTransaction;

            if (MessageBox.Show("Mark selected items as shipped?\r\n\r\nWARNING!  You cannot undo this action!",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                return;
            
            foreach (DataGridViewRow objRow in dgvItemHistory.Rows)
            {
                objItemHistoryTransaction = objRow.DataBoundItem as ItemHistoryTransaction;

                if (objItemHistoryTransaction.isSelected)
                {
                    try
                    {
                        Item.ShipItemFromInventory(objItemHistoryTransaction);
                        strMessage += "Transaction " + objItemHistoryTransaction.RecievedItemID + " Successfully processed.\r\n";
                        ++intCounter;
                    }
                    catch(Exception objEx){ strMessage += objEx.Message + "\r\n"; }
                }
            }
            strMessage += "\r\n" + intCounter + " Transaction(s) were marked as shipped.";
            MessageBox.Show(strMessage);

            //Updates the view with the new values
            foreach (Control objControl in pnlFilter.Controls)
            {
                if (objControl is RadioButton)
                {
                    objRad = (RadioButton)objControl;

                    if (objRad.Checked)
                        RadioButton_CheckedChanged(objRad, null);
                }
            }
            SetDefaults();
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            //Add the CheckBox into the DataGridView
            dgvItemHistory.Controls.Add(HeaderCheckBox);
        }

        private void dgvSelectAll_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell objCheckBoxCell = (DataGridViewCheckBoxCell)dgvItemHistory[e.ColumnIndex, e.RowIndex];
            int intTemp;


            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClick(objCheckBoxCell);

            int.TryParse(dgvItemHistory["txtQuantity", e.RowIndex].Value.ToString(), out intTemp);
            if ((bool)objCheckBoxCell.Value)
                SelectedTotal += intTemp;
            else
                SelectedTotal -= intTemp;
            lblQtySelected.Text = SelectedTotal.ToString("#,#;( #,# );**Zero**");
        }

        private void dgvSelectAll_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvItemHistory.CurrentCell is DataGridViewCheckBoxCell)
                dgvItemHistory.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }

        private void dgvSelectAll_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dgvItemHistory.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chkbxIsSelected"]).Value = HCheckBox.Checked;

            dgvItemHistory.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
        }

        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {
                //Modifiy Counter;            
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                //Change state of the header CheckBox.
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = dgvItemHistory.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmItemHistoryReport objItemHistoryReport;
            LocalReport objLocalReport;
            ReportDataSource objItemHistoryDataSource;
            ReportParameter[] objParameterArray;


            objItemHistoryReport = new frmItemHistoryReport();
            objItemHistoryReport.rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            objItemHistoryReport.rptViewer.ShowDocumentMapButton = false;

            objLocalReport = objItemHistoryReport.rptViewer.LocalReport;
            objLocalReport.ReportPath = "ReportTemplates\\ItemHistory.rdlc";

            objItemHistoryReport.rptViewer.SetDisplayMode(DisplayMode.PrintLayout);

            objParameterArray = new ReportParameter[2];
            objParameterArray[0] = new ReportParameter("ItemDescription", mobjItem.Description);
            objParameterArray[1] = new ReportParameter("ReportType", mstrbldrReportType.ToString());
            objLocalReport.SetParameters(objParameterArray);

            objItemHistoryDataSource = new ReportDataSource("ItemHistory", dgvItemHistory.DataSource);
            objLocalReport.DataSources.Add(objItemHistoryDataSource);

            objItemHistoryReport.ShowDialog();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            ItemHistoryTransaction objItemHistoryTransaction;
            SelectedItemHistoryJobs = new List<ItemHistoryTransaction>();


            foreach (DataGridViewRow objRow in dgvItemHistory.Rows)
            {
                objItemHistoryTransaction = objRow.DataBoundItem as ItemHistoryTransaction;

                if (objItemHistoryTransaction.isSelected)
                {
                    SelectedItemHistoryJobs.Add(objItemHistoryTransaction);
                }
            }

            if (SelectedItemHistoryJobs.Count > 0)
                FormStatus = WTFClassLibrary.FormStatus.Succeeded;
            this.Dispose();
        }
    }
}
