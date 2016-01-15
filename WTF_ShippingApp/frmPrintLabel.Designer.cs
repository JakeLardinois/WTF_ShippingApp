namespace WTF_ShippingApp
{
    partial class frmPrintLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintLabel));
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.udCopies = new System.Windows.Forms.NumericUpDown();
            this.grpMultiple = new System.Windows.Forms.GroupBox();
            this.lblQtyError = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.chkMultiple = new System.Windows.Forms.CheckBox();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtCartons = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrevAddr = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnNextAddr = new System.Windows.Forms.Button();
            this.lblAddrLineCt = new System.Windows.Forms.Label();
            this.lblAddrCt = new System.Windows.Forms.Label();
            this.cboLabels = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblLabelError = new System.Windows.Forms.Label();
            this.cboPrinters = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.udCopies)).BeginInit();
            this.grpMultiple.SuspendLayout();
            this.grpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(97, 133);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(70, 16);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Print Multiple";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(24, 25);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(24, 16);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Qty";
            // 
            // udCopies
            // 
            this.udCopies.Location = new System.Drawing.Point(152, 22);
            this.udCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCopies.Name = "udCopies";
            this.udCopies.Size = new System.Drawing.Size(56, 20);
            this.udCopies.TabIndex = 7;
            this.udCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpMultiple
            // 
            this.grpMultiple.Controls.Add(this.lblQtyError);
            this.grpMultiple.Controls.Add(this.udCopies);
            this.grpMultiple.Controls.Add(this.Label4);
            this.grpMultiple.Controls.Add(this.Label6);
            this.grpMultiple.Controls.Add(this.txtQty);
            this.grpMultiple.Enabled = false;
            this.grpMultiple.Location = new System.Drawing.Point(70, 134);
            this.grpMultiple.Name = "grpMultiple";
            this.grpMultiple.Size = new System.Drawing.Size(320, 52);
            this.grpMultiple.TabIndex = 30;
            this.grpMultiple.TabStop = false;
            this.grpMultiple.Text = "               ";
            // 
            // lblQtyError
            // 
            this.lblQtyError.AutoSize = true;
            this.lblQtyError.ForeColor = System.Drawing.Color.Red;
            this.lblQtyError.Location = new System.Drawing.Point(8, 24);
            this.lblQtyError.Name = "lblQtyError";
            this.lblQtyError.Size = new System.Drawing.Size(0, 13);
            this.lblQtyError.TabIndex = 51;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(108, 24);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 16);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Copies";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(48, 22);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(44, 20);
            this.txtQty.TabIndex = 10;
            this.txtQty.Text = "1";
            this.txtQty.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // chkMultiple
            // 
            this.chkMultiple.Location = new System.Drawing.Point(81, 132);
            this.chkMultiple.Name = "chkMultiple";
            this.chkMultiple.Size = new System.Drawing.Size(16, 16);
            this.chkMultiple.TabIndex = 22;
            this.chkMultiple.CheckedChanged += new System.EventHandler(this.chkMultiple_CheckedChanged);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerSearch.Image")));
            this.btnCustomerSearch.Location = new System.Drawing.Point(175, 43);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(28, 20);
            this.btnCustomerSearch.TabIndex = 29;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomer.Location = new System.Drawing.Point(75, 43);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(92, 20);
            this.txtCustomer.TabIndex = 27;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // txtCartons
            // 
            this.txtCartons.Location = new System.Drawing.Point(70, 198);
            this.txtCartons.Name = "txtCartons";
            this.txtCartons.Size = new System.Drawing.Size(112, 20);
            this.txtCartons.TabIndex = 28;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(178, 458);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 24);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print...";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.PictureBox1);
            this.grpAddress.Controls.Add(this.btnPrevAddr);
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.Controls.Add(this.btnNextAddr);
            this.grpAddress.Controls.Add(this.lblAddrLineCt);
            this.grpAddress.Controls.Add(this.lblAddrCt);
            this.grpAddress.Location = new System.Drawing.Point(6, 258);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(384, 188);
            this.grpAddress.TabIndex = 23;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(16, 56);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // btnPrevAddr
            // 
            this.btnPrevAddr.Location = new System.Drawing.Point(60, 24);
            this.btnPrevAddr.Name = "btnPrevAddr";
            this.btnPrevAddr.Size = new System.Drawing.Size(76, 20);
            this.btnPrevAddr.TabIndex = 9;
            this.btnPrevAddr.Text = "<< Previous";
            this.btnPrevAddr.Click += new System.EventHandler(this.btnPrevAddr_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.Location = new System.Drawing.Point(12, 80);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(360, 92);
            this.txtAddress.TabIndex = 7;
            // 
            // btnNextAddr
            // 
            this.btnNextAddr.Location = new System.Drawing.Point(252, 24);
            this.btnNextAddr.Name = "btnNextAddr";
            this.btnNextAddr.Size = new System.Drawing.Size(76, 20);
            this.btnNextAddr.TabIndex = 9;
            this.btnNextAddr.Text = "Next >>";
            this.btnNextAddr.Click += new System.EventHandler(this.btnNextAddr_Click);
            // 
            // lblAddrLineCt
            // 
            this.lblAddrLineCt.ForeColor = System.Drawing.Color.Blue;
            this.lblAddrLineCt.Location = new System.Drawing.Point(30, 58);
            this.lblAddrLineCt.Name = "lblAddrLineCt";
            this.lblAddrLineCt.Size = new System.Drawing.Size(342, 16);
            this.lblAddrLineCt.TabIndex = 8;
            this.lblAddrLineCt.Text = "IMPORTANT:  Maximum number of address lines for the label is 3";
            this.lblAddrLineCt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddrCt
            // 
            this.lblAddrCt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddrCt.Location = new System.Drawing.Point(56, 20);
            this.lblAddrCt.Name = "lblAddrCt";
            this.lblAddrCt.Size = new System.Drawing.Size(276, 28);
            this.lblAddrCt.TabIndex = 8;
            this.lblAddrCt.Text = "Address 1 of 1";
            this.lblAddrCt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLabels
            // 
            this.cboLabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLabels.Location = new System.Drawing.Point(75, 67);
            this.cboLabels.Name = "cboLabels";
            this.cboLabels.Size = new System.Drawing.Size(320, 21);
            this.cboLabels.TabIndex = 21;
            this.cboLabels.SelectedIndexChanged += new System.EventHandler(this.cboLabels_SelectedIndexChanged);
            this.cboLabels.Validating += new System.ComponentModel.CancelEventHandler(this.Validate);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(11, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 20);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Item";
            // 
            // lblItem
            // 
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(75, 11);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(316, 20);
            this.lblItem.TabIndex = 14;
            this.lblItem.Text = "Item";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(11, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 20);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Customer";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(11, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 20);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Label";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(6, 202);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 20);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "Cartons";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(70, 226);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(112, 20);
            this.txtSupplier.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(6, 230);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 20);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Supplier";
            // 
            // lblLabelError
            // 
            this.lblLabelError.AutoSize = true;
            this.lblLabelError.ForeColor = System.Drawing.Color.Red;
            this.lblLabelError.Location = new System.Drawing.Point(53, 71);
            this.lblLabelError.Name = "lblLabelError";
            this.lblLabelError.Size = new System.Drawing.Size(0, 13);
            this.lblLabelError.TabIndex = 52;
            // 
            // cboPrinters
            // 
            this.cboPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrinters.FormattingEnabled = true;
            this.cboPrinters.Location = new System.Drawing.Point(75, 94);
            this.cboPrinters.Name = "cboPrinters";
            this.cboPrinters.Size = new System.Drawing.Size(319, 21);
            this.cboPrinters.TabIndex = 53;
            // 
            // frmPrintLabel
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 491);
            this.Controls.Add(this.cboPrinters);
            this.Controls.Add(this.lblLabelError);
            this.Controls.Add(this.chkMultiple);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.grpMultiple);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtCartons);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.cboLabels);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Label";
            this.Load += new System.EventHandler(this.frmPrintLabel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrintLabel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.udCopies)).EndInit();
            this.grpMultiple.ResumeLayout(false);
            this.grpMultiple.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.NumericUpDown udCopies;
        internal System.Windows.Forms.GroupBox grpMultiple;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.CheckBox chkMultiple;
        internal System.Windows.Forms.Button btnCustomerSearch;
        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.TextBox txtCartons;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.GroupBox grpAddress;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnPrevAddr;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Button btnNextAddr;
        internal System.Windows.Forms.Label lblAddrLineCt;
        internal System.Windows.Forms.Label lblAddrCt;
        internal System.Windows.Forms.ComboBox cboLabels;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblItem;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSupplier;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label lblQtyError;
        private System.Windows.Forms.Label lblLabelError;
        private System.Windows.Forms.ComboBox cboPrinters;
    }
}