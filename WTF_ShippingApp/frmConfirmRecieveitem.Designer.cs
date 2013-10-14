namespace WTF_ShippingApp
{
    partial class frmConfirmRecieveitem
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
            this.Label6 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtPalletCt = new System.Windows.Forms.TextBox();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblPalletCtError = new System.Windows.Forms.Label();
            this.lblInitialsError = new System.Windows.Forms.Label();
            this.lblOrderError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label6.Location = new System.Drawing.Point(-14, 183);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(436, 2);
            this.Label6.TabIndex = 30;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(50, 91);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(108, 20);
            this.txtOrder.TabIndex = 28;
            this.txtOrder.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(2, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 20);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Item";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(-6, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(412, 16);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "C O N F I R M    R E C E I V I N G    O F    I T E M";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(208, 193);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(308, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(2, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 20);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Qty";
            // 
            // lblItem
            // 
            this.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(50, 35);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(348, 20);
            this.lblItem.TabIndex = 21;
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQty
            // 
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(50, 63);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(108, 20);
            this.lblQty.TabIndex = 20;
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(2, 93);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 20);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Order #";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(2, 122);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 20);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Job #";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(50, 119);
            this.txtJob.Name = "txtJob";
            this.txtJob.ReadOnly = true;
            this.txtJob.Size = new System.Drawing.Size(108, 20);
            this.txtJob.TabIndex = 27;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(2, 150);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(48, 20);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "Pallets";
            // 
            // txtPalletCt
            // 
            this.txtPalletCt.Location = new System.Drawing.Point(50, 147);
            this.txtPalletCt.Name = "txtPalletCt";
            this.txtPalletCt.Size = new System.Drawing.Size(108, 20);
            this.txtPalletCt.TabIndex = 29;
            this.txtPalletCt.Text = "1";
            this.txtPalletCt.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // txtInitials
            // 
            this.txtInitials.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInitials.Location = new System.Drawing.Point(299, 65);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(88, 20);
            this.txtInitials.TabIndex = 1;
            this.txtInitials.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(201, 65);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(92, 20);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "Enter Your Intials:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalletCtError
            // 
            this.lblPalletCtError.AutoSize = true;
            this.lblPalletCtError.ForeColor = System.Drawing.Color.Red;
            this.lblPalletCtError.Location = new System.Drawing.Point(164, 150);
            this.lblPalletCtError.Name = "lblPalletCtError";
            this.lblPalletCtError.Size = new System.Drawing.Size(0, 13);
            this.lblPalletCtError.TabIndex = 47;
            // 
            // lblInitialsError
            // 
            this.lblInitialsError.AutoSize = true;
            this.lblInitialsError.ForeColor = System.Drawing.Color.Red;
            this.lblInitialsError.Location = new System.Drawing.Point(393, 67);
            this.lblInitialsError.Name = "lblInitialsError";
            this.lblInitialsError.Size = new System.Drawing.Size(0, 13);
            this.lblInitialsError.TabIndex = 48;
            // 
            // lblOrderError
            // 
            this.lblOrderError.AutoSize = true;
            this.lblOrderError.ForeColor = System.Drawing.Color.Red;
            this.lblOrderError.Location = new System.Drawing.Point(164, 94);
            this.lblOrderError.Name = "lblOrderError";
            this.lblOrderError.Size = new System.Drawing.Size(0, 13);
            this.lblOrderError.TabIndex = 49;
            // 
            // frmConfirmRecieveitem
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 221);
            this.ControlBox = false;
            this.Controls.Add(this.lblOrderError);
            this.Controls.Add(this.lblInitialsError);
            this.Controls.Add(this.lblPalletCtError);
            this.Controls.Add(this.txtInitials);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtPalletCt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmConfirmRecieveitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Receive Item";
            this.Load += new System.EventHandler(this.frmConfirmRecieveitem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtOrder;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblItem;
        internal System.Windows.Forms.Label lblQty;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtJob;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtPalletCt;
        internal System.Windows.Forms.TextBox txtInitials;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label lblPalletCtError;
        private System.Windows.Forms.Label lblInitialsError;
        private System.Windows.Forms.Label lblOrderError;
    }
}