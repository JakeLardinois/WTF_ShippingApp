namespace WTF_ShippingApp
{
    partial class frmShipping
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipping));
            this.lblJobSearch = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.btnShip = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBlanket = new System.Windows.Forms.CheckBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.lblQtyReleased = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnPrintLabel = new System.Windows.Forms.Button();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPcWeightError = new System.Windows.Forms.Label();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.lblGrossWeightError = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtTareWgt = new System.Windows.Forms.TextBox();
            this.txtGrossWgt = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.txtPieceWgt = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnPrintBOL = new System.Windows.Forms.Button();
            this.btnGetJobs = new System.Windows.Forms.Button();
            this.mnuShipping = new System.Windows.Forms.MainMenu(this.components);
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.chkIsSubItem = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtyOnHand = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobSearch
            // 
            this.lblJobSearch.Location = new System.Drawing.Point(236, 32);
            this.lblJobSearch.Name = "lblJobSearch";
            this.lblJobSearch.Size = new System.Drawing.Size(144, 20);
            this.lblJobSearch.TabIndex = 3;
            this.lblJobSearch.Text = "Searching for job...";
            this.lblJobSearch.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(10, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 20);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Item Number";
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label11.Location = new System.Drawing.Point(-14, 38);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(772, 2);
            this.Label11.TabIndex = 20;
            // 
            // btnShip
            // 
            this.btnShip.Image = ((System.Drawing.Image)(resources.GetObject("btnShip.Image")));
            this.btnShip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShip.Location = new System.Drawing.Point(236, 4);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(100, 24);
            this.btnShip.TabIndex = 10;
            this.btnShip.Text = "            Ship...";
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblJobSearch);
            this.GroupBox1.Controls.Add(this.chkBlanket);
            this.GroupBox1.Controls.Add(this.txtJob);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.lblOrder);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.lblDueDate);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.lblQtyReleased);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.lblCustomer);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(10, 110);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 156);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Job";
            // 
            // chkBlanket
            // 
            this.chkBlanket.Location = new System.Drawing.Point(240, 52);
            this.chkBlanket.Name = "chkBlanket";
            this.chkBlanket.Size = new System.Drawing.Size(140, 20);
            this.chkBlanket.TabIndex = 2;
            this.chkBlanket.Text = "Blanket Order";
            this.chkBlanket.Visible = false;
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(104, 28);
            this.txtJob.Name = "txtJob";
            this.txtJob.ReadOnly = true;
            this.txtJob.Size = new System.Drawing.Size(128, 20);
            this.txtJob.TabIndex = 1;
            this.txtJob.Text = "<none selected>";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Job #";
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(16, 52);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 20);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Order #";
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(16, 52);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 20);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Job Number";
            // 
            // lblOrder
            // 
            this.lblOrder.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(104, 52);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(128, 20);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Shipping";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(16, 100);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(80, 20);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "Due Date";
            // 
            // lblDueDate
            // 
            this.lblDueDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(104, 100);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(128, 20);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(16, 124);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(80, 20);
            this.Label14.TabIndex = 0;
            this.Label14.Text = "Qty Released";
            // 
            // lblQtyReleased
            // 
            this.lblQtyReleased.BackColor = System.Drawing.SystemColors.Control;
            this.lblQtyReleased.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQtyReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyReleased.Location = new System.Drawing.Point(104, 124);
            this.lblQtyReleased.Name = "lblQtyReleased";
            this.lblQtyReleased.Size = new System.Drawing.Size(128, 20);
            this.lblQtyReleased.TabIndex = 0;
            this.lblQtyReleased.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(16, 76);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(80, 20);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Customer";
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(104, 76);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(272, 20);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintLabel.Image")));
            this.btnPrintLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintLabel.Location = new System.Drawing.Point(12, 4);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Size = new System.Drawing.Size(100, 24);
            this.btnPrintLabel.TabIndex = 9;
            this.btnPrintLabel.Text = "      Print Label...";
            this.btnPrintLabel.Click += new System.EventHandler(this.btnPrintLabel_Click);
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.Location = new System.Drawing.Point(82, 82);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(364, 20);
            this.lblItemDescription.TabIndex = 22;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lblPcWeightError);
            this.GroupBox2.Controls.Add(this.lblQuantityError);
            this.GroupBox2.Controls.Add(this.lblGrossWeightError);
            this.GroupBox2.Controls.Add(this.txtQuantity);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.txtTareWgt);
            this.GroupBox2.Controls.Add(this.txtGrossWgt);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Controls.Add(this.txtPieceWgt);
            this.GroupBox2.Controls.Add(this.Button3);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(10, 278);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(440, 124);
            this.GroupBox2.TabIndex = 23;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Shipping ";
            // 
            // lblPcWeightError
            // 
            this.lblPcWeightError.AutoSize = true;
            this.lblPcWeightError.ForeColor = System.Drawing.Color.Red;
            this.lblPcWeightError.Location = new System.Drawing.Point(258, 72);
            this.lblPcWeightError.Name = "lblPcWeightError";
            this.lblPcWeightError.Size = new System.Drawing.Size(0, 13);
            this.lblPcWeightError.TabIndex = 52;
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(210, 95);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(0, 13);
            this.lblQuantityError.TabIndex = 51;
            // 
            // lblGrossWeightError
            // 
            this.lblGrossWeightError.AutoSize = true;
            this.lblGrossWeightError.ForeColor = System.Drawing.Color.Red;
            this.lblGrossWeightError.Location = new System.Drawing.Point(258, 48);
            this.lblGrossWeightError.Name = "lblGrossWeightError";
            this.lblGrossWeightError.Size = new System.Drawing.Size(0, 13);
            this.lblGrossWeightError.TabIndex = 50;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(104, 92);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBoxIsNumeric);
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(16, 96);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 20);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Quantity";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 20);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Tare Wgt";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(208, 20);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(44, 20);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "READ";
            // 
            // txtTareWgt
            // 
            this.txtTareWgt.Location = new System.Drawing.Point(104, 20);
            this.txtTareWgt.Name = "txtTareWgt";
            this.txtTareWgt.Size = new System.Drawing.Size(100, 20);
            this.txtTareWgt.TabIndex = 1;
            this.txtTareWgt.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBoxIsNumeric);
            // 
            // txtGrossWgt
            // 
            this.txtGrossWgt.Location = new System.Drawing.Point(104, 44);
            this.txtGrossWgt.Name = "txtGrossWgt";
            this.txtGrossWgt.Size = new System.Drawing.Size(100, 20);
            this.txtGrossWgt.TabIndex = 1;
            this.txtGrossWgt.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBoxIsNumeric);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 20);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Gross Wgt";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(208, 44);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(44, 20);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "READ";
            // 
            // txtPieceWgt
            // 
            this.txtPieceWgt.Location = new System.Drawing.Point(104, 68);
            this.txtPieceWgt.Name = "txtPieceWgt";
            this.txtPieceWgt.Size = new System.Drawing.Size(100, 20);
            this.txtPieceWgt.TabIndex = 1;
            this.txtPieceWgt.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBoxIsNumeric);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(208, 68);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(44, 20);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "READ";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 72);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 20);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Piece Wgt";
            // 
            // btnReceive
            // 
            this.btnReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnReceive.Image")));
            this.btnReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceive.Location = new System.Drawing.Point(124, 4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(100, 24);
            this.btnReceive.TabIndex = 9;
            this.btnReceive.Text = "           Receive...";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(348, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 24);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "       History...";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnShip);
            this.Panel1.Controls.Add(this.btnPrintLabel);
            this.Panel1.Controls.Add(this.btnReceive);
            this.Panel1.Controls.Add(this.btnHistory);
            this.Panel1.Controls.Add(this.btnPrintBOL);
            this.Panel1.Location = new System.Drawing.Point(2, 6);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(568, 32);
            this.Panel1.TabIndex = 21;
            // 
            // btnPrintBOL
            // 
            this.btnPrintBOL.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBOL.Image")));
            this.btnPrintBOL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintBOL.Location = new System.Drawing.Point(460, 4);
            this.btnPrintBOL.Name = "btnPrintBOL";
            this.btnPrintBOL.Size = new System.Drawing.Size(100, 24);
            this.btnPrintBOL.TabIndex = 9;
            this.btnPrintBOL.Text = "      Print BOL...";
            this.btnPrintBOL.Click += new System.EventHandler(this.btnPrintBOL_Click);
            // 
            // btnGetJobs
            // 
            this.btnGetJobs.Location = new System.Drawing.Point(190, 58);
            this.btnGetJobs.Name = "btnGetJobs";
            this.btnGetJobs.Size = new System.Drawing.Size(72, 20);
            this.btnGetJobs.TabIndex = 18;
            this.btnGetJobs.Text = "List Jobs";
            this.btnGetJobs.Click += new System.EventHandler(this.btnGetJobs_Click);
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemNumber.Location = new System.Drawing.Point(82, 58);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(100, 20);
            this.txtItemNumber.TabIndex = 16;
            this.txtItemNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNumber_KeyDown);
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSearch.Image")));
            this.btnItemSearch.Location = new System.Drawing.Point(269, 58);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(28, 20);
            this.btnItemSearch.TabIndex = 17;
            this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
            // 
            // chkIsSubItem
            // 
            this.chkIsSubItem.Location = new System.Drawing.Point(326, 60);
            this.chkIsSubItem.Name = "chkIsSubItem";
            this.chkIsSubItem.Size = new System.Drawing.Size(80, 16);
            this.chkIsSubItem.TabIndex = 24;
            this.chkIsSubItem.Text = "Sub Item";
            this.chkIsSubItem.CheckedChanged += new System.EventHandler(this.chkIsMFG_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Qty On Hand:";
            // 
            // txtQtyOnHand
            // 
            this.txtQtyOnHand.Location = new System.Drawing.Point(483, 56);
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.ReadOnly = true;
            this.txtQtyOnHand.Size = new System.Drawing.Size(87, 20);
            this.txtQtyOnHand.TabIndex = 26;
            // 
            // frmShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 452);
            this.Controls.Add(this.txtQtyOnHand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnGetJobs);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.btnItemSearch);
            this.Controls.Add(this.chkIsSubItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mnuShipping;
            this.Name = "frmShipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping";
            this.Load += new System.EventHandler(this.frmShipping_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblJobSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button btnShip;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkBlanket;
        internal System.Windows.Forms.TextBox txtJob;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label lblOrder;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label lblDueDate;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label lblQtyReleased;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblCustomer;
        internal System.Windows.Forms.Button btnPrintLabel;
        internal System.Windows.Forms.Label lblItemDescription;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtTareWgt;
        internal System.Windows.Forms.TextBox txtGrossWgt;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txtPieceWgt;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnReceive;
        internal System.Windows.Forms.Button btnHistory;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnPrintBOL;
        internal System.Windows.Forms.Button btnGetJobs;
        internal System.Windows.Forms.MainMenu mnuShipping;
        internal System.Windows.Forms.Button btnItemSearch;
        internal System.Windows.Forms.CheckBox chkIsSubItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtyOnHand;
        private System.Windows.Forms.Label lblGrossWeightError;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblPcWeightError;
        internal System.Windows.Forms.TextBox txtItemNumber;
    }
}