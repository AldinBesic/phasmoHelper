namespace BBI_PhasmoHelperV1
{
    partial class ChangeGhostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeGhostForm));
            this.noteTB = new System.Windows.Forms.TextBox();
            this.importGhostBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ghostNameTB = new System.Windows.Forms.TextBox();
            this.GhostCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.e1CB = new System.Windows.Forms.ComboBox();
            this.e2CB = new System.Windows.Forms.ComboBox();
            this.e3CB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.strengthsTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.weaknessTB = new System.Windows.Forms.TextBox();
            this.breakerCheckB = new System.Windows.Forms.CheckBox();
            this.lightsCheckB = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.StratsTB = new System.Windows.Forms.TextBox();
            this.abilityTB = new System.Windows.Forms.TextBox();
            this.huntThreshholdTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noteTB
            // 
            this.noteTB.Location = new System.Drawing.Point(18, 172);
            this.noteTB.Multiline = true;
            this.noteTB.Name = "noteTB";
            this.noteTB.Size = new System.Drawing.Size(263, 96);
            this.noteTB.TabIndex = 46;
            this.noteTB.Text = "Note";
            // 
            // importGhostBtn
            // 
            this.importGhostBtn.Location = new System.Drawing.Point(249, 36);
            this.importGhostBtn.Name = "importGhostBtn";
            this.importGhostBtn.Size = new System.Drawing.Size(63, 35);
            this.importGhostBtn.TabIndex = 43;
            this.importGhostBtn.Text = "Import";
            this.importGhostBtn.UseVisualStyleBackColor = true;
            this.importGhostBtn.Click += new System.EventHandler(this.importGhostBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Name:";
            // 
            // ghostNameTB
            // 
            this.ghostNameTB.Location = new System.Drawing.Point(417, 8);
            this.ghostNameTB.Name = "ghostNameTB";
            this.ghostNameTB.Size = new System.Drawing.Size(150, 26);
            this.ghostNameTB.TabIndex = 35;
            // 
            // GhostCB
            // 
            this.GhostCB.FormattingEnabled = true;
            this.GhostCB.Items.AddRange(new object[] {
            "please select"});
            this.GhostCB.Location = new System.Drawing.Point(100, 43);
            this.GhostCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GhostCB.Name = "GhostCB";
            this.GhostCB.Size = new System.Drawing.Size(142, 28);
            this.GhostCB.TabIndex = 32;
            this.GhostCB.Text = "please select";
            this.GhostCB.SelectedIndexChanged += new System.EventHandler(this.GhostCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ghost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Evidence 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "ghosts toevoegen enzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Evidence 1:";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(10, 277);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(143, 48);
            this.finishBtn.TabIndex = 26;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Evidence 3:";
            // 
            // e1CB
            // 
            this.e1CB.FormattingEnabled = true;
            this.e1CB.Items.AddRange(new object[] {
            "please select"});
            this.e1CB.Location = new System.Drawing.Point(417, 42);
            this.e1CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.e1CB.Name = "e1CB";
            this.e1CB.Size = new System.Drawing.Size(142, 28);
            this.e1CB.TabIndex = 49;
            this.e1CB.Text = "please select";
            // 
            // e2CB
            // 
            this.e2CB.FormattingEnabled = true;
            this.e2CB.Items.AddRange(new object[] {
            "please select"});
            this.e2CB.Location = new System.Drawing.Point(417, 72);
            this.e2CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.e2CB.Name = "e2CB";
            this.e2CB.Size = new System.Drawing.Size(142, 28);
            this.e2CB.TabIndex = 50;
            this.e2CB.Text = "please select";
            // 
            // e3CB
            // 
            this.e3CB.FormattingEnabled = true;
            this.e3CB.Items.AddRange(new object[] {
            "please select"});
            this.e3CB.Location = new System.Drawing.Point(417, 104);
            this.e3CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.e3CB.Name = "e3CB";
            this.e3CB.Size = new System.Drawing.Size(142, 28);
            this.e3CB.TabIndex = 51;
            this.e3CB.Text = "please select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Strengths:";
            // 
            // strengthsTB
            // 
            this.strengthsTB.Location = new System.Drawing.Point(417, 140);
            this.strengthsTB.Name = "strengthsTB";
            this.strengthsTB.Size = new System.Drawing.Size(150, 26);
            this.strengthsTB.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Weakness:";
            // 
            // weaknessTB
            // 
            this.weaknessTB.Location = new System.Drawing.Point(417, 172);
            this.weaknessTB.Name = "weaknessTB";
            this.weaknessTB.Size = new System.Drawing.Size(150, 26);
            this.weaknessTB.TabIndex = 54;
            // 
            // breakerCheckB
            // 
            this.breakerCheckB.AutoSize = true;
            this.breakerCheckB.Checked = true;
            this.breakerCheckB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.breakerCheckB.Location = new System.Drawing.Point(417, 204);
            this.breakerCheckB.Name = "breakerCheckB";
            this.breakerCheckB.Size = new System.Drawing.Size(153, 24);
            this.breakerCheckB.TabIndex = 56;
            this.breakerCheckB.Text = "TurnsOffBreaker";
            this.breakerCheckB.UseVisualStyleBackColor = true;
            // 
            // lightsCheckB
            // 
            this.lightsCheckB.AutoSize = true;
            this.lightsCheckB.Checked = true;
            this.lightsCheckB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightsCheckB.Location = new System.Drawing.Point(417, 234);
            this.lightsCheckB.Name = "lightsCheckB";
            this.lightsCheckB.Size = new System.Drawing.Size(140, 24);
            this.lightsCheckB.TabIndex = 57;
            this.lightsCheckB.Text = "TurnsOffLights";
            this.lightsCheckB.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(159, 277);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(143, 48);
            this.SaveBtn.TabIndex = 58;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // StratsTB
            // 
            this.StratsTB.Location = new System.Drawing.Point(18, 74);
            this.StratsTB.Multiline = true;
            this.StratsTB.Name = "StratsTB";
            this.StratsTB.Size = new System.Drawing.Size(263, 96);
            this.StratsTB.TabIndex = 59;
            this.StratsTB.Text = "Strats";
            // 
            // abilityTB
            // 
            this.abilityTB.Location = new System.Drawing.Point(417, 264);
            this.abilityTB.Name = "abilityTB";
            this.abilityTB.Size = new System.Drawing.Size(150, 26);
            this.abilityTB.TabIndex = 60;
            // 
            // huntThreshholdTB
            // 
            this.huntThreshholdTB.Location = new System.Drawing.Point(417, 299);
            this.huntThreshholdTB.Name = "huntThreshholdTB";
            this.huntThreshholdTB.Size = new System.Drawing.Size(150, 26);
            this.huntThreshholdTB.TabIndex = 61;
            this.huntThreshholdTB.Text = "60%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Ability:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Hunt thresh:";
            // 
            // ChangeGhostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 335);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.huntThreshholdTB);
            this.Controls.Add(this.abilityTB);
            this.Controls.Add(this.StratsTB);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.lightsCheckB);
            this.Controls.Add(this.breakerCheckB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.weaknessTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.strengthsTB);
            this.Controls.Add(this.e3CB);
            this.Controls.Add(this.e2CB);
            this.Controls.Add(this.e1CB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noteTB);
            this.Controls.Add(this.importGhostBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ghostNameTB);
            this.Controls.Add(this.GhostCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeGhostForm";
            this.Text = "ghostmeuk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteTB;
        private System.Windows.Forms.Button importGhostBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ghostNameTB;
        private System.Windows.Forms.ComboBox GhostCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox e1CB;
        private System.Windows.Forms.ComboBox e2CB;
        private System.Windows.Forms.ComboBox e3CB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox strengthsTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox weaknessTB;
        private System.Windows.Forms.CheckBox breakerCheckB;
        private System.Windows.Forms.CheckBox lightsCheckB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox StratsTB;
        private System.Windows.Forms.TextBox abilityTB;
        private System.Windows.Forms.TextBox huntThreshholdTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}