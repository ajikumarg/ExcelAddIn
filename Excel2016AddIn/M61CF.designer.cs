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
            this.radCFPVBasisInception = new System.Windows.Forms.RadioButton();
            this.radCFPVBasisProspective = new System.Windows.Forms.RadioButton();
            this.radCFGAAPBasisInception = new System.Windows.Forms.RadioButton();
            this.radGAAPBasisProspective = new System.Windows.Forms.RadioButton();
            this.radCFOnlly = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCapStackType = new System.Windows.Forms.GroupBox();
            this.radPhantom = new System.Windows.Forms.RadioButton();
            this.radLegal = new System.Windows.Forms.RadioButton();
            this.grpScenario = new System.Windows.Forms.GroupBox();
            this.radCurrentMaturity = new System.Windows.Forms.RadioButton();
            this.radFullyExtended = new System.Windows.Forms.RadioButton();
            this.radInitialMaturity = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            this.grpCalc = new System.Windows.Forms.GroupBox();
            this.radCalcNo = new System.Windows.Forms.RadioButton();
            this.radCalc = new System.Windows.Forms.RadioButton();
            this.radSaveNo = new System.Windows.Forms.RadioButton();
            this.radSave = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCFOutput = new System.Windows.Forms.GroupBox();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.chkPeriodic = new System.Windows.Forms.CheckBox();
            this.lstFieldsTxn = new System.Windows.Forms.ListBox();
            this.lstFieldsPeriodic = new System.Windows.Forms.ListBox();
            this.grpCalcMode.SuspendLayout();
            this.grpCapStackType.SuspendLayout();
            this.grpScenario.SuspendLayout();
            this.grpCalc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCFOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCalcMode
            // 
            this.grpCalcMode.Controls.Add(this.radCFPVBasisInception);
            this.grpCalcMode.Controls.Add(this.radCFPVBasisProspective);
            this.grpCalcMode.Controls.Add(this.radCFGAAPBasisInception);
            this.grpCalcMode.Controls.Add(this.radGAAPBasisProspective);
            this.grpCalcMode.Controls.Add(this.radCFOnlly);
            this.grpCalcMode.Location = new System.Drawing.Point(4, 13);
            this.grpCalcMode.Margin = new System.Windows.Forms.Padding(1);
            this.grpCalcMode.Name = "grpCalcMode";
            this.grpCalcMode.Padding = new System.Windows.Forms.Padding(1);
            this.grpCalcMode.Size = new System.Drawing.Size(217, 205);
            this.grpCalcMode.TabIndex = 0;
            this.grpCalcMode.TabStop = false;
            this.grpCalcMode.Text = "Calculator Mode";
            // 
            // radCFPVBasisInception
            // 
            this.radCFPVBasisInception.AutoSize = true;
            this.radCFPVBasisInception.Location = new System.Drawing.Point(18, 165);
            this.radCFPVBasisInception.Margin = new System.Windows.Forms.Padding(1);
            this.radCFPVBasisInception.Name = "radCFPVBasisInception";
            this.radCFPVBasisInception.Size = new System.Drawing.Size(145, 17);
            this.radCFPVBasisInception.TabIndex = 4;
            this.radCFPVBasisInception.TabStop = true;
            this.radCFPVBasisInception.Text = "CF + PV Basis (Inception)";
            this.radCFPVBasisInception.UseVisualStyleBackColor = true;
            // 
            // radCFPVBasisProspective
            // 
            this.radCFPVBasisProspective.AutoSize = true;
            this.radCFPVBasisProspective.Location = new System.Drawing.Point(18, 131);
            this.radCFPVBasisProspective.Margin = new System.Windows.Forms.Padding(1);
            this.radCFPVBasisProspective.Name = "radCFPVBasisProspective";
            this.radCFPVBasisProspective.Size = new System.Drawing.Size(157, 17);
            this.radCFPVBasisProspective.TabIndex = 3;
            this.radCFPVBasisProspective.TabStop = true;
            this.radCFPVBasisProspective.Text = "CF + PV Basis (Prospective)";
            this.radCFPVBasisProspective.UseVisualStyleBackColor = true;
            // 
            // radCFGAAPBasisInception
            // 
            this.radCFGAAPBasisInception.AutoSize = true;
            this.radCFGAAPBasisInception.Location = new System.Drawing.Point(18, 96);
            this.radCFGAAPBasisInception.Margin = new System.Windows.Forms.Padding(1);
            this.radCFGAAPBasisInception.Name = "radCFGAAPBasisInception";
            this.radCFGAAPBasisInception.Size = new System.Drawing.Size(160, 17);
            this.radCFGAAPBasisInception.TabIndex = 2;
            this.radCFGAAPBasisInception.TabStop = true;
            this.radCFGAAPBasisInception.Text = "CF + GAAP Basis (Inception)";
            this.radCFGAAPBasisInception.UseVisualStyleBackColor = true;
            // 
            // radGAAPBasisProspective
            // 
            this.radGAAPBasisProspective.AutoSize = true;
            this.radGAAPBasisProspective.Location = new System.Drawing.Point(18, 64);
            this.radGAAPBasisProspective.Margin = new System.Windows.Forms.Padding(1);
            this.radGAAPBasisProspective.Name = "radGAAPBasisProspective";
            this.radGAAPBasisProspective.Size = new System.Drawing.Size(172, 17);
            this.radGAAPBasisProspective.TabIndex = 1;
            this.radGAAPBasisProspective.TabStop = true;
            this.radGAAPBasisProspective.Text = "CF + GAAP Basis (Prospective)";
            this.radGAAPBasisProspective.UseVisualStyleBackColor = true;
            // 
            // radCFOnlly
            // 
            this.radCFOnlly.AutoSize = true;
            this.radCFOnlly.Location = new System.Drawing.Point(18, 34);
            this.radCFOnlly.Margin = new System.Windows.Forms.Padding(1);
            this.radCFOnlly.Name = "radCFOnlly";
            this.radCFOnlly.Size = new System.Drawing.Size(98, 17);
            this.radCFOnlly.TabIndex = 0;
            this.radCFOnlly.TabStop = true;
            this.radCFOnlly.Text = "Cash Flow Only";
            this.radCFOnlly.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(422, 428);
            this.btnRun.Margin = new System.Windows.Forms.Padding(1);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(92, 39);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(536, 428);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCapStackType
            // 
            this.grpCapStackType.Controls.Add(this.radPhantom);
            this.grpCapStackType.Controls.Add(this.radLegal);
            this.grpCapStackType.Location = new System.Drawing.Point(4, 231);
            this.grpCapStackType.Margin = new System.Windows.Forms.Padding(1);
            this.grpCapStackType.Name = "grpCapStackType";
            this.grpCapStackType.Padding = new System.Windows.Forms.Padding(1);
            this.grpCapStackType.Size = new System.Drawing.Size(217, 96);
            this.grpCapStackType.TabIndex = 3;
            this.grpCapStackType.TabStop = false;
            this.grpCapStackType.Text = "Cap Stack Type";
            // 
            // radPhantom
            // 
            this.radPhantom.AutoSize = true;
            this.radPhantom.Location = new System.Drawing.Point(18, 62);
            this.radPhantom.Margin = new System.Windows.Forms.Padding(1);
            this.radPhantom.Name = "radPhantom";
            this.radPhantom.Size = new System.Drawing.Size(67, 17);
            this.radPhantom.TabIndex = 1;
            this.radPhantom.TabStop = true;
            this.radPhantom.Text = "Phantom";
            this.radPhantom.UseVisualStyleBackColor = true;
            // 
            // radLegal
            // 
            this.radLegal.AutoSize = true;
            this.radLegal.Location = new System.Drawing.Point(18, 32);
            this.radLegal.Margin = new System.Windows.Forms.Padding(1);
            this.radLegal.Name = "radLegal";
            this.radLegal.Size = new System.Drawing.Size(51, 17);
            this.radLegal.TabIndex = 0;
            this.radLegal.TabStop = true;
            this.radLegal.Text = "Legal";
            this.radLegal.UseVisualStyleBackColor = true;
            // 
            // grpScenario
            // 
            this.grpScenario.Controls.Add(this.radCurrentMaturity);
            this.grpScenario.Controls.Add(this.radFullyExtended);
            this.grpScenario.Controls.Add(this.radInitialMaturity);
            this.grpScenario.Controls.Add(this.radDefault);
            this.grpScenario.Location = new System.Drawing.Point(3, 333);
            this.grpScenario.Margin = new System.Windows.Forms.Padding(1);
            this.grpScenario.Name = "grpScenario";
            this.grpScenario.Padding = new System.Windows.Forms.Padding(1);
            this.grpScenario.Size = new System.Drawing.Size(217, 134);
            this.grpScenario.TabIndex = 4;
            this.grpScenario.TabStop = false;
            this.grpScenario.Text = "Scenario";
            // 
            // radCurrentMaturity
            // 
            this.radCurrentMaturity.AutoSize = true;
            this.radCurrentMaturity.Location = new System.Drawing.Point(18, 106);
            this.radCurrentMaturity.Margin = new System.Windows.Forms.Padding(1);
            this.radCurrentMaturity.Name = "radCurrentMaturity";
            this.radCurrentMaturity.Size = new System.Drawing.Size(99, 17);
            this.radCurrentMaturity.TabIndex = 3;
            this.radCurrentMaturity.TabStop = true;
            this.radCurrentMaturity.Text = "Current Maturity";
            this.radCurrentMaturity.UseVisualStyleBackColor = true;
            // 
            // radFullyExtended
            // 
            this.radFullyExtended.AutoSize = true;
            this.radFullyExtended.Location = new System.Drawing.Point(18, 81);
            this.radFullyExtended.Margin = new System.Windows.Forms.Padding(1);
            this.radFullyExtended.Name = "radFullyExtended";
            this.radFullyExtended.Size = new System.Drawing.Size(181, 17);
            this.radFullyExtended.TabIndex = 2;
            this.radFullyExtended.TabStop = true;
            this.radFullyExtended.Text = "Fully Extended (with Prepayment)";
            this.radFullyExtended.UseVisualStyleBackColor = true;
            // 
            // radInitialMaturity
            // 
            this.radInitialMaturity.AutoSize = true;
            this.radInitialMaturity.Location = new System.Drawing.Point(19, 57);
            this.radInitialMaturity.Margin = new System.Windows.Forms.Padding(1);
            this.radInitialMaturity.Name = "radInitialMaturity";
            this.radInitialMaturity.Size = new System.Drawing.Size(89, 17);
            this.radInitialMaturity.TabIndex = 1;
            this.radInitialMaturity.TabStop = true;
            this.radInitialMaturity.Text = "Initial Maturity";
            this.radInitialMaturity.UseVisualStyleBackColor = true;
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Location = new System.Drawing.Point(18, 32);
            this.radDefault.Margin = new System.Windows.Forms.Padding(1);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(59, 17);
            this.radDefault.TabIndex = 0;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Default";
            this.radDefault.UseVisualStyleBackColor = true;
            // 
            // grpCalc
            // 
            this.grpCalc.Controls.Add(this.radCalcNo);
            this.grpCalc.Controls.Add(this.radCalc);
            this.grpCalc.Location = new System.Drawing.Point(225, 13);
            this.grpCalc.Name = "grpCalc";
            this.grpCalc.Size = new System.Drawing.Size(200, 62);
            this.grpCalc.TabIndex = 5;
            this.grpCalc.TabStop = false;
            this.grpCalc.Text = "Calculate";
            // 
            // radCalcNo
            // 
            this.radCalcNo.AutoSize = true;
            this.radCalcNo.Location = new System.Drawing.Point(138, 32);
            this.radCalcNo.Name = "radCalcNo";
            this.radCalcNo.Size = new System.Drawing.Size(39, 17);
            this.radCalcNo.TabIndex = 2;
            this.radCalcNo.TabStop = true;
            this.radCalcNo.Text = "No";
            this.radCalcNo.UseVisualStyleBackColor = true;
            // 
            // radCalc
            // 
            this.radCalc.AutoSize = true;
            this.radCalc.Location = new System.Drawing.Point(63, 32);
            this.radCalc.Name = "radCalc";
            this.radCalc.Size = new System.Drawing.Size(43, 17);
            this.radCalc.TabIndex = 1;
            this.radCalc.TabStop = true;
            this.radCalc.Text = "Yes";
            this.radCalc.UseVisualStyleBackColor = true;
            // 
            // radSaveNo
            // 
            this.radSaveNo.AutoSize = true;
            this.radSaveNo.Location = new System.Drawing.Point(138, 19);
            this.radSaveNo.Name = "radSaveNo";
            this.radSaveNo.Size = new System.Drawing.Size(39, 17);
            this.radSaveNo.TabIndex = 5;
            this.radSaveNo.TabStop = true;
            this.radSaveNo.Text = "No";
            this.radSaveNo.UseVisualStyleBackColor = true;
            // 
            // radSave
            // 
            this.radSave.AutoSize = true;
            this.radSave.Location = new System.Drawing.Point(63, 19);
            this.radSave.Name = "radSave";
            this.radSave.Size = new System.Drawing.Size(43, 17);
            this.radSave.TabIndex = 4;
            this.radSave.TabStop = true;
            this.radSave.Text = "Yes";
            this.radSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSaveNo);
            this.groupBox1.Controls.Add(this.radSave);
            this.groupBox1.Location = new System.Drawing.Point(431, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save";
            // 
            // grpCFOutput
            // 
            this.grpCFOutput.Controls.Add(this.chkPeriodic);
            this.grpCFOutput.Controls.Add(this.chkTransaction);
            this.grpCFOutput.Location = new System.Drawing.Point(225, 94);
            this.grpCFOutput.Name = "grpCFOutput";
            this.grpCFOutput.Size = new System.Drawing.Size(406, 67);
            this.grpCFOutput.TabIndex = 7;
            this.grpCFOutput.TabStop = false;
            this.grpCFOutput.Text = "Cash Flow Output";
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Location = new System.Drawing.Point(33, 34);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(93, 17);
            this.chkTransaction.TabIndex = 0;
            this.chkTransaction.Text = "Transactional ";
            this.chkTransaction.UseVisualStyleBackColor = true;
            // 
            // chkPeriodic
            // 
            this.chkPeriodic.AutoSize = true;
            this.chkPeriodic.Location = new System.Drawing.Point(248, 34);
            this.chkPeriodic.Name = "chkPeriodic";
            this.chkPeriodic.Size = new System.Drawing.Size(64, 17);
            this.chkPeriodic.TabIndex = 1;
            this.chkPeriodic.Text = "Periodic";
            this.chkPeriodic.UseVisualStyleBackColor = true;
            // 
            // lstFieldsTxn
            // 
            this.lstFieldsTxn.FormattingEnabled = true;
            this.lstFieldsTxn.Location = new System.Drawing.Point(225, 178);
            this.lstFieldsTxn.Name = "lstFieldsTxn";
            this.lstFieldsTxn.Size = new System.Drawing.Size(200, 238);
            this.lstFieldsTxn.TabIndex = 8;
            // 
            // lstFieldsPeriodic
            // 
            this.lstFieldsPeriodic.FormattingEnabled = true;
            this.lstFieldsPeriodic.Location = new System.Drawing.Point(431, 178);
            this.lstFieldsPeriodic.Name = "lstFieldsPeriodic";
            this.lstFieldsPeriodic.Size = new System.Drawing.Size(200, 238);
            this.lstFieldsPeriodic.TabIndex = 9;
            // 
            // M61CF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 504);
            this.Controls.Add(this.lstFieldsPeriodic);
            this.Controls.Add(this.lstFieldsTxn);
            this.Controls.Add(this.grpCFOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCalc);
            this.Controls.Add(this.grpScenario);
            this.Controls.Add(this.grpCapStackType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.grpCalcMode);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "M61CF";
            this.Text = "M61 CF Parameters";
            this.grpCalcMode.ResumeLayout(false);
            this.grpCalcMode.PerformLayout();
            this.grpCapStackType.ResumeLayout(false);
            this.grpCapStackType.PerformLayout();
            this.grpScenario.ResumeLayout(false);
            this.grpScenario.PerformLayout();
            this.grpCalc.ResumeLayout(false);
            this.grpCalc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCFOutput.ResumeLayout(false);
            this.grpCFOutput.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpCalc;
        private System.Windows.Forms.RadioButton radCalcNo;
        private System.Windows.Forms.RadioButton radCalc;
        private System.Windows.Forms.RadioButton radSaveNo;
        private System.Windows.Forms.RadioButton radSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCFOutput;
        private System.Windows.Forms.CheckBox chkPeriodic;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.ListBox lstFieldsTxn;
        private System.Windows.Forms.ListBox lstFieldsPeriodic;
    }
}