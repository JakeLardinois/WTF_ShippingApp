namespace WTF_ShippingApp
{
    partial class frmTimePhasedInventoryByProjected
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimePhasedInventoryByProjected));
            this.cmiCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuPurchasedItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiUncheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageItems = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.GroupBox();
            this.lstItems = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSortSearch = new System.Windows.Forms.ComboBox();
            this.dgvRequirements = new System.Windows.Forms.DataGridView();
            this.txtDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProjectedOnHandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReferenceDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtWorkCenterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnitOfMeasure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtyOnHand = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radVendor = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radReceiving = new System.Windows.Forms.RadioButton();
            this.btnView = new System.Windows.Forms.Button();
            this.cmuPurchasedItems.SuspendLayout();
            this.Items.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmiCheckAll
            // 
            this.cmiCheckAll.Name = "cmiCheckAll";
            this.cmiCheckAll.Size = new System.Drawing.Size(137, 22);
            this.cmiCheckAll.Text = "Check All";
            this.cmiCheckAll.Click += new System.EventHandler(this.cmiCheckAll_Click);
            // 
            // cmuPurchasedItems
            // 
            this.cmuPurchasedItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiCheckAll,
            this.cmiUncheckAll});
            this.cmuPurchasedItems.Name = "cmuPurchasedItems";
            this.cmuPurchasedItems.Size = new System.Drawing.Size(138, 48);
            // 
            // cmiUncheckAll
            // 
            this.cmiUncheckAll.Name = "cmiUncheckAll";
            this.cmiUncheckAll.Size = new System.Drawing.Size(137, 22);
            this.cmiUncheckAll.Text = "Uncheck All";
            this.cmiUncheckAll.Click += new System.EventHandler(this.cmiUncheckAll_Click);
            // 
            // btnManageItems
            // 
            this.btnManageItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManageItems.Location = new System.Drawing.Point(15, 453);
            this.btnManageItems.Name = "btnManageItems";
            this.btnManageItems.Size = new System.Drawing.Size(82, 23);
            this.btnManageItems.TabIndex = 51;
            this.btnManageItems.Text = "Manage Items";
            this.btnManageItems.UseVisualStyleBackColor = true;
            this.btnManageItems.Click += new System.EventHandler(this.btnManageItems_Click);
            // 
            // Items
            // 
            this.Items.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Items.Controls.Add(this.lstItems);
            this.Items.Location = new System.Drawing.Point(532, 85);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(200, 329);
            this.Items.TabIndex = 47;
            this.Items.TabStop = false;
            this.Items.Text = "Purchased Items";
            // 
            // lstItems
            // 
            this.lstItems.ContextMenuStrip = this.cmuPurchasedItems;
            this.lstItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.HorizontalScrollbar = true;
            this.lstItems.Location = new System.Drawing.Point(3, 16);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(194, 310);
            this.lstItems.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.cboSortSearch);
            this.groupBox3.Location = new System.Drawing.Point(532, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 72);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(6, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // cboSortSearch
            // 
            this.cboSortSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSortSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortSearch.Location = new System.Drawing.Point(6, 19);
            this.cboSortSearch.Name = "cboSortSearch";
            this.cboSortSearch.Size = new System.Drawing.Size(188, 21);
            this.cboSortSearch.TabIndex = 35;
            // 
            // dgvRequirements
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequirements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDueDateColumn,
            this.txtProjectedOnHandColumn,
            this.txtQtyColumn,
            this.txtReferenceDataColumn,
            this.txtWorkCenterColumn,
            this.txtItemIDColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequirements.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequirements.Location = new System.Drawing.Point(3, 16);
            this.dgvRequirements.Name = "dgvRequirements";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequirements.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRequirements.Size = new System.Drawing.Size(508, 316);
            this.dgvRequirements.TabIndex = 0;
            // 
            // txtDueDateColumn
            // 
            this.txtDueDateColumn.DataPropertyName = "DueDate";
            this.txtDueDateColumn.HeaderText = "Due Date";
            this.txtDueDateColumn.Name = "txtDueDateColumn";
            this.txtDueDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtProjectedOnHandColumn
            // 
            this.txtProjectedOnHandColumn.DataPropertyName = "ProjectedOnHand";
            this.txtProjectedOnHandColumn.HeaderText = "Projected On Hand";
            this.txtProjectedOnHandColumn.Name = "txtProjectedOnHandColumn";
            this.txtProjectedOnHandColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtQtyColumn
            // 
            this.txtQtyColumn.DataPropertyName = "Qty";
            this.txtQtyColumn.HeaderText = "Quantity";
            this.txtQtyColumn.Name = "txtQtyColumn";
            this.txtQtyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtReferenceDataColumn
            // 
            this.txtReferenceDataColumn.DataPropertyName = "ReferenceData";
            this.txtReferenceDataColumn.HeaderText = "Reference";
            this.txtReferenceDataColumn.Name = "txtReferenceDataColumn";
            this.txtReferenceDataColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtWorkCenterColumn
            // 
            this.txtWorkCenterColumn.DataPropertyName = "WorkCenter";
            this.txtWorkCenterColumn.HeaderText = "Work Center";
            this.txtWorkCenterColumn.Name = "txtWorkCenterColumn";
            // 
            // txtItemIDColumn
            // 
            this.txtItemIDColumn.DataPropertyName = "ItemID";
            this.txtItemIDColumn.HeaderText = "ItemID";
            this.txtItemIDColumn.Name = "txtItemIDColumn";
            this.txtItemIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblUnitOfMeasure);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblQtyOnHand);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.lblItemID);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 91);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qty On Hand:";
            // 
            // lblUnitOfMeasure
            // 
            this.lblUnitOfMeasure.AutoSize = true;
            this.lblUnitOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitOfMeasure.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUnitOfMeasure.Location = new System.Drawing.Point(364, 70);
            this.lblUnitOfMeasure.Name = "lblUnitOfMeasure";
            this.lblUnitOfMeasure.Size = new System.Drawing.Size(37, 17);
            this.lblUnitOfMeasure.TabIndex = 0;
            this.lblUnitOfMeasure.Text = "Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(325, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "U/M:";
            // 
            // lblQtyOnHand
            // 
            this.lblQtyOnHand.AutoSize = true;
            this.lblQtyOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyOnHand.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQtyOnHand.Location = new System.Drawing.Point(128, 70);
            this.lblQtyOnHand.Name = "lblQtyOnHand";
            this.lblQtyOnHand.Size = new System.Drawing.Size(33, 17);
            this.lblQtyOnHand.TabIndex = 0;
            this.lblQtyOnHand.Text = "Qty";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(25, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(21, 16);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(64, 20);
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "ItemID";
            // 
            // picLoading
            // 
            this.picLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(3, 16);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(508, 316);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 1;
            this.picLoading.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvRequirements);
            this.groupBox1.Controls.Add(this.picLoading);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 335);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requirements && Purchases";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectedOnHand";
            this.dataGridViewTextBoxColumn2.HeaderText = "Projected On Hand";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ReferenceData";
            this.dataGridViewTextBoxColumn4.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // radVendor
            // 
            this.radVendor.AutoSize = true;
            this.radVendor.Location = new System.Drawing.Point(8, 14);
            this.radVendor.Name = "radVendor";
            this.radVendor.Size = new System.Drawing.Size(59, 17);
            this.radVendor.TabIndex = 46;
            this.radVendor.TabStop = true;
            this.radVendor.Text = "Vendor";
            this.radVendor.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(101, 37);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 23);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.radReceiving);
            this.groupBox4.Controls.Add(this.radVendor);
            this.groupBox4.Controls.Add(this.btnView);
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Location = new System.Drawing.Point(535, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 66);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            // 
            // radReceiving
            // 
            this.radReceiving.AutoSize = true;
            this.radReceiving.Location = new System.Drawing.Point(73, 14);
            this.radReceiving.Name = "radReceiving";
            this.radReceiving.Size = new System.Drawing.Size(73, 17);
            this.radReceiving.TabIndex = 46;
            this.radReceiving.TabStop = true;
            this.radReceiving.Text = "Receiving";
            this.radReceiving.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(6, 37);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 23);
            this.btnView.TabIndex = 45;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmTimePhasedInventoryByProjected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 482);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnManageItems);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimePhasedInventoryByProjected";
            this.Text = "Time Phased Inventory - Projected";
            this.Load += new System.EventHandler(this.frmTimePhasedInventory_Load);
            this.cmuPurchasedItems.ResumeLayout(false);
            this.Items.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cmiCheckAll;
        private System.Windows.Forms.ContextMenuStrip cmuPurchasedItems;
        private System.Windows.Forms.ToolStripMenuItem cmiUncheckAll;
        private System.Windows.Forms.Button btnManageItems;
        private System.Windows.Forms.GroupBox Items;
        private System.Windows.Forms.CheckedListBox lstItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.ComboBox cboSortSearch;
        private System.Windows.Forms.DataGridView dgvRequirements;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnitOfMeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtyOnHand;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.RadioButton radVendor;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radReceiving;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProjectedOnHandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReferenceDataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtWorkCenterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemIDColumn;
    }
}