namespace WTF_ShippingApp
{
    partial class frmShipMultiple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipMultiple));
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.btnBOL = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnPackSlip = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.dgvOrderLines = new System.Windows.Forms.DataGridView();
            this.txtLineOrReleaseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkFilterLOrRStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblItemDescription.Location = new System.Drawing.Point(12, 61);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(202, 20);
            this.lblItemDescription.TabIndex = 28;
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(12, 20);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(46, 20);
            this.Label8.TabIndex = 26;
            this.Label8.Text = "Order #";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(553, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 20);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Order Date";
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(191, 20);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(58, 20);
            this.Label9.TabIndex = 25;
            this.Label9.Text = "Customer";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(625, 16);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(86, 20);
            this.lblOrderDate.TabIndex = 23;
            this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(266, 16);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(261, 20);
            this.lblCustomer.TabIndex = 22;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(64, 16);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNum.TabIndex = 16;
            this.txtOrderNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderNum_KeyDown);
            // 
            // btnBOL
            // 
            this.btnBOL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBOL.Location = new System.Drawing.Point(156, 418);
            this.btnBOL.Name = "btnBOL";
            this.btnBOL.Size = new System.Drawing.Size(135, 24);
            this.btnBOL.TabIndex = 21;
            this.btnBOL.Text = "Print BOL...";
            this.btnBOL.Click += new System.EventHandler(this.btnBOL_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(632, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.Location = new System.Drawing.Point(-399, 418);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 24);
            this.Button2.TabIndex = 17;
            this.Button2.Text = "Ship";
            this.Button2.Visible = false;
            // 
            // btnPackSlip
            // 
            this.btnPackSlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPackSlip.Location = new System.Drawing.Point(15, 418);
            this.btnPackSlip.Name = "btnPackSlip";
            this.btnPackSlip.Size = new System.Drawing.Size(135, 24);
            this.btnPackSlip.TabIndex = 19;
            this.btnPackSlip.Text = "Print Packing Slip...";
            this.btnPackSlip.Click += new System.EventHandler(this.btnPackSlip_Click);
            // 
            // btnShip
            // 
            this.btnShip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShip.Location = new System.Drawing.Point(526, 418);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(100, 24);
            this.btnShip.TabIndex = 18;
            this.btnShip.Text = "Ship";
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.AllowUserToAddRows = false;
            this.dgvOrderLines.AllowUserToDeleteRows = false;
            this.dgvOrderLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtLineOrReleaseStatus,
            this.txtOrderLine,
            this.txtItemID,
            this.txtItemDescription,
            this.txtQtyOrdered,
            this.txtQtyShipped,
            this.txtDueDate});
            this.dgvOrderLines.Location = new System.Drawing.Point(15, 84);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.ReadOnly = true;
            this.dgvOrderLines.Size = new System.Drawing.Size(717, 315);
            this.dgvOrderLines.TabIndex = 30;
            this.dgvOrderLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderLines_CellDoubleClick);
            // 
            // txtLineOrReleaseStatus
            // 
            this.txtLineOrReleaseStatus.DataPropertyName = "LineOrReleaseStatus";
            this.txtLineOrReleaseStatus.HeaderText = "Status";
            this.txtLineOrReleaseStatus.Name = "txtLineOrReleaseStatus";
            this.txtLineOrReleaseStatus.ReadOnly = true;
            this.txtLineOrReleaseStatus.Width = 96;
            // 
            // txtOrderLine
            // 
            this.txtOrderLine.DataPropertyName = "CustomerOrderLine";
            this.txtOrderLine.HeaderText = "Line";
            this.txtOrderLine.Name = "txtOrderLine";
            this.txtOrderLine.ReadOnly = true;
            this.txtOrderLine.Width = 97;
            // 
            // txtItemID
            // 
            this.txtItemID.DataPropertyName = "ItemID";
            this.txtItemID.HeaderText = "Item";
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Width = 96;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.DataPropertyName = "ItemDescription";
            this.txtItemDescription.HeaderText = "Description";
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = true;
            this.txtItemDescription.Width = 96;
            // 
            // txtQtyOrdered
            // 
            this.txtQtyOrdered.DataPropertyName = "QtyOrdered";
            this.txtQtyOrdered.HeaderText = "Qty Ordered";
            this.txtQtyOrdered.Name = "txtQtyOrdered";
            this.txtQtyOrdered.ReadOnly = true;
            this.txtQtyOrdered.Width = 96;
            // 
            // txtQtyShipped
            // 
            this.txtQtyShipped.DataPropertyName = "QtyShipped";
            this.txtQtyShipped.HeaderText = "Qty Shipped";
            this.txtQtyShipped.Name = "txtQtyShipped";
            this.txtQtyShipped.ReadOnly = true;
            this.txtQtyShipped.Width = 97;
            // 
            // txtDueDate
            // 
            this.txtDueDate.DataPropertyName = "DueDate";
            this.txtDueDate.HeaderText = "Due Date";
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Width = 96;
            // 
            // chkFilterLOrRStatus
            // 
            this.chkFilterLOrRStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterLOrRStatus.AutoSize = true;
            this.chkFilterLOrRStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFilterLOrRStatus.Checked = true;
            this.chkFilterLOrRStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterLOrRStatus.Location = new System.Drawing.Point(545, 47);
            this.chkFilterLOrRStatus.Name = "chkFilterLOrRStatus";
            this.chkFilterLOrRStatus.Size = new System.Drawing.Size(166, 17);
            this.chkFilterLOrRStatus.TabIndex = 31;
            this.chkFilterLOrRStatus.Text = "Filter Open Lines Or Releases";
            this.chkFilterLOrRStatus.UseVisualStyleBackColor = true;
            this.chkFilterLOrRStatus.CheckedChanged += new System.EventHandler(this.chkFilterLOrRStatus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Order Type";
            // 
            // lblOrderType
            // 
            this.lblOrderType.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrderType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(266, 40);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(84, 20);
            this.lblOrderType.TabIndex = 32;
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmShipMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.chkFilterLOrRStatus);
            this.Controls.Add(this.dgvOrderLines);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.btnBOL);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnPackSlip);
            this.Controls.Add(this.btnShip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShipMultiple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShipMultiple";
            this.Load += new System.EventHandler(this.frmShipMultiple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblItemDescription;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblOrderDate;
        internal System.Windows.Forms.Label lblCustomer;
        internal System.Windows.Forms.TextBox txtOrderNum;
        internal System.Windows.Forms.Button btnBOL;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnPackSlip;
        internal System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.DataGridView dgvOrderLines;
        internal System.Windows.Forms.CheckBox chkFilterLOrRStatus;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLineOrReleaseStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyShipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDueDate;
    }
}