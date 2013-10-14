namespace WTF_ShippingApp
{
    partial class frmQuickLabelPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickLabelPrinter));
            this.Label13 = new System.Windows.Forms.Label();
            this.txtAddressLabelName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblLabelType = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.cmbLabelType = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtLabelText = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabKanBan = new System.Windows.Forms.TabPage();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtKanBanLabelName = new System.Windows.Forms.TextBox();
            this.tabAddress = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrevAddr = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnNextAddr = new System.Windows.Forms.Button();
            this.lblAddrLineCt = new System.Windows.Forms.Label();
            this.lblAddrCt = new System.Windows.Forms.Label();
            this.cmbAddressType = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.cboPrinters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.tabKanBan.SuspendLayout();
            this.tabAddress.SuspendLayout();
            this.grpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.tabForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(438, 291);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(66, 13);
            this.Label13.TabIndex = 10;
            this.Label13.Text = "Label Name:";
            // 
            // txtAddressLabelName
            // 
            this.txtAddressLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLabelName.Location = new System.Drawing.Point(511, 289);
            this.txtAddressLabelName.Name = "txtAddressLabelName";
            this.txtAddressLabelName.ReadOnly = true;
            this.txtAddressLabelName.Size = new System.Drawing.Size(98, 18);
            this.txtAddressLabelName.TabIndex = 9;
            this.txtAddressLabelName.Text = "AddressLabel.btw";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(-3, 125);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(0, 13);
            this.Label7.TabIndex = 4;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(303, 17);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(39, 13);
            this.lblNo.TabIndex = 4;
            this.lblNo.Text = "Label3";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(358, 14);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(110, 20);
            this.txtNo.TabIndex = 3;
            this.txtNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNo_KeyDown);
            // 
            // lblLabelType
            // 
            this.lblLabelType.AutoSize = true;
            this.lblLabelType.Location = new System.Drawing.Point(63, 24);
            this.lblLabelType.Name = "lblLabelType";
            this.lblLabelType.Size = new System.Drawing.Size(63, 13);
            this.lblLabelType.TabIndex = 11;
            this.lblLabelType.Text = "Label Type:";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(41, 17);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(34, 13);
            this.lblAddressType.TabIndex = 1;
            this.lblAddressType.Text = "Type:";
            // 
            // cmbLabelType
            // 
            this.cmbLabelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelType.FormattingEnabled = true;
            this.cmbLabelType.Location = new System.Drawing.Point(132, 21);
            this.cmbLabelType.Name = "cmbLabelType";
            this.cmbLabelType.Size = new System.Drawing.Size(121, 21);
            this.cmbLabelType.TabIndex = 10;
            this.cmbLabelType.SelectedIndexChanged += new System.EventHandler(this.cmbLabelType_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(132, 48);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(52, 20);
            this.nudQuantity.TabIndex = 9;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(77, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtLabelText
            // 
            this.txtLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelText.Location = new System.Drawing.Point(112, 17);
            this.txtLabelText.MaxLength = 50;
            this.txtLabelText.Name = "txtLabelText";
            this.txtLabelText.Size = new System.Drawing.Size(322, 29);
            this.txtLabelText.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(46, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Label Text:";
            // 
            // tabKanBan
            // 
            this.tabKanBan.Controls.Add(this.Label2);
            this.tabKanBan.Controls.Add(this.txtKanBanLabelName);
            this.tabKanBan.Controls.Add(this.txtLabelText);
            this.tabKanBan.Controls.Add(this.Label1);
            this.tabKanBan.Location = new System.Drawing.Point(4, 22);
            this.tabKanBan.Name = "tabKanBan";
            this.tabKanBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabKanBan.Size = new System.Drawing.Size(620, 313);
            this.tabKanBan.TabIndex = 0;
            this.tabKanBan.Text = "KanBan Label";
            this.tabKanBan.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(396, 214);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Label Name:";
            // 
            // txtKanBanLabelName
            // 
            this.txtKanBanLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKanBanLabelName.Location = new System.Drawing.Point(469, 212);
            this.txtKanBanLabelName.Name = "txtKanBanLabelName";
            this.txtKanBanLabelName.ReadOnly = true;
            this.txtKanBanLabelName.Size = new System.Drawing.Size(98, 18);
            this.txtKanBanLabelName.TabIndex = 7;
            this.txtKanBanLabelName.Text = "KanBan.btw";
            // 
            // tabAddress
            // 
            this.tabAddress.BackColor = System.Drawing.SystemColors.Control;
            this.tabAddress.Controls.Add(this.btnSearch);
            this.tabAddress.Controls.Add(this.grpAddress);
            this.tabAddress.Controls.Add(this.Label13);
            this.tabAddress.Controls.Add(this.txtAddressLabelName);
            this.tabAddress.Controls.Add(this.Label7);
            this.tabAddress.Controls.Add(this.lblNo);
            this.tabAddress.Controls.Add(this.txtNo);
            this.tabAddress.Controls.Add(this.lblAddressType);
            this.tabAddress.Controls.Add(this.cmbAddressType);
            this.tabAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabAddress.Location = new System.Drawing.Point(4, 22);
            this.tabAddress.Name = "tabAddress";
            this.tabAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddress.Size = new System.Drawing.Size(620, 313);
            this.tabAddress.TabIndex = 1;
            this.tabAddress.Text = "Address Label";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(472, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 20);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.grpAddress.Location = new System.Drawing.Point(81, 53);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(424, 212);
            this.grpAddress.TabIndex = 37;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
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
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(41, 63);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
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
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.Location = new System.Drawing.Point(33, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(348, 119);
            this.txtAddress.TabIndex = 9;
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
            // cmbAddressType
            // 
            this.cmbAddressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddressType.FormattingEnabled = true;
            this.cmbAddressType.Location = new System.Drawing.Point(81, 13);
            this.cmbAddressType.Name = "cmbAddressType";
            this.cmbAddressType.Size = new System.Drawing.Size(121, 21);
            this.cmbAddressType.TabIndex = 0;
            this.cmbAddressType.SelectedIndexChanged += new System.EventHandler(this.cmbAddressType_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(512, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 45);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tabForms
            // 
            this.tabForms.Controls.Add(this.tabKanBan);
            this.tabForms.Controls.Add(this.tabAddress);
            this.tabForms.Location = new System.Drawing.Point(67, 101);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(628, 339);
            this.tabForms.TabIndex = 8;
            // 
            // cboPrinters
            // 
            this.cboPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrinters.FormattingEnabled = true;
            this.cboPrinters.Location = new System.Drawing.Point(132, 74);
            this.cboPrinters.Name = "cboPrinters";
            this.cboPrinters.Size = new System.Drawing.Size(319, 21);
            this.cboPrinters.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Printers:";
            // 
            // frmQuickLabelPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPrinters);
            this.Controls.Add(this.lblLabelType);
            this.Controls.Add(this.cmbLabelType);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tabForms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuickLabelPrinter";
            this.Text = "Quick Label Printer";
            this.Load += new System.EventHandler(this.frmQuickLabelPrinter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.tabKanBan.ResumeLayout(false);
            this.tabKanBan.PerformLayout();
            this.tabAddress.ResumeLayout(false);
            this.tabAddress.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.tabForms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtAddressLabelName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblNo;
        internal System.Windows.Forms.TextBox txtNo;
        internal System.Windows.Forms.Label lblLabelType;
        internal System.Windows.Forms.Label lblAddressType;
        internal System.Windows.Forms.ComboBox cmbLabelType;
        internal System.Windows.Forms.NumericUpDown nudQuantity;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.TextBox txtLabelText;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage tabKanBan;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtKanBanLabelName;
        internal System.Windows.Forms.TabPage tabAddress;
        internal System.Windows.Forms.ComboBox cmbAddressType;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.TabControl tabForms;
        internal System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label lblAddressError;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnPrevAddr;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Button btnNextAddr;
        internal System.Windows.Forms.Label lblAddrLineCt;
        internal System.Windows.Forms.Label lblAddrCt;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboPrinters;
        internal System.Windows.Forms.Label label3;
    }
}