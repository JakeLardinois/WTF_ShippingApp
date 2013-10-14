namespace WTF_ShippingApp
{
    partial class frmSelectOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectOperation));
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.dgvOperations = new System.Windows.Forms.DataGridView();
            this.txtOperationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtWorkCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyScrapped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyMoved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNextOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Blue;
            this.lblLoading.Location = new System.Drawing.Point(16, 38);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(608, 308);
            this.lblLoading.TabIndex = 26;
            this.lblLoading.Text = "Loading job operations...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(436, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 28);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(536, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 20);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Job";
            // 
            // lblJob
            // 
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(56, 10);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(124, 20);
            this.lblJob.TabIndex = 22;
            this.lblJob.Text = "Job Number";
            // 
            // dgvOperations
            // 
            this.dgvOperations.AllowUserToAddRows = false;
            this.dgvOperations.AllowUserToDeleteRows = false;
            this.dgvOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtOperationNumber,
            this.txtWorkCenter,
            this.txtQtyComplete,
            this.txtQtyScrapped,
            this.txtQtyMoved,
            this.txtNextOperation});
            this.dgvOperations.Location = new System.Drawing.Point(16, 40);
            this.dgvOperations.Name = "dgvOperations";
            this.dgvOperations.ReadOnly = true;
            this.dgvOperations.Size = new System.Drawing.Size(608, 304);
            this.dgvOperations.TabIndex = 27;
            this.dgvOperations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperations_CellDoubleClick);
            // 
            // txtOperationNumber
            // 
            this.txtOperationNumber.DataPropertyName = "OperationNumber";
            this.txtOperationNumber.HeaderText = "Operation";
            this.txtOperationNumber.Name = "txtOperationNumber";
            this.txtOperationNumber.ReadOnly = true;
            this.txtOperationNumber.Width = 94;
            // 
            // txtWorkCenter
            // 
            this.txtWorkCenter.DataPropertyName = "WorkCenter";
            this.txtWorkCenter.HeaderText = "WC";
            this.txtWorkCenter.Name = "txtWorkCenter";
            this.txtWorkCenter.ReadOnly = true;
            this.txtWorkCenter.Width = 94;
            // 
            // txtQtyComplete
            // 
            this.txtQtyComplete.DataPropertyName = "QtyComplete";
            this.txtQtyComplete.HeaderText = "Qty Complete";
            this.txtQtyComplete.Name = "txtQtyComplete";
            this.txtQtyComplete.ReadOnly = true;
            this.txtQtyComplete.Width = 94;
            // 
            // txtQtyScrapped
            // 
            this.txtQtyScrapped.DataPropertyName = "QtyScapped";
            this.txtQtyScrapped.HeaderText = "QtyScrapped";
            this.txtQtyScrapped.Name = "txtQtyScrapped";
            this.txtQtyScrapped.ReadOnly = true;
            this.txtQtyScrapped.Width = 95;
            // 
            // txtQtyMoved
            // 
            this.txtQtyMoved.DataPropertyName = "QtyMoved";
            this.txtQtyMoved.HeaderText = "QtyMoved";
            this.txtQtyMoved.Name = "txtQtyMoved";
            this.txtQtyMoved.ReadOnly = true;
            this.txtQtyMoved.Width = 94;
            // 
            // txtNextOperation
            // 
            this.txtNextOperation.DataPropertyName = "NextOperation";
            this.txtNextOperation.HeaderText = "Next Operation";
            this.txtNextOperation.Name = "txtNextOperation";
            this.txtNextOperation.ReadOnly = true;
            this.txtNextOperation.Width = 94;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OperationNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Operation";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 94;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WorkCenter";
            this.dataGridViewTextBoxColumn2.HeaderText = "WC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QtyComplete";
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty Complete";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 94;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QtyScapped";
            this.dataGridViewTextBoxColumn4.HeaderText = "QtyScrapped";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QtyMoved";
            this.dataGridViewTextBoxColumn5.HeaderText = "QtyMoved";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 94;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NextOperation";
            this.dataGridViewTextBoxColumn6.HeaderText = "Next Operation";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 94;
            // 
            // frmSelectOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 397);
            this.Controls.Add(this.dgvOperations);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblJob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Job Operation";
            this.Load += new System.EventHandler(this.frmSelectOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblLoading;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.DataGridView dgvOperations;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOperationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtWorkCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyScrapped;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyMoved;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNextOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}