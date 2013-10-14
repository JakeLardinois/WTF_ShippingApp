namespace WTF_ShippingApp
{
    partial class frmSelectOrderLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectOrderLine));
            this.Label2 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.dgvOrderReleases = new System.Windows.Forms.DataGridView();
            this.txtLineOrReleaseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerOrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyShipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkFilterLines = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderReleases)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(10, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 20);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Item Number";
            // 
            // lblItem
            // 
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(82, 8);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(100, 20);
            this.lblItem.TabIndex = 33;
            this.lblItem.Text = "Item Number";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(430, 300);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 28);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(530, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(10, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 20);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Job";
            // 
            // lblJob
            // 
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(82, 32);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(124, 20);
            this.lblJob.TabIndex = 28;
            this.lblJob.Text = "Job Number";
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(82, 56);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(124, 20);
            this.lblOrder.TabIndex = 27;
            this.lblOrder.Text = "Order Number";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(10, 56);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 20);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Order";
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Blue;
            this.lblLoading.Location = new System.Drawing.Point(10, 88);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(608, 200);
            this.lblLoading.TabIndex = 29;
            this.lblLoading.Text = "Loading order releases...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrderReleases
            // 
            this.dgvOrderReleases.AllowUserToAddRows = false;
            this.dgvOrderReleases.AllowUserToDeleteRows = false;
            this.dgvOrderReleases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderReleases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderReleases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderReleases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtLineOrReleaseStatus,
            this.txtCustomerOrderLine,
            this.txtItemID,
            this.txtItemDescription,
            this.txtQtyOrdered,
            this.txtQtyShipped,
            this.txtDueDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderReleases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderReleases.Location = new System.Drawing.Point(10, 88);
            this.dgvOrderReleases.Name = "dgvOrderReleases";
            this.dgvOrderReleases.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderReleases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderReleases.Size = new System.Drawing.Size(608, 200);
            this.dgvOrderReleases.TabIndex = 35;
            this.dgvOrderReleases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderReleases_CellDoubleClick);
            // 
            // txtLineOrReleaseStatus
            // 
            this.txtLineOrReleaseStatus.DataPropertyName = "LineOrReleaseStatus";
            this.txtLineOrReleaseStatus.HeaderText = "Status";
            this.txtLineOrReleaseStatus.Name = "txtLineOrReleaseStatus";
            this.txtLineOrReleaseStatus.ReadOnly = true;
            this.txtLineOrReleaseStatus.Width = 81;
            // 
            // txtCustomerOrderLine
            // 
            this.txtCustomerOrderLine.DataPropertyName = "CustomerOrderLine";
            this.txtCustomerOrderLine.HeaderText = "Line";
            this.txtCustomerOrderLine.Name = "txtCustomerOrderLine";
            this.txtCustomerOrderLine.ReadOnly = true;
            this.txtCustomerOrderLine.Width = 80;
            // 
            // txtItemID
            // 
            this.txtItemID.DataPropertyName = "ItemID";
            this.txtItemID.HeaderText = "Item";
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Width = 81;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.DataPropertyName = "ItemDescription";
            this.txtItemDescription.HeaderText = "Description";
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = true;
            this.txtItemDescription.Width = 81;
            // 
            // txtQtyOrdered
            // 
            this.txtQtyOrdered.DataPropertyName = "QtyOrdered";
            this.txtQtyOrdered.HeaderText = "Qty Ordered";
            this.txtQtyOrdered.Name = "txtQtyOrdered";
            this.txtQtyOrdered.ReadOnly = true;
            this.txtQtyOrdered.Width = 81;
            // 
            // txtQtyShipped
            // 
            this.txtQtyShipped.DataPropertyName = "QtyShipped";
            this.txtQtyShipped.HeaderText = "Qty Shipped";
            this.txtQtyShipped.Name = "txtQtyShipped";
            this.txtQtyShipped.ReadOnly = true;
            this.txtQtyShipped.Width = 80;
            // 
            // txtDueDate
            // 
            this.txtDueDate.DataPropertyName = "DueDate";
            this.txtDueDate.HeaderText = "Due Date";
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Width = 81;
            // 
            // chkFilterLines
            // 
            this.chkFilterLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterLines.AutoSize = true;
            this.chkFilterLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFilterLines.Checked = true;
            this.chkFilterLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterLines.Location = new System.Drawing.Point(515, 12);
            this.chkFilterLines.Name = "chkFilterLines";
            this.chkFilterLines.Size = new System.Drawing.Size(103, 17);
            this.chkFilterLines.TabIndex = 36;
            this.chkFilterLines.Text = "Filter Latest Line";
            this.chkFilterLines.UseVisualStyleBackColor = true;
            this.chkFilterLines.CheckedChanged += new System.EventHandler(this.chkFilterLines_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LineOrReleaseStatus";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 81;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerOrderLine";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order Line";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QtyOrdered";
            this.dataGridViewTextBoxColumn5.HeaderText = "Qty Ordered";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 81;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "QtyShipped";
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty Shipped";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 81;
            // 
            // frmSelectOrderLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 337);
            this.Controls.Add(this.chkFilterLines);
            this.Controls.Add(this.dgvOrderReleases);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.Label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectOrderLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Order Line";
            this.Load += new System.EventHandler(this.frmSelectOrderRelease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderReleases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblItem;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblJob;
        internal System.Windows.Forms.Label lblOrder;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.DataGridView dgvOrderReleases;
        private System.Windows.Forms.CheckBox chkFilterLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLineOrReleaseStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerOrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyShipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDueDate;
    }
}