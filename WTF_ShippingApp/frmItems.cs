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
using System.Text.RegularExpressions;


namespace WTF_ShippingApp
{
    public partial class frmItems : Form
    {
        private SortableSearchableBindingList<Item> mobjItemList { get; set; }
        public Item SelectedItem { get; set; }
        private const int MINTMAXRECORDCOUNT = 100;


        public frmItems(string strItemNumber)
        {
            InitializeComponent();

            txtItem.Text = strItemNumber.Trim();
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Item Number", Value = "item.item" });
            cboSortSearch.Items.Add(new ComboBoxItem { Text = "Item Description", Value = "item.description" });
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            dgvItems.AutoGenerateColumns = false;
            cboSortSearch.SelectedIndex = 0;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GetItems();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Item objItem;


            if (dgvItems.SelectedRows.Count == 0)
                MessageBox.Show("No item selected!", "Job", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                objItem = dgvItems.CurrentRow.DataBoundItem as Item;
                objItem.SetAvgUnitWeight();
                SelectedItem = objItem;
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GetItems()
        {
            SL8_WTF_DataBaseSettings objSL8_WTF_DataBaseSettings;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter;
            SqlCommand objSQLCommand;
            Item objItem;
            string strSQL;
            double dblTemp;
            Match objMFGMatch, objDashIntMatch;


            Cursor.Current = Cursors.WaitCursor;
            dgvItems.Visible = false;

            objSL8_WTF_DataBaseSettings = new SL8_WTF_DataBaseSettings();
            strSQL = QueryDefinitions.GetQuery("SelectTopNItems", new string[] { MINTMAXRECORDCOUNT.ToString(), 
                ((ComboBoxItem)cboSortSearch.SelectedItem).Value, txtItem.Text, ((ComboBoxItem)cboSortSearch.SelectedItem).Value });
            objSL8_WTF_DataBaseSettings.SQLConnection.Open();
            objSQLCommand = new SqlCommand(strSQL, objSL8_WTF_DataBaseSettings.SQLConnection);
            objDataAdapter = new SqlDataAdapter(objSQLCommand);
            objDataAdapter.Fill(objDataTable);

            mobjItemList = new SortableSearchableBindingList<Item>();

            if (objDataTable.Rows.Count > 0)
            {
                foreach (DataRow objRow in objDataTable.Rows)
                {
                    objItem = new Item();

                    objItem.ItemID = objRow["Item"].ToString();
                    objItem.Description = objRow["Description"].ToString();
                    objItem.Revision = objRow["revision"].ToString();
                    objItem.QtyOnHand = double.TryParse(objRow["qty_on_hand"].ToString(), out dblTemp) ? dblTemp : 0.0;

                    objMFGMatch = Regex.Match(objItem.ItemID, @"-MFG\Z", RegexOptions.IgnoreCase);
                    objDashIntMatch = Regex.Match(objItem.ItemID, @"-[0-9]\Z", RegexOptions.IgnoreCase);
                    //objItem.IsMFG = objRow["Item"].ToString().ToUpper().EndsWith("MFG");
                    objItem.IsSubItem = objMFGMatch.Success || objDashIntMatch.Success;//Implemented so isMFG functionality could be utilized for -1, -2, etc items


                    mobjItemList.Add(objItem);
                }

            }
            else
            {
                MessageBox.Show(((ComboBoxItem)cboSortSearch.SelectedItem).Text + " " + txtItem.Text + " not found!", "No Item Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            Cursor.Current = Cursors.Default;
            dgvItems.Visible = true;
            dgvItems.DataSource = mobjItemList;
            dgvItems.Refresh();
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    GetItems();
                    break;
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Item objItem = dgvItems.CurrentRow.DataBoundItem as Item;

            SelectedItem = objItem;
            objItem.SetAvgUnitWeight();
            this.Dispose();
        }
    }
}
