namespace WTF_ShippingApp
{
    partial class frmItemHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemHistory));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItemHistory = new System.Windows.Forms.DataGridView();
            this.chkbxIsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.optShipping = new System.Windows.Forms.RadioButton();
            this.optReceiving = new System.Windows.Forms.RadioButton();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnMarkAsShipped = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLastShipped = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblLastReceived = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblQtySelectedLabel = new System.Windows.Forms.Label();
            this.lblQtySelected = new System.Windows.Forms.Label();
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
            this.txtRecievedItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRecievedTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtShippedTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLabelSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPalletCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemHistory)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.lblQtySelectedLabel);
            this.GroupBox2.Controls.Add(this.lblQtySelected);
            this.GroupBox2.Controls.Add(this.dgvItemHistory);
            this.GroupBox2.Controls.Add(this.pnlFilter);
            this.GroupBox2.Location = new System.Drawing.Point(12, 154);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(668, 232);
            this.GroupBox2.TabIndex = 19;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Inventory History";
            // 
            // dgvItemHistory
            // 
            this.dgvItemHistory.AllowUserToAddRows = false;
            this.dgvItemHistory.AllowUserToDeleteRows = false;
            this.dgvItemHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkbxIsSelected,
            this.txtRecievedItemID,
            this.txtJob,
            this.txtItemID,
            this.txtQuantity,
            this.txtRecievedTimeStamp,
            this.txtOperator,
            this.txtGrossWeight,
            this.txtCustomerOrderNumber,
            this.txtShippedTimeStamp,
            this.txtLabelSequence,
            this.txtPalletCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemHistory.Location = new System.Drawing.Point(6, 49);
            this.dgvItemHistory.Name = "dgvItemHistory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemHistory.Size = new System.Drawing.Size(656, 177);
            this.dgvItemHistory.TabIndex = 6;
            // 
            // chkbxIsSelected
            // 
            this.chkbxIsSelected.DataPropertyName = "isSelected";
            this.chkbxIsSelected.HeaderText = "";
            this.chkbxIsSelected.Name = "chkbxIsSelected";
            this.chkbxIsSelected.Width = 51;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.optAll);
            this.pnlFilter.Controls.Add(this.optShipping);
            this.pnlFilter.Controls.Add(this.optReceiving);
            this.pnlFilter.Controls.Add(this.Label8);
            this.pnlFilter.Controls.Add(this.btnMarkAsShipped);
            this.pnlFilter.Location = new System.Drawing.Point(12, 23);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(436, 24);
            this.pnlFilter.TabIndex = 4;
            // 
            // optAll
            // 
            this.optAll.Location = new System.Drawing.Point(60, 4);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(44, 16);
            this.optAll.TabIndex = 1;
            this.optAll.Text = "All";
            this.optAll.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // optShipping
            // 
            this.optShipping.Location = new System.Drawing.Point(196, 4);
            this.optShipping.Name = "optShipping";
            this.optShipping.Size = new System.Drawing.Size(72, 16);
            this.optShipping.TabIndex = 1;
            this.optShipping.Text = "Shipped";
            this.optShipping.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // optReceiving
            // 
            this.optReceiving.Location = new System.Drawing.Point(112, 4);
            this.optReceiving.Name = "optReceiving";
            this.optReceiving.Size = new System.Drawing.Size(72, 16);
            this.optReceiving.TabIndex = 1;
            this.optReceiving.Text = "Received";
            this.optReceiving.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(4, 4);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(44, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "View";
            // 
            // btnMarkAsShipped
            // 
            this.btnMarkAsShipped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMarkAsShipped.Location = new System.Drawing.Point(324, 0);
            this.btnMarkAsShipped.Name = "btnMarkAsShipped";
            this.btnMarkAsShipped.Size = new System.Drawing.Size(112, 24);
            this.btnMarkAsShipped.TabIndex = 3;
            this.btnMarkAsShipped.Text = "Mark as Shipped...";
            this.btnMarkAsShipped.Click += new System.EventHandler(this.btnMarkAsShipped_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.lblLastShipped);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.lblLastReceived);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblQuantity);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(12, 62);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(668, 80);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Inventory Status";
            // 
            // lblLastShipped
            // 
            this.lblLastShipped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastShipped.Location = new System.Drawing.Point(332, 44);
            this.lblLastShipped.Name = "lblLastShipped";
            this.lblLastShipped.Size = new System.Drawing.Size(136, 20);
            this.lblLastShipped.TabIndex = 7;
            this.lblLastShipped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(160, 28);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 16);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Last Received";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastReceived
            // 
            this.lblLastReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastReceived.Location = new System.Drawing.Point(160, 44);
            this.lblLastReceived.Name = "lblLastReceived";
            this.lblLastReceived.Size = new System.Drawing.Size(136, 20);
            this.lblLastReceived.TabIndex = 7;
            this.lblLastReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(108, 16);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Available";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(16, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(108, 20);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(332, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Last Shipped";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 16);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Item";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem
            // 
            this.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(52, 10);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(120, 20);
            this.lblItem.TabIndex = 15;
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.Location = new System.Drawing.Point(52, 34);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(304, 16);
            this.lblItemDesc.TabIndex = 16;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(580, 394);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 24);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Close";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Location = new System.Drawing.Point(12, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 24);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print...";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblQtySelectedLabel
            // 
            this.lblQtySelectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtySelectedLabel.Location = new System.Drawing.Point(554, 11);
            this.lblQtySelectedLabel.Name = "lblQtySelectedLabel";
            this.lblQtySelectedLabel.Size = new System.Drawing.Size(108, 16);
            this.lblQtySelectedLabel.TabIndex = 11;
            this.lblQtySelectedLabel.Text = "Qty Selected";
            this.lblQtySelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtySelected
            // 
            this.lblQtySelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtySelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQtySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtySelected.Location = new System.Drawing.Point(554, 27);
            this.lblQtySelected.Name = "lblQtySelected";
            this.lblQtySelected.Size = new System.Drawing.Size(108, 20);
            this.lblQtySelected.TabIndex = 10;
            this.lblQtySelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RecievedItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Recieved ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn2.HeaderText = "Job";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 51;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 51;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 51;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RecievedTimeStamp";
            this.dataGridViewTextBoxColumn5.HeaderText = "Time Recieved";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 51;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn6.HeaderText = "Operator";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 52;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GrossWeight";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gross Weight";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 51;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CustomerOrderNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Order No.";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 51;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ShippedTimeStamp";
            this.dataGridViewTextBoxColumn9.HeaderText = "Time Shipped";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 51;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LabelSequence";
            this.dataGridViewTextBoxColumn10.HeaderText = "Sequence";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 51;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PalletCount";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pallet Count";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 51;
            // 
            // txtRecievedItemID
            // 
            this.txtRecievedItemID.DataPropertyName = "RecievedItemID";
            this.txtRecievedItemID.HeaderText = "Recieved ID";
            this.txtRecievedItemID.Name = "txtRecievedItemID";
            this.txtRecievedItemID.Width = 51;
            // 
            // txtJob
            // 
            this.txtJob.DataPropertyName = "Job";
            this.txtJob.HeaderText = "Job";
            this.txtJob.Name = "txtJob";
            this.txtJob.Width = 51;
            // 
            // txtItemID
            // 
            this.txtItemID.DataPropertyName = "ItemID";
            this.txtItemID.HeaderText = "Item";
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Width = 51;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataPropertyName = "Quantity";
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Width = 51;
            // 
            // txtRecievedTimeStamp
            // 
            this.txtRecievedTimeStamp.DataPropertyName = "RecievedTimeStamp";
            this.txtRecievedTimeStamp.HeaderText = "Time Recieved";
            this.txtRecievedTimeStamp.Name = "txtRecievedTimeStamp";
            this.txtRecievedTimeStamp.Width = 51;
            // 
            // txtOperator
            // 
            this.txtOperator.DataPropertyName = "Operator";
            this.txtOperator.HeaderText = "Operator";
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Width = 52;
            // 
            // txtGrossWeight
            // 
            this.txtGrossWeight.DataPropertyName = "GrossWeight";
            this.txtGrossWeight.HeaderText = "Gross Weight";
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.Width = 51;
            // 
            // txtCustomerOrderNumber
            // 
            this.txtCustomerOrderNumber.DataPropertyName = "CustomerOrderNumber";
            this.txtCustomerOrderNumber.HeaderText = "Order No.";
            this.txtCustomerOrderNumber.Name = "txtCustomerOrderNumber";
            this.txtCustomerOrderNumber.Width = 51;
            // 
            // txtShippedTimeStamp
            // 
            this.txtShippedTimeStamp.DataPropertyName = "ShippedTimeStamp";
            this.txtShippedTimeStamp.HeaderText = "Time Shipped";
            this.txtShippedTimeStamp.Name = "txtShippedTimeStamp";
            this.txtShippedTimeStamp.Width = 51;
            // 
            // txtLabelSequence
            // 
            this.txtLabelSequence.DataPropertyName = "LabelSequence";
            this.txtLabelSequence.HeaderText = "Sequence";
            this.txtLabelSequence.Name = "txtLabelSequence";
            this.txtLabelSequence.Width = 51;
            // 
            // txtPalletCount
            // 
            this.txtPalletCount.DataPropertyName = "PalletCount";
            this.txtPalletCount.HeaderText = "Pallet Count";
            this.txtPalletCount.Name = "txtPalletCount";
            this.txtPalletCount.Width = 51;
            // 
            // frmItemHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 429);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item History";
            this.Load += new System.EventHandler(this.frmItemHistory_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemHistory)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Panel pnlFilter;
        internal System.Windows.Forms.RadioButton optAll;
        internal System.Windows.Forms.RadioButton optShipping;
        internal System.Windows.Forms.RadioButton optReceiving;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnMarkAsShipped;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblLastShipped;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblLastReceived;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblItem;
        internal System.Windows.Forms.Label lblItemDesc;
        internal System.Windows.Forms.Button btnFinish;
        internal System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvItemHistory;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkbxIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRecievedItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRecievedTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtShippedTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLabelSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPalletCount;
        internal System.Windows.Forms.Label lblQtySelectedLabel;
        internal System.Windows.Forms.Label lblQtySelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}