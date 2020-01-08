namespace Excel2016AddIn
{
    partial class M61CF
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
            this.grpCalcMode = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radCFOnlly = new System.Windows.Forms.RadioButton();
            this.radGAAPBasisProspective = new System.Windows.Forms.RadioButton();
            this.radCFGAAPBasisInception = new System.Windows.Forms.RadioButton();
            this.radCFPVBasisProspective = new System.Windows.Forms.RadioButton();
            this.radCFPVBasisInception = new System.Windows.Forms.RadioButton();
            this.grpCapStackType = new System.Windows.Forms.GroupBox();
            this.radLegal = new System.Windows.Forms.RadioButton();
            this.radPhantom = new System.Windows.Forms.RadioButton();
            this.grpScenario = new System.Windows.Forms.GroupBox();
            this.radInitialMaturity = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            this.radCurrentMaturity = new System.Windows.Forms.RadioButton();
            this.radFullyExtended = new System.Windows.Forms.RadioButton();
            this.grpCalcMode.SuspendLayout();
            this.grpCapStackType.SuspendLayout();
            this.grpScenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCalcMode
            // 
            this.grpCalcMode.Controls.Add(this.radCFPVBasisInception);
            this.grpCalcMode.Controls.Add(this.radCFPVBasisProspective);
            this.grpCalcMode.Controls.Add(this.radCFGAAPBasisInception);
            this.grpCalcMode.Controls.Add(this.radGAAPBasisProspective);
            this.grpCalcMode.Controls.Add(this.radCFOnlly);
            this.grpCalcMode.Location = new System.Drawing.Point(12, 30);
            this.grpCalcMode.Name = "grpCalcMode";
            this.grpCalcMode.Size = new System.Drawing.Size(578, 490);
            this.grpCalcMode.TabIndex = 0;
            this.grpCalcMode.TabStop = false;
            this.grpCalcMode.Text = "Calculator Mode";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1283, 965);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(246, 92);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1587, 965);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(242, 92);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radCFOnlly
            // 
            this.radCFOnlly.AutoSize = true;
            this.radCFOnlly.Location = new System.Drawing.Point(47, 80);
            this.radCFOnlly.Name = "radCFOnlly";
            this.radCFOnlly.Size = new System.Drawing.Size(251, 36);
            this.radCFOnlly.TabIndex = 0;
            this.radCFOnlly.TabStop = true;
            this.radCFOnlly.Text = "Cash Flow Only";
            this.radCFOnlly.UseVisualStyleBackColor = true;
            // 
            // radGAAPBasisProspective
            // 
            this.radGAAPBasisProspective.AutoSize = true;
            this.radGAAPBasisProspective.Location = new System.Drawing.Point(47, 153);
            this.radGAAPBasisProspective.Name = "radGAAPBasisProspective";
            this.radGAAPBasisProspective.Size = new System.Drawing.Size(449, 36);
            this.radGAAPBasisProspective.TabIndex = 1;
            this.radGAAPBasisProspective.TabStop = true;
            this.radGAAPBasisProspective.Text = "CF + GAAP Basis (Prospective)";
            this.radGAAPBasisProspective.UseVisualStyleBackColor = true;
            // 
            // radCFGAAPBasisInception
            // 
            this.radCFGAAPBasisInception.AutoSize = true;
            this.radCFGAAPBasisInception.Location = new System.Drawing.Point(47, 229);
            this.radCFGAAPBasisInception.Name = "radCFGAAPBasisInception";
            this.radCFGAAPBasisInception.Size = new System.Drawing.Size(416, 36);
            this.radCFGAAPBasisInception.TabIndex = 2;
            this.radCFGAAPBasisInception.TabStop = true;
            this.radCFGAAPBasisInception.Text = "CF + GAAP Basis (Inception)";
            this.radCFGAAPBasisInception.UseVisualStyleBackColor = true;
            // 
            // radCFPVBasisProspective
            // 
            this.radCFPVBasisProspective.AutoSize = true;
            this.radCFPVBasisProspective.Location = new System.Drawing.Point(47, 312);
            this.radCFPVBasisProspective.Name = "radCFPVBasisProspective";
            this.radCFPVBasisProspective.Size = new System.Drawing.Size(408, 36);
            this.radCFPVBasisProspective.TabIndex = 3;
            this.radCFPVBasisProspective.TabStop = true;
            this.radCFPVBasisProspective.Text = "CF + PV Basis (Prospective)";
            this.radCFPVBasisProspective.UseVisualStyleBackColor = true;
            // 
            // radCFPVBasisInception
            // 
            this.radCFPVBasisInception.AutoSize = true;
            this.radCFPVBasisInception.Location = new System.Drawing.Point(47, 394);
            this.radCFPVBasisInception.Name = "radCFPVBasisInception";
            this.radCFPVBasisInception.Size = new System.Drawing.Size(375, 36);
            this.radCFPVBasisInception.TabIndex = 4;
            this.radCFPVBasisInception.TabStop = true;
            this.radCFPVBasisInception.Text = "CF + PV Basis (Inception)";
            this.radCFPVBasisInception.UseVisualStyleBackColor = true;
            // 
            // grpCapStackType
            // 
            this.grpCapStackType.Controls.Add(this.radPhantom);
            this.grpCapStackType.Controls.Add(this.radLegal);
            this.grpCapStackType.Location = new System.Drawing.Point(12, 551);
            this.grpCapStackType.Name = "grpCapStackType";
            this.grpCapStackType.Size = new System.Drawing.Size(578, 229);
            this.grpCapStackType.TabIndex = 3;
            this.grpCapStackType.TabStop = false;
            this.grpCapStackType.Text = "Cap Stack Type";
            // 
            // radLegal
            // 
            this.radLegal.AutoSize = true;
            this.radLegal.Location = new System.Drawing.Point(47, 77);
            this.radLegal.Name = "radLegal";
            this.radLegal.Size = new System.Drawing.Size(123, 36);
            this.radLegal.TabIndex = 0;
            this.radLegal.TabStop = true;
            this.radLegal.Text = "Legal";
            this.radLegal.UseVisualStyleBackColor = true;
            // 
            // radPhantom
            // 
            this.radPhantom.AutoSize = true;
            this.radPhantom.Location = new System.Drawing.Point(47, 149);
            this.radPhantom.Name = "radPhantom";
            this.radPhantom.Size = new System.Drawing.Size(166, 36);
            this.radPhantom.TabIndex = 1;
            this.radPhantom.TabStop = true;
            this.radPhantom.Text = "Phantom";
            this.radPhantom.UseVisualStyleBackColor = true;
            // 
            // grpScenario
            // 
            this.grpScenario.Controls.Add(this.radCurrentMaturity);
            this.grpScenario.Controls.Add(this.radFullyExtended);
            this.grpScenario.Controls.Add(this.radInitialMaturity);
            this.grpScenario.Controls.Add(this.radDefault);
            this.grpScenario.Location = new System.Drawing.Point(8, 794);
            this.grpScenario.Name = "grpScenario";
            this.grpScenario.Size = new System.Drawing.Size(578, 319);
            this.grpScenario.TabIndex = 4;
            this.grpScenario.TabStop = false;
            this.grpScenario.Text = "Scenario";
            // 
            // radInitialMaturity
            // 
            this.radInitialMaturity.AutoSize = true;
            this.radInitialMaturity.Location = new System.Drawing.Point(47, 142);
            this.radInitialMaturity.Name = "radInitialMaturity";
            this.radInitialMaturity.Size = new System.Drawing.Size(228, 36);
            this.radInitialMaturity.TabIndex = 1;
            this.radInitialMaturity.TabStop = true;
            this.radInitialMaturity.Text = "Initial Maturity";
            this.radInitialMaturity.UseVisualStyleBackColor = true;
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Location = new System.Drawing.Point(47, 77);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(143, 36);
            this.radDefault.TabIndex = 0;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Default";
            this.radDefault.UseVisualStyleBackColor = true;
            // 
            // radCurrentMaturity
            // 
            this.radCurrentMaturity.AutoSize = true;
            this.radCurrentMaturity.Location = new System.Drawing.Point(47, 253);
            this.radCurrentMaturity.Name = "radCurrentMaturity";
            this.radCurrentMaturity.Size = new System.Drawing.Size(254, 36);
            this.radCurrentMaturity.TabIndex = 3;
            this.radCurrentMaturity.TabStop = true;
            this.radCurrentMaturity.Text = "Current Maturity";
            this.radCurrentMaturity.UseVisualStyleBackColor = true;
            // 
            // radFullyExtended
            // 
            this.radFullyExtended.AutoSize = true;
            this.radFullyExtended.Location = new System.Drawing.Point(47, 193);
            this.radFullyExtended.Name = "radFullyExtended";
            this.radFullyExtended.Size = new System.Drawing.Size(477, 36);
            this.radFullyExtended.TabIndex = 2;
            this.radFullyExtended.TabStop = true;
            this.radFullyExtended.Text = "Fully Extended (with Prepayment)";
            this.radFullyExtended.UseVisualStyleBackColor = true;
            // 
            // M61CF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 1125);
            this.Controls.Add(this.grpScenario);
            this.Controls.Add(this.grpCapStackType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.grpCalcMode);
            this.Name = "M61CF";
            this.Text = "M61 CF Parameters";
            this.grpCalcMode.ResumeLayout(false);
            this.grpCalcMode.PerformLayout();
            this.grpCapStackType.ResumeLayout(false);
            this.grpCapStackType.PerformLayout();
            this.grpScenario.ResumeLayout(false);
            this.grpScenario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCalcMode;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radCFPVBasisInception;
        private System.Windows.Forms.RadioButton radCFPVBasisProspective;
        private System.Windows.Forms.RadioButton radCFGAAPBasisInception;
        private System.Windows.Forms.RadioButton radGAAPBasisProspective;
        private System.Windows.Forms.RadioButton radCFOnlly;
        private System.Windows.Forms.GroupBox grpCapStackType;
        private System.Windows.Forms.RadioButton radPhantom;
        private System.Windows.Forms.RadioButton radLegal;
        private System.Windows.Forms.GroupBox grpScenario;
        private System.Windows.Forms.RadioButton radCurrentMaturity;
        private System.Windows.Forms.RadioButton radFullyExtended;
        private System.Windows.Forms.RadioButton radInitialMaturity;
        private System.Windows.Forms.RadioButton radDefault;
    }
}