using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WTFClassLibrary;
using System.Data.Linq;


namespace WTF_ShippingApp
{
    public partial class frmCustomerLabels : Form
    {
        private StringBuilder mstrbldrErrors = new StringBuilder();
        SL8DbDataContext objDB;


        public frmCustomerLabels()
        {
            ToolTip objToolTip = new ToolTip();


            InitializeComponent();

            objToolTip.SetToolTip(txtCustomerNo, "0 displays labels that show for ALL Customers");
            objDB = new SL8DbDataContext();
            customerLabelBindingSource.DataSource = objDB.CustomerLabels;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objDB.SubmitChanges();
        }

        private void txtCustomerNo_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ApplyFilter();
                    break;
            }
        }

        private void ApplyFilter()
        {
            mstrbldrErrors.Clear();
            this.ValidateChildren();
            if (mstrbldrErrors.Length > 0)
                return;

            if (txtCustomerNo.Text.Length == 0)
                customerLabelBindingSource.DataSource = objDB.CustomerLabels;
            else
                customerLabelBindingSource.DataSource = objDB.CustomerLabels.Where(l => l.cust_num == double.Parse(txtCustomerNo.Text));
        }

        private void ValidateTextBoxIsNumeric(object sender, CancelEventArgs e)
        {
            double dblTemp;
            TextBox objTextBox;


            if (sender is TextBox)
            {
                objTextBox = (TextBox)sender;


                if (!double.TryParse(objTextBox.Text, out dblTemp))
                    switch (objTextBox.Name)
                    {
                        case "txtCustomerNo":
                            mstrbldrErrors.Append("Invalid Customer Number");
                            lblCustomerNumberError.Text = "X";
                            break;
                    }
                else
                    switch (objTextBox.Name)
                    {
                        case "txtCustomerNo":
                            lblCustomerNumberError.Text = string.Empty;
                            break;
                    }
            }
        }

        private void frmCustomerLabels_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeSet objChangeSet = objDB.GetChangeSet();

            if (objChangeSet.Deletes.Count > 0 || objChangeSet.Inserts.Count > 0 || objChangeSet.Updates.Count > 0)
                if ((MessageBox.Show("Do You want to save your changes?", "Save Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    objDB.SubmitChanges();
        }

        private void frmCustomerLabels_Load(object sender, EventArgs e)
        {
            dgvCustomerLabels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
