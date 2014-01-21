namespace WTF_ShippingApp
{
    partial class frmShipItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipItem));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCloseJob = new System.Windows.Forms.CheckBox();
            this.chkCompleteOperation = new System.Windows.Forms.CheckBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalWgt = new System.Windows.Forms.TextBox();
            this.btnJob = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblWorkCode = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblScrapped = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblMoved = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.btnPrintBOL = new System.Windows.Forms.Button();
            this.lblLineReleaseLbl = new System.Windows.Forms.Label();
            this.lblLineRelease = new System.Windows.Forms.Label();
            this.lblQtyAvail = new System.Windows.Forms.Label();
            this.lblQtyAvailRel = new System.Windows.Forms.Label();
            this.btnSelectInventory = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnPackingSlip = new System.Windows.Forms.Button();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.lblTotalWeightError = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.chkCloseJob);
            this.GroupBox1.Controls.Add(this.chkCompleteOperation);
            this.GroupBox1.Location = new System.Drawing.Point(197, 352);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(184, 64);
            this.GroupBox1.TabIndex = 55;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Visible = false;
            // 
            // chkCloseJob
            // 
            this.chkCloseJob.Location = new System.Drawing.Point(12, 36);
            this.chkCloseJob.Name = "chkCloseJob";
            this.chkCloseJob.Size = new System.Drawing.Size(168, 20);
            this.chkCloseJob.TabIndex = 10;
            this.chkCloseJob.Text = "Close Job";
            // 
            // chkCompleteOperation
            // 
            this.chkCompleteOperation.Location = new System.Drawing.Point(12, 11);
            this.chkCompleteOperation.Name = "chkCompleteOperation";
            this.chkCompleteOperation.Size = new System.Drawing.Size(168, 20);
            this.chkCompleteOperation.TabIndex = 9;
            this.chkCompleteOperation.Text = "Mark Operation as Complete";
            // 
            // cboLocation
            // 
            this.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocation.Location = new System.Drawing.Point(77, 248);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(120, 21);
            this.cboLocation.TabIndex = 54;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(197, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 24);
            this.btnOK.TabIndex = 51;
            this.btnOK.Text = "Ship";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(293, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 276);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 49;
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // txtTotalWgt
            // 
            this.txtTotalWgt.Location = new System.Drawing.Point(77, 300);
            this.txtTotalWgt.Name = "txtTotalWgt";
            this.txtTotalWgt.Size = new System.Drawing.Size(120, 20);
            this.txtTotalWgt.TabIndex = 48;
            this.txtTotalWgt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // btnJob
            // 
            this.btnJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJob.Location = new System.Drawing.Point(201, 80);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(24, 20);
            this.btnJob.TabIndex = 46;
            this.btnJob.Text = "...";
            this.btnJob.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(1, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "Item";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItem
            // 
            this.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(77, 8);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(120, 20);
            this.lblItem.TabIndex = 28;
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(1, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 42;
            this.Label2.Text = "Job";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJob
            // 
            this.lblJob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(77, 80);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(120, 21);
            this.lblJob.TabIndex = 22;
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.Location = new System.Drawing.Point(81, 32);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(304, 16);
            this.lblItemDesc.TabIndex = 41;
            // 
            // lblOperation
            // 
            this.lblOperation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(77, 136);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(40, 21);
            this.lblOperation.TabIndex = 23;
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(1, 140);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Operation";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(133, 140);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(28, 16);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "WC";
            // 
            // lblWorkCode
            // 
            this.lblWorkCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWorkCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkCode.Location = new System.Drawing.Point(165, 136);
            this.lblWorkCode.Name = "lblWorkCode";
            this.lblWorkCode.Size = new System.Drawing.Size(128, 21);
            this.lblWorkCode.TabIndex = 20;
            this.lblWorkCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOperation
            // 
            this.btnOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Location = new System.Drawing.Point(297, 136);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(24, 20);
            this.btnOperation.TabIndex = 47;
            this.btnOperation.Text = "...";
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // lblCompleted
            // 
            this.lblCompleted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.Location = new System.Drawing.Point(77, 164);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(120, 21);
            this.lblCompleted.TabIndex = 29;
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(1, 168);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(64, 16);
            this.Label8.TabIndex = 44;
            this.Label8.Text = "Completed";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScrapped
            // 
            this.lblScrapped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScrapped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrapped.Location = new System.Drawing.Point(77, 192);
            this.lblScrapped.Name = "lblScrapped";
            this.lblScrapped.Size = new System.Drawing.Size(120, 21);
            this.lblScrapped.TabIndex = 21;
            this.lblScrapped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(1, 196);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(64, 16);
            this.Label10.TabIndex = 33;
            this.Label10.Text = "Scrapped";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoved
            // 
            this.lblMoved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoved.Location = new System.Drawing.Point(77, 220);
            this.lblMoved.Name = "lblMoved";
            this.lblMoved.Size = new System.Drawing.Size(120, 21);
            this.lblMoved.TabIndex = 26;
            this.lblMoved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(1, 224);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(64, 16);
            this.Label12.TabIndex = 30;
            this.Label12.Text = "Moved";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(1, 276);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(64, 16);
            this.Label13.TabIndex = 31;
            this.Label13.Text = "Quantity";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(1, 252);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "Location";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrder
            // 
            this.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(77, 52);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(120, 21);
            this.lblOrder.TabIndex = 27;
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(1, 56);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(64, 16);
            this.Label11.TabIndex = 38;
            this.Label11.Text = "Order";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrintBOL
            // 
            this.btnPrintBOL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintBOL.Location = new System.Drawing.Point(9, 356);
            this.btnPrintBOL.Name = "btnPrintBOL";
            this.btnPrintBOL.Size = new System.Drawing.Size(120, 24);
            this.btnPrintBOL.TabIndex = 53;
            this.btnPrintBOL.Text = "Print BOL...";
            this.btnPrintBOL.Click += new System.EventHandler(this.btnPrintBOL_Click);
            // 
            // lblLineReleaseLbl
            // 
            this.lblLineReleaseLbl.Location = new System.Drawing.Point(209, 56);
            this.lblLineReleaseLbl.Name = "lblLineReleaseLbl";
            this.lblLineReleaseLbl.Size = new System.Drawing.Size(76, 16);
            this.lblLineReleaseLbl.TabIndex = 36;
            this.lblLineReleaseLbl.Text = "Line/Release";
            this.lblLineReleaseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLineRelease
            // 
            this.lblLineRelease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLineRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineRelease.Location = new System.Drawing.Point(289, 52);
            this.lblLineRelease.Name = "lblLineRelease";
            this.lblLineRelease.Size = new System.Drawing.Size(44, 21);
            this.lblLineRelease.TabIndex = 25;
            this.lblLineRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtyAvail
            // 
            this.lblQtyAvail.Location = new System.Drawing.Point(1, 111);
            this.lblQtyAvail.Name = "lblQtyAvail";
            this.lblQtyAvail.Size = new System.Drawing.Size(64, 16);
            this.lblQtyAvail.TabIndex = 32;
            this.lblQtyAvail.Text = "Released";
            this.lblQtyAvail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtyAvailRel
            // 
            this.lblQtyAvailRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQtyAvailRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyAvailRel.Location = new System.Drawing.Point(77, 108);
            this.lblQtyAvailRel.Name = "lblQtyAvailRel";
            this.lblQtyAvailRel.Size = new System.Drawing.Size(120, 21);
            this.lblQtyAvailRel.TabIndex = 24;
            this.lblQtyAvailRel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectInventory
            // 
            this.btnSelectInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectInventory.Location = new System.Drawing.Point(201, 276);
            this.btnSelectInventory.Name = "btnSelectInventory";
            this.btnSelectInventory.Size = new System.Drawing.Size(24, 20);
            this.btnSelectInventory.TabIndex = 45;
            this.btnSelectInventory.Text = "...";
            this.btnSelectInventory.Click += new System.EventHandler(this.btnSelectInventory_Click);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(1, 304);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 16);
            this.Label6.TabIndex = 37;
            this.Label6.Text = "Total Wgt";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(201, 304);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(24, 16);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "lbs.";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPackingSlip
            // 
            this.btnPackingSlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPackingSlip.Location = new System.Drawing.Point(9, 392);
            this.btnPackingSlip.Name = "btnPackingSlip";
            this.btnPackingSlip.Size = new System.Drawing.Size(120, 24);
            this.btnPackingSlip.TabIndex = 52;
            this.btnPackingSlip.Text = "Print Packing Slip...";
            this.btnPackingSlip.Click += new System.EventHandler(this.btnPackingSlip_Click);
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(231, 280);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(0, 13);
            this.lblQuantityError.TabIndex = 56;
            // 
            // lblTotalWeightError
            // 
            this.lblTotalWeightError.AutoSize = true;
            this.lblTotalWeightError.ForeColor = System.Drawing.Color.Red;
            this.lblTotalWeightError.Location = new System.Drawing.Point(231, 307);
            this.lblTotalWeightError.Name = "lblTotalWeightError";
            this.lblTotalWeightError.Size = new System.Drawing.Size(0, 13);
            this.lblTotalWeightError.TabIndex = 57;
            // 
            // frmShipItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 457);
            this.Controls.Add(this.lblTotalWeightError);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtTotalWgt);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lblWorkCode);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.lblScrapped);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.lblMoved);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.btnPrintBOL);
            this.Controls.Add(this.lblLineReleaseLbl);
            this.Controls.Add(this.lblLineRelease);
            this.Controls.Add(this.lblQtyAvail);
            this.Controls.Add(this.lblQtyAvailRel);
            this.Controls.Add(this.btnSelectInventory);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btnPackingSlip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShipItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ship Item";
            this.Load += new System.EventHandler(this.frmShipItem_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkCloseJob;
        internal System.Windows.Forms.CheckBox chkCompleteOperation;
        internal System.Windows.Forms.ComboBox cboLocation;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.TextBox txtTotalWgt;
        internal System.Windows.Forms.Button btnJob;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblItem;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblJob;
        internal System.Windows.Forms.Label lblItemDesc;
        internal System.Windows.Forms.Label lblOperation;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblWorkCode;
        internal System.Windows.Forms.Button btnOperation;
        internal System.Windows.Forms.Label lblCompleted;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblScrapped;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label lblMoved;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblOrder;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button btnPrintBOL;
        internal System.Windows.Forms.Label lblLineReleaseLbl;
        internal System.Windows.Forms.Label lblLineRelease;
        internal System.Windows.Forms.Label lblQtyAvail;
        internal System.Windows.Forms.Label lblQtyAvailRel;
        internal System.Windows.Forms.Button btnSelectInventory;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnPackingSlip;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblTotalWeightError;
    }
}