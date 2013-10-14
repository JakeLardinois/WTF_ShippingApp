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
    public partial class frmSettings : Form
    {
        SL8DbDataContext objDB;


        public frmSettings()
        {
            InitializeComponent();

            objDB = new SL8DbDataContext();
            settingBindingSource.DataSource = objDB.Settings;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objDB.SubmitChanges();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeSet objChangeSet = objDB.GetChangeSet();

            if (objChangeSet.Deletes.Count > 0 || objChangeSet.Inserts.Count > 0 || objChangeSet.Updates.Count > 0)
                if ((MessageBox.Show("Do You want to save your changes?", "Save Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    objDB.SubmitChanges();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            dgvSettings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
