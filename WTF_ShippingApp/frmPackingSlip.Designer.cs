namespace WTF_ShippingApp
{
    partial class frmPackingSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingSlip));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrevAddr = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNextAddr = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtGrossWgt = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblAddrLineCt = new System.Windows.Forms.Label();
            this.lblAddrCt = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPalletCt = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblOrderError = new System.Windows.Forms.Label();
            this.lblGrossWeightError = new System.Windows.Forms.Label();
            this.lblPalletCountError = new System.Windows.Forms.Label();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCartonCt = new System.Windows.Forms.TextBox();
            this.lblCartonCountError = new System.Windows.Forms.Label();
            this.btnIncrementSuffix = new System.Windows.Forms.Button();
            this.dtmActualShipDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderLinePrefix = new System.Windows.Forms.TextBox();
            this.chkEnableOrderLinePrefix = new System.Windows.Forms.CheckBox();
            this.lblPackingSlipSuffix = new System.Windows.Forms.Label();
            this.chkLastFilledOrder = new System.Windows.Forms.CheckBox();
            this.dgvOrderLines = new WTF_ShippingApp.CustomDataGridView();
            this.txtOrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndrDueDate = new WTF_ShippingApp.CalendarColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevAddr
            // 
            this.btnPrevAddr.Location = new System.Drawing.Point(41, 27);
            this.btnPrevAddr.Name = "btnPrevAddr";
            this.btnPrevAddr.Size = new System.Drawing.Size(100, 20);
            this.btnPrevAddr.TabIndex = 10;
            this.btnPrevAddr.Text = "<< Previous";
            this.btnPrevAddr.Click += new System.EventHandler(this.btnPrevAddr_Click);
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label7.Location = new System.Drawing.Point(4, 236);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(743, 3);
            this.Label7.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.Location = new System.Drawing.Point(33, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(348, 119);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(41, 63);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // btnNextAddr
            // 
            this.btnNextAddr.Location = new System.Drawing.Point(277, 27);
            this.btnNextAddr.Name = "btnNextAddr";
            this.btnNextAddr.Size = new System.Drawing.Size(100, 20);
            this.btnNextAddr.TabIndex = 11;
            this.btnNextAddr.Text = "Next >>";
            this.btnNextAddr.Click += new System.EventHandler(this.btnNextAddr_Click);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 43);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(61, 16);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Customer ";
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Enabled = false;
            this.btnCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerSearch.Image")));
            this.btnCustomerSearch.Location = new System.Drawing.Point(175, 40);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(28, 20);
            this.btnCustomerSearch.TabIndex = 32;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(11, 126);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 16);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "# of Pallets";
            // 
            // txtGrossWgt
            // 
            this.txtGrossWgt.Location = new System.Drawing.Point(102, 77);
            this.txtGrossWgt.Name = "txtGrossWgt";
            this.txtGrossWgt.Size = new System.Drawing.Size(101, 20);
            this.txtGrossWgt.TabIndex = 1;
            this.txtGrossWgt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(12, 81);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(84, 16);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Gross Wgt";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(79, 14);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(92, 20);
            this.txtOrder.TabIndex = 21;
            this.txtOrder.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // txtCustomer
            // 
            this.txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(79, 40);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(92, 20);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // grpAddress
            // 
            this.grpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddress.Controls.Add(this.lblAddressError);
            this.grpAddress.Controls.Add(this.PictureBox1);
            this.grpAddress.Controls.Add(this.btnPrevAddr);
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.Controls.Add(this.btnNextAddr);
            this.grpAddress.Controls.Add(this.lblAddrLineCt);
            this.grpAddress.Controls.Add(this.lblAddrCt);
            this.grpAddress.Location = new System.Drawing.Point(318, 8);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(424, 212);
            this.grpAddress.TabIndex = 7;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Customer Address";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(387, 90);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(0, 13);
            this.lblAddressError.TabIndex = 48;
            // 
            // lblAddrLineCt
            // 
            this.lblAddrLineCt.ForeColor = System.Drawing.Color.Blue;
            this.lblAddrLineCt.Location = new System.Drawing.Point(57, 63);
            this.lblAddrLineCt.Name = "lblAddrLineCt";
            this.lblAddrLineCt.Size = new System.Drawing.Size(284, 16);
            this.lblAddrLineCt.TabIndex = 8;
            this.lblAddrLineCt.Text = "IMPORTANT:  Maximum number of address lines is 4";
            this.lblAddrLineCt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddrCt
            // 
            this.lblAddrCt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddrCt.Location = new System.Drawing.Point(33, 23);
            this.lblAddrCt.Name = "lblAddrCt";
            this.lblAddrCt.Size = new System.Drawing.Size(348, 28);
            this.lblAddrCt.TabIndex = 8;
            this.lblAddrCt.Text = "Address 1 of 1";
            this.lblAddrCt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(536, 408);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 24);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print...";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(642, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPalletCt
            // 
            this.txtPalletCt.BackColor = System.Drawing.SystemColors.Window;
            this.txtPalletCt.Location = new System.Drawing.Point(101, 123);
            this.txtPalletCt.Name = "txtPalletCt";
            this.txtPalletCt.Size = new System.Drawing.Size(102, 20);
            this.txtPalletCt.TabIndex = 3;
            this.txtPalletCt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(12, 18);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(69, 16);
            this.Label9.TabIndex = 25;
            this.Label9.Text = "Order";
            // 
            // lblOrderError
            // 
            this.lblOrderError.AutoSize = true;
            this.lblOrderError.ForeColor = System.Drawing.Color.Red;
            this.lblOrderError.Location = new System.Drawing.Point(172, 17);
            this.lblOrderError.Name = "lblOrderError";
            this.lblOrderError.Size = new System.Drawing.Size(0, 13);
            this.lblOrderError.TabIndex = 45;
            // 
            // lblGrossWeightError
            // 
            this.lblGrossWeightError.AutoSize = true;
            this.lblGrossWeightError.ForeColor = System.Drawing.Color.Red;
            this.lblGrossWeightError.Location = new System.Drawing.Point(209, 80);
            this.lblGrossWeightError.Name = "lblGrossWeightError";
            this.lblGrossWeightError.Size = new System.Drawing.Size(0, 13);
            this.lblGrossWeightError.TabIndex = 46;
            // 
            // lblPalletCountError
            // 
            this.lblPalletCountError.AutoSize = true;
            this.lblPalletCountError.ForeColor = System.Drawing.Color.Red;
            this.lblPalletCountError.Location = new System.Drawing.Point(209, 126);
            this.lblPalletCountError.Name = "lblPalletCountError";
            this.lblPalletCountError.Size = new System.Drawing.Size(0, 13);
            this.lblPalletCountError.TabIndex = 47;
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderSearch.Image")));
            this.btnOrderSearch.Location = new System.Drawing.Point(175, 14);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(28, 20);
            this.btnOrderSearch.TabIndex = 48;
            this.btnOrderSearch.Visible = false;
            this.btnOrderSearch.Click += new System.EventHandler(this.btnOrderSearch_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "# of Cartons";
            // 
            // txtCartonCt
            // 
            this.txtCartonCt.BackColor = System.Drawing.SystemColors.Window;
            this.txtCartonCt.Location = new System.Drawing.Point(102, 101);
            this.txtCartonCt.Name = "txtCartonCt";
            this.txtCartonCt.Size = new System.Drawing.Size(101, 20);
            this.txtCartonCt.TabIndex = 2;
            // 
            // lblCartonCountError
            // 
            this.lblCartonCountError.AutoSize = true;
            this.lblCartonCountError.ForeColor = System.Drawing.Color.Red;
            this.lblCartonCountError.Location = new System.Drawing.Point(209, 107);
            this.lblCartonCountError.Name = "lblCartonCountError";
            this.lblCartonCountError.Size = new System.Drawing.Size(0, 13);
            this.lblCartonCountError.TabIndex = 51;
            // 
            // btnIncrementSuffix
            // 
            this.btnIncrementSuffix.Location = new System.Drawing.Point(69, 209);
            this.btnIncrementSuffix.Name = "btnIncrementSuffix";
            this.btnIncrementSuffix.Size = new System.Drawing.Size(155, 21);
            this.btnIncrementSuffix.TabIndex = 53;
            this.btnIncrementSuffix.Text = "Increment Packing Slip Suffix";
            this.btnIncrementSuffix.UseVisualStyleBackColor = true;
            this.btnIncrementSuffix.Click += new System.EventHandler(this.btnIncrementSuffix_Click);
            // 
            // dtmActualShipDate
            // 
            this.dtmActualShipDate.Location = new System.Drawing.Point(12, 183);
            this.dtmActualShipDate.Name = "dtmActualShipDate";
            this.dtmActualShipDate.Size = new System.Drawing.Size(212, 20);
            this.dtmActualShipDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Order Line Prefix: ";
            // 
            // txtOrderLinePrefix
            // 
            this.txtOrderLinePrefix.Location = new System.Drawing.Point(109, 148);
            this.txtOrderLinePrefix.MaxLength = 5;
            this.txtOrderLinePrefix.Name = "txtOrderLinePrefix";
            this.txtOrderLinePrefix.Size = new System.Drawing.Size(94, 20);
            this.txtOrderLinePrefix.TabIndex = 4;
            this.txtOrderLinePrefix.Text = "Rel ";
            // 
            // chkEnableOrderLinePrefix
            // 
            this.chkEnableOrderLinePrefix.AutoSize = true;
            this.chkEnableOrderLinePrefix.Location = new System.Drawing.Point(209, 155);
            this.chkEnableOrderLinePrefix.Name = "chkEnableOrderLinePrefix";
            this.chkEnableOrderLinePrefix.Size = new System.Drawing.Size(15, 14);
            this.chkEnableOrderLinePrefix.TabIndex = 5;
            this.chkEnableOrderLinePrefix.UseVisualStyleBackColor = true;
            // 
            // lblPackingSlipSuffix
            // 
            this.lblPackingSlipSuffix.AutoSize = true;
            this.lblPackingSlipSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackingSlipSuffix.Location = new System.Drawing.Point(14, 213);
            this.lblPackingSlipSuffix.Name = "lblPackingSlipSuffix";
            this.lblPackingSlipSuffix.Size = new System.Drawing.Size(36, 13);
            this.lblPackingSlipSuffix.TabIndex = 58;
            this.lblPackingSlipSuffix.Text = "Suffx";
            // 
            // chkLastFilledOrder
            // 
            this.chkLastFilledOrder.AutoSize = true;
            this.chkLastFilledOrder.Location = new System.Drawing.Point(209, 18);
            this.chkLastFilledOrder.Name = "chkLastFilledOrder";
            this.chkLastFilledOrder.Size = new System.Drawing.Size(102, 17);
            this.chkLastFilledOrder.TabIndex = 59;
            this.chkLastFilledOrder.Text = "Last Filled Order";
            this.chkLastFilledOrder.UseVisualStyleBackColor = true;
            this.chkLastFilledOrder.CheckedChanged += new System.EventHandler(this.chkLastFilledOrder_CheckedChanged);
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderLines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtOrderLine,
            this.txtItemID,
            this.txtItemDescription,
            this.txtQtyOrdered,
            this.txtQtyShipped,
            this.txtQtyBO,
            this.txtNotes,
            this.clndrDueDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderLines.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderLines.Location = new System.Drawing.Point(12, 253);
            this.dgvOrderLines.Name = "dgvOrderLines";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderLines.Size = new System.Drawing.Size(730, 149);
            this.dgvOrderLines.TabIndex = 52;
            // 
            // txtOrderLine
            // 
            this.txtOrderLine.DataPropertyName = "CustomerOrderLine";
            this.txtOrderLine.HeaderText = "Line";
            this.txtOrderLine.Name = "txtOrderLine";
            this.txtOrderLine.Width = 86;
            // 
            // txtItemID
            // 
            this.txtItemID.DataPropertyName = "ItemID";
            this.txtItemID.HeaderText = "ItemID";
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Width = 86;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.DataPropertyName = "ItemDescription";
            this.txtItemDescription.HeaderText = "Description";
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Width = 86;
            // 
            // txtQtyOrdered
            // 
            this.txtQtyOrdered.DataPropertyName = "QtyOrdered";
            this.txtQtyOrdered.HeaderText = "Qty Ordered";
            this.txtQtyOrdered.Name = "txtQtyOrdered";
            this.txtQtyOrdered.Width = 86;
            // 
            // txtQtyShipped
            // 
            this.txtQtyShipped.DataPropertyName = "QtyShipped";
            this.txtQtyShipped.HeaderText = "Qty Shipped";
            this.txtQtyShipped.Name = "txtQtyShipped";
            this.txtQtyShipped.Width = 85;
            // 
            // txtQtyBO
            // 
            this.txtQtyBO.DataPropertyName = "QtyBackOrdered";
            this.txtQtyBO.HeaderText = "Qty B.O.";
            this.txtQtyBO.Name = "txtQtyBO";
            this.txtQtyBO.Width = 86;
            // 
            // txtNotes
            // 
            this.txtNotes.DataPropertyName = "Notes";
            this.txtNotes.HeaderText = "Notes";
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Width = 86;
            // 
            // clndrDueDate
            // 
            this.clndrDueDate.DataPropertyName = "DueDate";
            this.clndrDueDate.HeaderText = "Due Date";
            this.clndrDueDate.Name = "clndrDueDate";
            this.clndrDueDate.Width = 86;
            // 
            // frmPackingSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 462);
            this.Controls.Add(this.chkLastFilledOrder);
            this.Controls.Add(this.lblPackingSlipSuffix);
            this.Controls.Add(this.chkEnableOrderLinePrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderLinePrefix);
            this.Controls.Add(this.dtmActualShipDate);
            this.Controls.Add(this.btnIncrementSuffix);
            this.Controls.Add(this.dgvOrderLines);
            this.Controls.Add(this.lblCartonCountError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCartonCt);
            this.Controls.Add(this.btnOrderSearch);
            this.Controls.Add(this.lblPalletCountError);
            this.Controls.Add(this.lblGrossWeightError);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblOrderError);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtGrossWgt);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPalletCt);
            this.Controls.Add(this.Label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPackingSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing Slip";
            this.Load += new System.EventHandler(this.frmPackingSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPrevAddr;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnNextAddr;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCustomerSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtGrossWgt;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtOrder;
        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.GroupBox grpAddress;
        internal System.Windows.Forms.Label lblAddrLineCt;
        internal System.Windows.Forms.Label lblAddrCt;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtPalletCt;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblOrderError;
        private System.Windows.Forms.Label lblGrossWeightError;
        private System.Windows.Forms.Label lblPalletCountError;
        internal System.Windows.Forms.Button btnOrderSearch;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtCartonCt;
        private System.Windows.Forms.Label lblCartonCountError;
        private System.Windows.Forms.Button btnIncrementSuffix;
        private System.Windows.Forms.DateTimePicker dtmActualShipDate;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtOrderLinePrefix;
        private System.Windows.Forms.CheckBox chkEnableOrderLinePrefix;
        private System.Windows.Forms.Label lblPackingSlipSuffix;
        private CustomDataGridView dgvOrderLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyShipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNotes;
        private CalendarColumn clndrDueDate;
        private System.Windows.Forms.CheckBox chkLastFilledOrder;
    }
}