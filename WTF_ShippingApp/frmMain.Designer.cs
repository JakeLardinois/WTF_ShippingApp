namespace WTF_ShippingApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.MenuItem5 = new System.Windows.Forms.MenuItem();
            this.MenuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.MenuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.MenuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.menuItem19,
            this.menuItem21,
            this.MenuItem7});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem6,
            this.menuItem16});
            this.MenuItem1.Text = "&File";
            // 
            // MenuItem6
            // 
            this.MenuItem6.Index = 0;
            this.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.MenuItem6.Text = "Exit";
            this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 1;
            this.menuItem16.Text = "Version";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem3});
            this.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.AltF1;
            this.MenuItem2.Text = "&Test";
            this.MenuItem2.Visible = false;
            // 
            // MenuItem3
            // 
            this.MenuItem3.Index = 0;
            this.MenuItem3.Text = "Database...";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 2;
            this.menuItem19.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem5,
            this.MenuItem8,
            this.menuItem17,
            this.menuItem11,
            this.MenuItem9});
            this.menuItem19.Text = "Shipping";
            // 
            // MenuItem5
            // 
            this.MenuItem5.Index = 0;
            this.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.MenuItem5.Text = "&Shipping Item";
            this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
            // 
            // MenuItem8
            // 
            this.MenuItem8.Index = 1;
            this.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.MenuItem8.Text = "Ship &Order";
            this.MenuItem8.Click += new System.EventHandler(this.MenuItem8_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlQ;
            this.menuItem17.Text = "&Quick Label Printer";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // MenuItem9
            // 
            this.MenuItem9.Index = 4;
            this.MenuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15,
            this.menuItem12,
            this.menuItem13,
            this.menuItem14});
            this.MenuItem9.Text = "&Tools";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 0;
            this.menuItem15.Text = "Manage Labels";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "Manage Settings";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "Manage Ship Carriers";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 3;
            this.menuItem14.Text = "Manage Ship Classifications";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 3;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10,
            this.menuItem18,
            this.menuItem4});
            this.menuItem21.Text = "Purchasing";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItem10.Text = "&Purchase Requirements";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click_1);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 1;
            this.menuItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            this.menuItem18.Text = "Time Phased Inventory - Due Date";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Time Phased Inventory - Projected Date";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // MenuItem7
            // 
            this.MenuItem7.Index = 4;
            this.MenuItem7.MdiList = true;
            this.MenuItem7.Text = "Window";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 3;
            this.menuItem11.Text = "Packing Slip History";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.MainMenu1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syteline 8 Shipping Application";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.MainMenu MainMenu1;
        internal System.Windows.Forms.MenuItem MenuItem1;
        internal System.Windows.Forms.MenuItem MenuItem6;
        internal System.Windows.Forms.MenuItem MenuItem2;
        internal System.Windows.Forms.MenuItem MenuItem3;
        internal System.Windows.Forms.MenuItem MenuItem5;
        internal System.Windows.Forms.MenuItem MenuItem8;
        internal System.Windows.Forms.MenuItem MenuItem9;
        internal System.Windows.Forms.MenuItem MenuItem7;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem21;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem11;
    }
}