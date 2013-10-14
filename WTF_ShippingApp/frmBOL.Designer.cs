namespace WTF_ShippingApp
{
    partial class frmBOL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBOL));
            this.btnPrevAddr = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnNextAddr = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.cboFreightCharges = new System.Windows.Forms.ComboBox();
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
            this.cboCarrier = new System.Windows.Forms.ComboBox();
            this.txtPalletCt = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboShipClass = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblCarrierError = new System.Windows.Forms.Label();
            this.lblShipClassificationError = new System.Windows.Forms.Label();
            this.lblFreightChargesError = new System.Windows.Forms.Label();
            this.lblOrderError = new System.Windows.Forms.Label();
            this.lblGrossWeightError = new System.Windows.Forms.Label();
            this.lblPalletCountError = new System.Windows.Forms.Label();
            this.lblCustomerError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevAddr
            // 
            this.btnPrevAddr.Location = new System.Drawing.Point(46, 28);
            this.btnPrevAddr.Name = "btnPrevAddr";
            this.btnPrevAddr.Size = new System.Drawing.Size(100, 20);
            this.btnPrevAddr.TabIndex = 10;
            this.btnPrevAddr.Text = "<< Previous";
            this.btnPrevAddr.Click += new System.EventHandler(this.btnPrevAddr_Click);
            // 
            // Label7
            // 
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label7.Location = new System.Drawing.Point(-21, 412);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(488, 3);
            this.Label7.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.Location = new System.Drawing.Point(38, 88);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(348, 60);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(46, 64);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(-1, 181);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(92, 16);
            this.Label6.TabIndex = 40;
            this.Label6.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(99, 177);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(324, 68);
            this.txtNotes.TabIndex = 34;
            // 
            // btnNextAddr
            // 
            this.btnNextAddr.Location = new System.Drawing.Point(282, 28);
            this.btnNextAddr.Name = "btnNextAddr";
            this.btnNextAddr.Size = new System.Drawing.Size(100, 20);
            this.btnNextAddr.TabIndex = 11;
            this.btnNextAddr.Text = "Next >>";
            this.btnNextAddr.Click += new System.EventHandler(this.btnNextAddr_Click);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(-1, 132);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 16);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Customer ";
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerSearch.Image")));
            this.btnCustomerSearch.Location = new System.Drawing.Point(195, 128);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(28, 20);
            this.btnCustomerSearch.TabIndex = 32;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(-1, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 16);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "# of Pallets";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(-1, 156);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 16);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Freight Charges";
            // 
            // cboFreightCharges
            // 
            this.cboFreightCharges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFreightCharges.Location = new System.Drawing.Point(99, 152);
            this.cboFreightCharges.Name = "cboFreightCharges";
            this.cboFreightCharges.Size = new System.Drawing.Size(168, 21);
            this.cboFreightCharges.TabIndex = 33;
            this.cboFreightCharges.DropDown += new System.EventHandler(this.Combobox_DropDown);
            this.cboFreightCharges.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // txtGrossWgt
            // 
            this.txtGrossWgt.Location = new System.Drawing.Point(99, 32);
            this.txtGrossWgt.Name = "txtGrossWgt";
            this.txtGrossWgt.Size = new System.Drawing.Size(92, 20);
            this.txtGrossWgt.TabIndex = 22;
            this.txtGrossWgt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(-1, 36);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(84, 16);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Gross Wgt";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(99, 8);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(92, 20);
            this.txtOrder.TabIndex = 21;
            this.txtOrder.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // txtCustomer
            // 
            this.txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomer.Location = new System.Drawing.Point(99, 128);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(92, 20);
            this.txtCustomer.TabIndex = 31;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.lblAddressError);
            this.grpAddress.Controls.Add(this.PictureBox1);
            this.grpAddress.Controls.Add(this.btnPrevAddr);
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.Controls.Add(this.btnNextAddr);
            this.grpAddress.Controls.Add(this.lblAddrLineCt);
            this.grpAddress.Controls.Add(this.lblAddrCt);
            this.grpAddress.Location = new System.Drawing.Point(-1, 252);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(424, 156);
            this.grpAddress.TabIndex = 36;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Customer Address";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(392, 91);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(0, 13);
            this.lblAddressError.TabIndex = 48;
            // 
            // lblAddrLineCt
            // 
            this.lblAddrLineCt.ForeColor = System.Drawing.Color.Blue;
            this.lblAddrLineCt.Location = new System.Drawing.Point(62, 64);
            this.lblAddrLineCt.Name = "lblAddrLineCt";
            this.lblAddrLineCt.Size = new System.Drawing.Size(284, 16);
            this.lblAddrLineCt.TabIndex = 8;
            this.lblAddrLineCt.Text = "IMPORTANT:  Maximum number of address lines is 4";
            this.lblAddrLineCt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddrCt
            // 
            this.lblAddrCt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddrCt.Location = new System.Drawing.Point(38, 24);
            this.lblAddrCt.Name = "lblAddrCt";
            this.lblAddrCt.Size = new System.Drawing.Size(348, 28);
            this.lblAddrCt.TabIndex = 8;
            this.lblAddrCt.Text = "Address 1 of 1";
            this.lblAddrCt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(215, 423);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 24);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print...";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(323, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            // 
            // cboCarrier
            // 
            this.cboCarrier.BackColor = System.Drawing.SystemColors.Window;
            this.cboCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrier.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCarrier.Location = new System.Drawing.Point(99, 80);
            this.cboCarrier.Name = "cboCarrier";
            this.cboCarrier.Size = new System.Drawing.Size(168, 21);
            this.cboCarrier.TabIndex = 29;
            this.cboCarrier.DropDown += new System.EventHandler(this.Combobox_DropDown);
            this.cboCarrier.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // txtPalletCt
            // 
            this.txtPalletCt.BackColor = System.Drawing.SystemColors.Window;
            this.txtPalletCt.Location = new System.Drawing.Point(99, 56);
            this.txtPalletCt.Name = "txtPalletCt";
            this.txtPalletCt.Size = new System.Drawing.Size(92, 20);
            this.txtPalletCt.TabIndex = 24;
            this.txtPalletCt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(-1, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 16);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Carrier";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(-1, 108);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 16);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Ship Classification";
            // 
            // cboShipClass
            // 
            this.cboShipClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShipClass.Location = new System.Drawing.Point(99, 104);
            this.cboShipClass.Name = "cboShipClass";
            this.cboShipClass.Size = new System.Drawing.Size(324, 21);
            this.cboShipClass.TabIndex = 30;
            this.cboShipClass.DropDown += new System.EventHandler(this.Combobox_DropDown);
            this.cboShipClass.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(-1, 12);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(72, 16);
            this.Label9.TabIndex = 25;
            this.Label9.Text = "Order";
            // 
            // lblCarrierError
            // 
            this.lblCarrierError.AutoSize = true;
            this.lblCarrierError.ForeColor = System.Drawing.Color.Red;
            this.lblCarrierError.Location = new System.Drawing.Point(273, 83);
            this.lblCarrierError.Name = "lblCarrierError";
            this.lblCarrierError.Size = new System.Drawing.Size(0, 13);
            this.lblCarrierError.TabIndex = 42;
            // 
            // lblShipClassificationError
            // 
            this.lblShipClassificationError.AutoSize = true;
            this.lblShipClassificationError.BackColor = System.Drawing.SystemColors.Control;
            this.lblShipClassificationError.ForeColor = System.Drawing.Color.Red;
            this.lblShipClassificationError.Location = new System.Drawing.Point(429, 108);
            this.lblShipClassificationError.Name = "lblShipClassificationError";
            this.lblShipClassificationError.Size = new System.Drawing.Size(0, 13);
            this.lblShipClassificationError.TabIndex = 43;
            // 
            // lblFreightChargesError
            // 
            this.lblFreightChargesError.AutoSize = true;
            this.lblFreightChargesError.ForeColor = System.Drawing.Color.Red;
            this.lblFreightChargesError.Location = new System.Drawing.Point(273, 156);
            this.lblFreightChargesError.Name = "lblFreightChargesError";
            this.lblFreightChargesError.Size = new System.Drawing.Size(0, 13);
            this.lblFreightChargesError.TabIndex = 44;
            // 
            // lblOrderError
            // 
            this.lblOrderError.AutoSize = true;
            this.lblOrderError.ForeColor = System.Drawing.Color.Red;
            this.lblOrderError.Location = new System.Drawing.Point(192, 11);
            this.lblOrderError.Name = "lblOrderError";
            this.lblOrderError.Size = new System.Drawing.Size(0, 13);
            this.lblOrderError.TabIndex = 45;
            // 
            // lblGrossWeightError
            // 
            this.lblGrossWeightError.AutoSize = true;
            this.lblGrossWeightError.ForeColor = System.Drawing.Color.Red;
            this.lblGrossWeightError.Location = new System.Drawing.Point(192, 36);
            this.lblGrossWeightError.Name = "lblGrossWeightError";
            this.lblGrossWeightError.Size = new System.Drawing.Size(0, 13);
            this.lblGrossWeightError.TabIndex = 46;
            // 
            // lblPalletCountError
            // 
            this.lblPalletCountError.AutoSize = true;
            this.lblPalletCountError.ForeColor = System.Drawing.Color.Red;
            this.lblPalletCountError.Location = new System.Drawing.Point(192, 59);
            this.lblPalletCountError.Name = "lblPalletCountError";
            this.lblPalletCountError.Size = new System.Drawing.Size(0, 13);
            this.lblPalletCountError.TabIndex = 47;
            // 
            // lblCustomerError
            // 
            this.lblCustomerError.AutoSize = true;
            this.lblCustomerError.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerError.Location = new System.Drawing.Point(229, 132);
            this.lblCustomerError.Name = "lblCustomerError";
            this.lblCustomerError.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerError.TabIndex = 48;
            // 
            // frmBOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 455);
            this.Controls.Add(this.lblCustomerError);
            this.Controls.Add(this.lblPalletCountError);
            this.Controls.Add(this.lblGrossWeightError);
            this.Controls.Add(this.lblOrderError);
            this.Controls.Add(this.lblFreightChargesError);
            this.Controls.Add(this.lblShipClassificationError);
            this.Controls.Add(this.lblCarrierError);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.cboFreightCharges);
            this.Controls.Add(this.txtGrossWgt);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboCarrier);
            this.Controls.Add(this.txtPalletCt);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cboShipClass);
            this.Controls.Add(this.Label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBOL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill of Lading";
            this.Load += new System.EventHandler(this.frmBOL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPrevAddr;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtNotes;
        internal System.Windows.Forms.Button btnNextAddr;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCustomerSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cboFreightCharges;
        internal System.Windows.Forms.TextBox txtGrossWgt;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtOrder;
        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.GroupBox grpAddress;
        internal System.Windows.Forms.Label lblAddrLineCt;
        internal System.Windows.Forms.Label lblAddrCt;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.ComboBox cboCarrier;
        internal System.Windows.Forms.TextBox txtPalletCt;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboShipClass;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label lblCarrierError;
        private System.Windows.Forms.Label lblShipClassificationError;
        private System.Windows.Forms.Label lblFreightChargesError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblOrderError;
        private System.Windows.Forms.Label lblGrossWeightError;
        private System.Windows.Forms.Label lblPalletCountError;
        private System.Windows.Forms.Label lblCustomerError;
    }
}