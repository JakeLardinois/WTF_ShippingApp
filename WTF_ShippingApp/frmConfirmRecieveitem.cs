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
    public partial class frmConfirmRecieveitem : Form
    {
        public FormStatus FormsStatus { get; set; }
        private Item mobjItem { get; set; }
        private BillOfLading mobjBOL { get; set; }
        private StringBuilder mstrbldrErrors = new StringBuilder();


        public frmConfirmRecieveitem( Item objItem, BillOfLading objBOL )
        {
            InitializeComponent();

            mobjItem = objItem;
            mobjBOL = objBOL;
        }

        private void frmConfirmRecieveitem_Load(object sender, EventArgs e)
        {
            lblItem.Text = mobjItem.ItemID + " - " + mobjItem.Description;
            txtOrder.Text = mobjItem.SelectedOrder.CustomerOrderNumber.Trim();
            txtJob.Text = mobjItem.SelectedJob.JobNumber;
            lblQty.Text = mobjBOL.Quantity.ToString("###,##0");
        }

        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            double dblTemp;
            TextBox objTextBox;


            if (sender is TextBox)
            {
                objTextBox = (TextBox)sender;

                switch (objTextBox.Name)
                {
                    case "txtPalletCt":
                        if (!double.TryParse(objTextBox.Text, out dblTemp))
                        {
                            mstrbldrErrors.Append("Invalid Entry, Pallet Count must be Numeric");
                            lblPalletCtError.Text = "X";
                        }
                        else if (dblTemp <= 0 || dblTemp >= 99999)
                        {
                            mstrbldrErrors.Append("Invalid Quantity, Pallet Count must be > 0 and < 100,000");
                            lblPalletCtError.Text = "X";
                        }
                        else
                            lblPalletCtError.Text = string.Empty;
                        break;
                    case "txtOrder":
                        if (objTextBox.Text.Trim().Length == 0)
                        {
                            mstrbldrErrors.Append("Order # is required!");
                            lblOrderError.Text = "X";
                        }
                        else
                            lblOrderError.Text = string.Empty;
                        break;
                    case "txtInitials":
                        if (objTextBox.Text.Trim().Length == 0)
                        {
                            mstrbldrErrors.Append("Initials are required!");
                            lblInitialsError.Text = "X";
                        }
                        else
                            lblInitialsError.Text = string.Empty;
                        break;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            mobjBOL.PalletCount = int.Parse(txtPalletCt.Text);

            try
            {
                if (mobjItem.Recieve(mobjBOL.Quantity, txtInitials.Text))
                    if (mobjItem.AddToReceiveHistory(mobjBOL, txtInitials.Text))
                    {
                        mobjItem.LabelSequence = 0;
                        FormsStatus = FormStatus.Succeeded;
                    }
                    else
                        FormsStatus = FormStatus.Failed;
            }
            catch (Exception objEx)
            {
                FormsStatus = FormStatus.Errored;
                MessageBox.Show(objEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormsStatus = FormStatus.Cancelled;
            this.Dispose();
        }

    }
}

