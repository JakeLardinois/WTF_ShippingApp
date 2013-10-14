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
    /*The ShipVia field on the order MUST BE FILLED IN FOR THE ORDER LINES TO SHOW UP*/
    public partial class frmShipMultiple : Form
    {
        public Order mobjOrder { get; set; }
        public SortableSearchableBindingList<OrderLine> mobjOrderLines { get; set; }


        public frmShipMultiple()
        {
            InitializeComponent();
        }

        private void frmShipMultiple_Load(object sender, EventArgs e)
        {
            dgvOrderLines.AutoGenerateColumns = false;
            dgvOrderLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.WindowState = FormWindowState.Maximized;
        }

        private void txtOrderNum_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtOrderNum.ReadOnly = true;
                    Cursor.Current = Cursors.WaitCursor;
                    lblItemDescription.Text = "Searching for Order Lines...";
                    lblItemDescription.Refresh();


                    try
                    {
                        SetDefaults();
                        mobjOrder = new Order(txtOrderNum.Text.Trim());
                        mobjOrderLines = mobjOrder.OrderLines;
                        AddRemoveReleaseColumn();
                        SetDGVDatasource();

                        txtOrderNum.Text = mobjOrder.CustomerOrderNumber.Trim();
                        lblCustomer.Text = mobjOrder.CustomerName.Trim();
                        lblOrderDate.Text = mobjOrder.OrderDate.ToShortDateString();
                        lblOrderType.Text = mobjOrder.IsBlanketOrder ? "Blanket" : "Regular";
                    }
                    catch (Exception objEx)
                    {
                        MessageBox.Show(objEx.Message);
                        txtOrderNum.SelectAll();
                    }
                        

                    txtOrderNum.ReadOnly = false;
                    lblItemDescription.Text = string.Empty;
                    Cursor.Current = Cursors.Default;
                    break;
            }
        }

        private void SetDefaults()
        {
            mobjOrder = null;
            dgvOrderLines.DataSource = null;
            lblCustomer.Text = string.Empty;
            lblOrderDate.Text = string.Empty;
            lblOrderType.Text = string.Empty;
        }

        private void AddRemoveReleaseColumn()
        {
            if (mobjOrder != null)
                if (mobjOrder.IsBlanketOrder)
                {
                    DataGridViewTextBoxColumn objOrderReleaseColumn = new DataGridViewTextBoxColumn { HeaderText = "Release", Name = "txtOrderRelease", DataPropertyName = "CustomerOrderRelease" };
                    dgvOrderLines.Columns.Insert(2, objOrderReleaseColumn);
                }
                else
                    try { dgvOrderLines.Columns.Remove("txtOrderRelease"); }
                    catch { }
                    
        }

        private void SetDGVDatasource()
        {
            if (chkFilterLOrRStatus.Checked)
            {
                SortableSearchableBindingList<OrderLine> objList = new SortableSearchableBindingList<OrderLine>();


                var objQuery = mobjOrderLines.Where(o => o.LineOrReleaseStatus == "O").ToList();

                foreach (OrderLine objOrderLine in objQuery)
                    objList.Add(objOrderLine);

                dgvOrderLines.DataSource = objList;
            }
            else
                dgvOrderLines.DataSource = mobjOrderLines;
        }

        private void chkFilterLOrRStatus_CheckedChanged(object sender, EventArgs e)
        {
            SetDGVDatasource();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ShipOrderLine()
        {
            frmShipping objFrmShipping;
            OrderLine objOrderLine;


            if (dgvOrderLines.CurrentRow != null)
            {
                objFrmShipping = new frmShipping();
                objOrderLine = dgvOrderLines.CurrentRow.DataBoundItem as OrderLine;

                objFrmShipping.MdiParent = this.ParentForm;
                objFrmShipping.Show();
                objFrmShipping.txtItemNumber.Text = objOrderLine.ItemID;
                System.Windows.Forms.SendKeys.Send("{ENTER}");
            }
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            ShipOrderLine();
        }

        private void dgvOrderLines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShipOrderLine();
        }

        private void btnPackSlip_Click(object sender, EventArgs e)
        {
            frmPackingSlip objPackingSlipForm;


            if (mobjOrder != null)//I changed this implementation so that a packing slip could be created for -mfg items that are shipping to a plater.
            {                       //Under these circumstances the packing slip is created under the most recently filled order since there will not be an open order for a -mfg item
                objPackingSlipForm = new frmPackingSlip(mobjOrder);
                objPackingSlipForm.ShowDialog();
            }
            //if (mobjOrder != null)
            //    if (mobjOrderLines.Where(o => o.LineOrReleaseStatus == "O").ToList().Count >= 1)
            //    {
            //        objPackingSlipForm = new frmPackingSlip(mobjOrder);

            //        objPackingSlipForm.ShowDialog();
            //    }
            //    else
            //        if (mobjOrder.IsBlanketOrder)
            //            MessageBox.Show("Order " + mobjOrder.CustomerOrderNumber.Trim() + " does not have any open releases", "Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //        else
            //            MessageBox.Show("Order " + mobjOrder.CustomerOrderNumber.Trim() + "  does not have any open Lines", "Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            
        }

        private void btnBOL_Click(object sender, EventArgs e)
        {
            frmBOL objBOLForm;
            BillOfLading objBOL;


            objBOL = new BillOfLading();
            objBOLForm = new frmBOL(mobjOrder, objBOL);
            objBOLForm.ShowDialog();

        }
    }
}
