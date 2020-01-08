namespace Excel2016AddIn
{
    partial class M61Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public M61Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabN61 = this.Factory.CreateRibbonTab();
            this.grpM61CF = this.Factory.CreateRibbonGroup();
            this.btnRunCF = this.Factory.CreateRibbonButton();
            this.btnAbout = this.Factory.CreateRibbonButton();
            this.lblTime = this.Factory.CreateRibbonLabel();
            this.tabN61.SuspendLayout();
            this.grpM61CF.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabN61
            // 
            this.tabN61.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabN61.Groups.Add(this.grpM61CF);
            this.tabN61.Label = "M61";
            this.tabN61.Name = "tabN61";
            // 
            // grpM61CF
            // 
            this.grpM61CF.Items.Add(this.lblTime);
            this.grpM61CF.Items.Add(this.btnRunCF);
            this.grpM61CF.Items.Add(this.btnAbout);
            this.grpM61CF.Label = "M61 Cash Flow";
            this.grpM61CF.Name = "grpM61CF";
            // 
            // btnRunCF
            // 
            this.btnRunCF.Label = "Run Cash Flow";
            this.btnRunCF.Name = "btnRunCF";
            this.btnRunCF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRunCF_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Label = "About M61";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAbout_Click);
            // 
            // lblTime
            // 
            this.lblTime.Label = "Load Time: ";
            this.lblTime.Name = "lblTime";
            // 
            // M61Ribbon
            // 
            this.Name = "M61Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabN61);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.M61Ribbon_Load);
            this.tabN61.ResumeLayout(false);
            this.tabN61.PerformLayout();
            this.grpM61CF.ResumeLayout(false);
            this.grpM61CF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabN61;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpM61CF;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRunCF;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAbout;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel lblTime;
    }

    partial class ThisRibbonCollection
    {
        internal M61Ribbon M61Ribbon
        {
            get { return this.GetRibbon<M61Ribbon>(); }
        }
    }
}
