namespace WTF_ShippingApp
{
    partial class frmPackingSlipHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingSlipHistory));
            this.grpPackingSlipLines = new System.Windows.Forms.GroupBox();
            this.dgvPackingSlips = new System.Windows.Forms.DataGridView();
            this.cmuPackingSlipLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtSearchItemDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchCustomerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkApplyFilter = new System.Windows.Forms.CheckBox();
            this.txtSearchCustomerNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmSearchPrintDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchPackingSlipNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchCustomerPO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.nudMaxRecordCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrintDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPackingSlipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerOrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerOrderRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtActualShipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPromiseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyBackOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPackingSlipLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackingSlips)).BeginInit();
            this.cmuPackingSlipLines.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRecordCount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPackingSlipLines
            // 
            this.grpPackingSlipLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPackingSlipLines.Controls.Add(this.dgvPackingSlips);
            this.grpPackingSlipLines.Location = new System.Drawing.Point(12, 160);
            this.grpPackingSlipLines.Name = "grpPackingSlipLines";
            this.grpPackingSlipLines.Size = new System.Drawing.Size(732, 225);
            this.grpPackingSlipLines.TabIndex = 0;
            this.grpPackingSlipLines.TabStop = false;
            this.grpPackingSlipLines.Text = "Packing Slip Lines";
            // 
            // dgvPackingSlips
            // 
            this.dgvPackingSlips.AllowUserToAddRows = false;
            this.dgvPackingSlips.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackingSlips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPackingSlips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackingSlips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPrintDate,
            this.txtItemID,
            this.txtItemDescription,
            this.txtCustomerPO,
            this.txtPackingSlipNo,
            this.txtCustomerOrderLine,
            this.txtCustomerOrderRelease,
            this.txtActualShipDate,
            this.txtPromiseDate,
            this.txtQtyOrdered,
            this.txtQtyShipped,
            this.txtQtyBackOrdered,
            this.txtCustomerNumber,
            this.txtCustomerAddress});
            this.dgvPackingSlips.ContextMenuStrip = this.cmuPackingSlipLines;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackingSlips.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPackingSlips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackingSlips.Location = new System.Drawing.Point(3, 16);
            this.dgvPackingSlips.MultiSelect = false;
            this.dgvPackingSlips.Name = "dgvPackingSlips";
            this.dgvPackingSlips.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackingSlips.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPackingSlips.Size = new System.Drawing.Size(726, 206);
            this.dgvPackingSlips.TabIndex = 0;
            this.dgvPackingSlips.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPackingSlips_DataError);
            this.dgvPackingSlips.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPackingSlips_UserDeletingRow);
            // 
            // cmuPackingSlipLines
            // 
            this.cmuPackingSlipLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmuPackingSlipLines.Name = "cmuPackingSlipLines";
            this.cmuPackingSlipLines.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblMessage);
            this.groupBox2.Controls.Add(this.txtSearchItemDescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSearchCustomerAddress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkApplyFilter);
            this.groupBox2.Controls.Add(this.txtSearchCustomerNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtmSearchPrintDate);
            this.groupBox2.Controls.Add(this.txtSearchPackingSlipNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSearchItem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSearchCustomerPO);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(426, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 14;
            // 
            // txtSearchItemDescription
            // 
            this.txtSearchItemDescription.Location = new System.Drawing.Point(100, 99);
            this.txtSearchItemDescription.Name = "txtSearchItemDescription";
            this.txtSearchItemDescription.Size = new System.Drawing.Size(363, 20);
            this.txtSearchItemDescription.TabIndex = 13;
            this.txtSearchItemDescription.TextChanged += new System.EventHandler(this.txtSearchItemDescription_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Item Description :";
            // 
            // txtSearchCustomerAddress
            // 
            this.txtSearchCustomerAddress.Location = new System.Drawing.Point(543, 47);
            this.txtSearchCustomerAddress.Multiline = true;
            this.txtSearchCustomerAddress.Name = "txtSearchCustomerAddress";
            this.txtSearchCustomerAddress.Size = new System.Drawing.Size(177, 68);
            this.txtSearchCustomerAddress.TabIndex = 11;
            this.txtSearchCustomerAddress.TextChanged += new System.EventHandler(this.txtSearchCustomerAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ship Address :";
            // 
            // chkApplyFilter
            // 
            this.chkApplyFilter.AutoSize = true;
            this.chkApplyFilter.Checked = true;
            this.chkApplyFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplyFilter.Location = new System.Drawing.Point(306, 12);
            this.chkApplyFilter.Name = "chkApplyFilter";
            this.chkApplyFilter.Size = new System.Drawing.Size(103, 17);
            this.chkApplyFilter.TabIndex = 2;
            this.chkApplyFilter.Text = "Apply Date Filter";
            this.chkApplyFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkApplyFilter.UseVisualStyleBackColor = true;
            this.chkApplyFilter.CheckedChanged += new System.EventHandler(this.chkApplyFilter_CheckedChanged);
            // 
            // txtSearchCustomerNo
            // 
            this.txtSearchCustomerNo.Location = new System.Drawing.Point(322, 73);
            this.txtSearchCustomerNo.Name = "txtSearchCustomerNo";
            this.txtSearchCustomerNo.Size = new System.Drawing.Size(141, 20);
            this.txtSearchCustomerNo.TabIndex = 9;
            this.txtSearchCustomerNo.TextChanged += new System.EventHandler(this.txtSearchCustomerNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer No :";
            // 
            // dtmSearchPrintDate
            // 
            this.dtmSearchPrintDate.Location = new System.Drawing.Point(100, 10);
            this.dtmSearchPrintDate.Name = "dtmSearchPrintDate";
            this.dtmSearchPrintDate.Size = new System.Drawing.Size(200, 20);
            this.dtmSearchPrintDate.TabIndex = 0;
            this.dtmSearchPrintDate.ValueChanged += new System.EventHandler(this.dtmSearchPrintDate_ValueChanged);
            // 
            // txtSearchPackingSlipNo
            // 
            this.txtSearchPackingSlipNo.Location = new System.Drawing.Point(101, 47);
            this.txtSearchPackingSlipNo.Name = "txtSearchPackingSlipNo";
            this.txtSearchPackingSlipNo.Size = new System.Drawing.Size(144, 20);
            this.txtSearchPackingSlipNo.TabIndex = 7;
            this.txtSearchPackingSlipNo.TextChanged += new System.EventHandler(this.txtSearchPackingSlipNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Print Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Packing Slip No. :";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(101, 73);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(144, 20);
            this.txtSearchItem.TabIndex = 5;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item :";
            // 
            // txtSearchCustomerPO
            // 
            this.txtSearchCustomerPO.Location = new System.Drawing.Point(322, 47);
            this.txtSearchCustomerPO.Name = "txtSearchCustomerPO";
            this.txtSearchCustomerPO.Size = new System.Drawing.Size(141, 20);
            this.txtSearchCustomerPO.TabIndex = 3;
            this.txtSearchCustomerPO.TextChanged += new System.EventHandler(this.txtSearchCustomerPO_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer PO :";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PrintDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ship Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerOrderNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "PackingSlip";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PackingSlipNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Packing Slip No.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustomerOrderLine";
            this.dataGridViewTextBoxColumn4.HeaderText = "Line";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CustomerOrderRelease";
            this.dataGridViewTextBoxColumn5.HeaderText = "Release";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ActualShipDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ship Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PromiseDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Promise Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CustomerNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Customer No.";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CustomerAddress";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ship Address";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CustomerAddress";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ship Address";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CustomerAddress";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ship Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.Location = new System.Drawing.Point(526, 394);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(106, 23);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDiscardChanges
            // 
            this.btnDiscardChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscardChanges.Location = new System.Drawing.Point(638, 394);
            this.btnDiscardChanges.Name = "btnDiscardChanges";
            this.btnDiscardChanges.Size = new System.Drawing.Size(106, 23);
            this.btnDiscardChanges.TabIndex = 3;
            this.btnDiscardChanges.Text = "Discard Changes";
            this.btnDiscardChanges.UseVisualStyleBackColor = true;
            this.btnDiscardChanges.Click += new System.EventHandler(this.btnDiscardChanges_Click);
            // 
            // nudMaxRecordCount
            // 
            this.nudMaxRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxRecordCount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxRecordCount.Location = new System.Drawing.Point(679, 141);
            this.nudMaxRecordCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxRecordCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxRecordCount.Name = "nudMaxRecordCount";
            this.nudMaxRecordCount.ReadOnly = true;
            this.nudMaxRecordCount.Size = new System.Drawing.Size(62, 20);
            this.nudMaxRecordCount.TabIndex = 4;
            this.nudMaxRecordCount.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Max Record Count :";
            // 
            // txtPrintDate
            // 
            this.txtPrintDate.DataPropertyName = "PrintDate";
            this.txtPrintDate.HeaderText = "Print Date";
            this.txtPrintDate.Name = "txtPrintDate";
            this.txtPrintDate.ReadOnly = true;
            this.txtPrintDate.Width = 50;
            // 
            // txtItemID
            // 
            this.txtItemID.DataPropertyName = "ItemID";
            this.txtItemID.HeaderText = "Item";
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.DataPropertyName = "ItemDescription";
            this.txtItemDescription.HeaderText = "Item Description";
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = true;
            // 
            // txtCustomerPO
            // 
            this.txtCustomerPO.DataPropertyName = "CustomerPO";
            this.txtCustomerPO.HeaderText = "Customer PO";
            this.txtCustomerPO.Name = "txtCustomerPO";
            this.txtCustomerPO.ReadOnly = true;
            // 
            // txtPackingSlipNo
            // 
            this.txtPackingSlipNo.DataPropertyName = "PackingSlipNo";
            this.txtPackingSlipNo.HeaderText = "Packing Slip No.";
            this.txtPackingSlipNo.Name = "txtPackingSlipNo";
            this.txtPackingSlipNo.ReadOnly = true;
            // 
            // txtCustomerOrderLine
            // 
            this.txtCustomerOrderLine.DataPropertyName = "CustomerOrderLine";
            this.txtCustomerOrderLine.HeaderText = "Line";
            this.txtCustomerOrderLine.Name = "txtCustomerOrderLine";
            this.txtCustomerOrderLine.ReadOnly = true;
            // 
            // txtCustomerOrderRelease
            // 
            this.txtCustomerOrderRelease.DataPropertyName = "CustomerOrderRelease";
            this.txtCustomerOrderRelease.HeaderText = "Release";
            this.txtCustomerOrderRelease.Name = "txtCustomerOrderRelease";
            this.txtCustomerOrderRelease.ReadOnly = true;
            // 
            // txtActualShipDate
            // 
            this.txtActualShipDate.DataPropertyName = "ActualShipDate";
            this.txtActualShipDate.HeaderText = "Ship Date";
            this.txtActualShipDate.Name = "txtActualShipDate";
            this.txtActualShipDate.ReadOnly = true;
            // 
            // txtPromiseDate
            // 
            this.txtPromiseDate.DataPropertyName = "PromiseDate";
            this.txtPromiseDate.HeaderText = "Promise Date";
            this.txtPromiseDate.Name = "txtPromiseDate";
            this.txtPromiseDate.ReadOnly = true;
            // 
            // txtQtyOrdered
            // 
            this.txtQtyOrdered.DataPropertyName = "QtyOrdered";
            this.txtQtyOrdered.HeaderText = "Qty Ordered";
            this.txtQtyOrdered.Name = "txtQtyOrdered";
            this.txtQtyOrdered.ReadOnly = true;
            // 
            // txtQtyShipped
            // 
            this.txtQtyShipped.DataPropertyName = "QtyShipped";
            this.txtQtyShipped.HeaderText = "Qty Shipped";
            this.txtQtyShipped.Name = "txtQtyShipped";
            this.txtQtyShipped.ReadOnly = true;
            // 
            // txtQtyBackOrdered
            // 
            this.txtQtyBackOrdered.DataPropertyName = "QtyBackOrdered";
            this.txtQtyBackOrdered.HeaderText = "Qty BackOrdered";
            this.txtQtyBackOrdered.Name = "txtQtyBackOrdered";
            this.txtQtyBackOrdered.ReadOnly = true;
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.DataPropertyName = "CustomerNumber";
            this.txtCustomerNumber.HeaderText = "Customer No.";
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.ReadOnly = true;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.DataPropertyName = "CustomerAddress";
            this.txtCustomerAddress.HeaderText = "Ship Address";
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            // 
            // frmPackingSlipHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 429);
            this.Controls.Add(this.nudMaxRecordCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDiscardChanges);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpPackingSlipLines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPackingSlipHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing Slip History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPackingSlipHistory_FormClosing);
            this.Load += new System.EventHandler(this.frmPackingSlipHistory_Load);
            this.grpPackingSlipLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackingSlips)).EndInit();
            this.cmuPackingSlipLines.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRecordCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPackingSlipLines;
        private System.Windows.Forms.DataGridView dgvPackingSlips;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmSearchPrintDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox txtSearchCustomerPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPackingSlipNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkApplyFilter;
        private System.Windows.Forms.TextBox txtSearchCustomerNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchCustomerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox txtSearchItemDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip cmuPackingSlipLines;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDiscardChanges;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.NumericUpDown nudMaxRecordCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrintDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPackingSlipNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerOrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerOrderRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtActualShipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPromiseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyShipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyBackOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerAddress;
    }
}