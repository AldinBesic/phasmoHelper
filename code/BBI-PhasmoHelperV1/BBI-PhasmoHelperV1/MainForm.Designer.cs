﻿namespace BBI_PhasmoHelperV1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.terminalLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghostsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evidenceMarkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPassTB = new System.Windows.Forms.ToolStripTextBox();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sorryNogNietKlaarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetEvidence = new System.Windows.Forms.ToolStripMenuItem();
            this.emfBtn = new System.Windows.Forms.Button();
            this.dotsBtn = new System.Windows.Forms.Button();
            this.ultravioletBtn = new System.Windows.Forms.Button();
            this.spiritBoxBtn = new System.Windows.Forms.Button();
            this.ghostWritingBtn = new System.Windows.Forms.Button();
            this.gorbBtn = new System.Windows.Forms.Button();
            this.lightsOffBtn = new System.Windows.Forms.Button();
            this.breakerBtn = new System.Windows.Forms.Button();
            this.freezingBtn = new System.Windows.Forms.Button();
            this.consoleInputTB = new System.Windows.Forms.TextBox();
            this.mimicOrbsBtn = new System.Windows.Forms.Button();
            this.instaTurnOffLights = new System.Windows.Forms.Button();
            this.doorSlamBtn = new System.Windows.Forms.Button();
            this.evidenceGB = new System.Windows.Forms.GroupBox();
            this.huntCooldownTimerLbl = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.remainingGhostsTB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.evidenceGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.consoleTextBox.Location = new System.Drawing.Point(21, 887);
            this.consoleTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTextBox.Size = new System.Drawing.Size(957, 390);
            this.consoleTextBox.TabIndex = 11;
            // 
            // terminalLbl
            // 
            this.terminalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.terminalLbl.AutoSize = true;
            this.terminalLbl.Location = new System.Drawing.Point(812, 891);
            this.terminalLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.terminalLbl.Name = "terminalLbl";
            this.terminalLbl.Size = new System.Drawing.Size(119, 32);
            this.terminalLbl.TabIndex = 12;
            this.terminalLbl.Text = "Console";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.resetEvidence});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2704, 51);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.ghostsToolStripMenuItem1,
            this.evidenceMarkingToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(417, 54);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ghostsToolStripMenuItem1
            // 
            this.ghostsToolStripMenuItem1.Name = "ghostsToolStripMenuItem1";
            this.ghostsToolStripMenuItem1.Size = new System.Drawing.Size(417, 54);
            this.ghostsToolStripMenuItem1.Text = "Ghosts";
            // 
            // evidenceMarkingToolStripMenuItem
            // 
            this.evidenceMarkingToolStripMenuItem.Name = "evidenceMarkingToolStripMenuItem";
            this.evidenceMarkingToolStripMenuItem.Size = new System.Drawing.Size(417, 54);
            this.evidenceMarkingToolStripMenuItem.Text = "Evidence marking";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.ghostsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(149, 45);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingServerToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(276, 54);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // pingServerToolStripMenuItem
            // 
            this.pingServerToolStripMenuItem.Name = "pingServerToolStripMenuItem";
            this.pingServerToolStripMenuItem.Size = new System.Drawing.Size(330, 54);
            this.pingServerToolStripMenuItem.Text = "Ping server";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(330, 54);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(330, 54);
            this.addNewToolStripMenuItem.Text = "Add new";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(330, 54);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // ghostsToolStripMenuItem
            // 
            this.ghostsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.toolStripPassTB});
            this.ghostsToolStripMenuItem.Name = "ghostsToolStripMenuItem";
            this.ghostsToolStripMenuItem.Size = new System.Drawing.Size(276, 54);
            this.ghostsToolStripMenuItem.Text = "Ghosts";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(301, 54);
            this.addNewToolStripMenuItem1.Text = "Add/Edit";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // toolStripPassTB
            // 
            this.toolStripPassTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripPassTB.Name = "toolStripPassTB";
            this.toolStripPassTB.Size = new System.Drawing.Size(100, 47);
            this.toolStripPassTB.Text = "pass";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem1});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 45);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // serverToolStripMenuItem1
            // 
            this.serverToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorryNogNietKlaarToolStripMenuItem});
            this.serverToolStripMenuItem1.Name = "serverToolStripMenuItem1";
            this.serverToolStripMenuItem1.Size = new System.Drawing.Size(266, 54);
            this.serverToolStripMenuItem1.Text = "Server";
            // 
            // sorryNogNietKlaarToolStripMenuItem
            // 
            this.sorryNogNietKlaarToolStripMenuItem.Name = "sorryNogNietKlaarToolStripMenuItem";
            this.sorryNogNietKlaarToolStripMenuItem.Size = new System.Drawing.Size(473, 54);
            this.sorryNogNietKlaarToolStripMenuItem.Text = "Sorry, nog niet klaar :)";
            // 
            // resetEvidence
            // 
            this.resetEvidence.Name = "resetEvidence";
            this.resetEvidence.Size = new System.Drawing.Size(114, 45);
            this.resetEvidence.Text = "Reset";
            // 
            // emfBtn
            // 
            this.emfBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.emfBtn.Location = new System.Drawing.Point(11, 25);
            this.emfBtn.Margin = new System.Windows.Forms.Padding(5);
            this.emfBtn.Name = "emfBtn";
            this.emfBtn.Size = new System.Drawing.Size(226, 124);
            this.emfBtn.TabIndex = 14;
            this.emfBtn.Text = "EMF 5";
            this.emfBtn.UseVisualStyleBackColor = false;
            this.emfBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // dotsBtn
            // 
            this.dotsBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dotsBtn.Location = new System.Drawing.Point(247, 25);
            this.dotsBtn.Margin = new System.Windows.Forms.Padding(5);
            this.dotsBtn.Name = "dotsBtn";
            this.dotsBtn.Size = new System.Drawing.Size(226, 124);
            this.dotsBtn.TabIndex = 15;
            this.dotsBtn.Text = "Dots";
            this.dotsBtn.UseVisualStyleBackColor = false;
            this.dotsBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // ultravioletBtn
            // 
            this.ultravioletBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ultravioletBtn.Location = new System.Drawing.Point(484, 25);
            this.ultravioletBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ultravioletBtn.Name = "ultravioletBtn";
            this.ultravioletBtn.Size = new System.Drawing.Size(226, 124);
            this.ultravioletBtn.TabIndex = 16;
            this.ultravioletBtn.Text = "UV";
            this.ultravioletBtn.UseVisualStyleBackColor = false;
            this.ultravioletBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // spiritBoxBtn
            // 
            this.spiritBoxBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.spiritBoxBtn.Location = new System.Drawing.Point(484, 158);
            this.spiritBoxBtn.Margin = new System.Windows.Forms.Padding(5);
            this.spiritBoxBtn.Name = "spiritBoxBtn";
            this.spiritBoxBtn.Size = new System.Drawing.Size(226, 124);
            this.spiritBoxBtn.TabIndex = 19;
            this.spiritBoxBtn.Text = "Spirit box";
            this.spiritBoxBtn.UseVisualStyleBackColor = false;
            this.spiritBoxBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // ghostWritingBtn
            // 
            this.ghostWritingBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ghostWritingBtn.Location = new System.Drawing.Point(247, 158);
            this.ghostWritingBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ghostWritingBtn.Name = "ghostWritingBtn";
            this.ghostWritingBtn.Size = new System.Drawing.Size(226, 124);
            this.ghostWritingBtn.TabIndex = 18;
            this.ghostWritingBtn.Text = "Ghost writing";
            this.ghostWritingBtn.UseVisualStyleBackColor = false;
            this.ghostWritingBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // gorbBtn
            // 
            this.gorbBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gorbBtn.Location = new System.Drawing.Point(11, 158);
            this.gorbBtn.Margin = new System.Windows.Forms.Padding(5);
            this.gorbBtn.Name = "gorbBtn";
            this.gorbBtn.Size = new System.Drawing.Size(226, 124);
            this.gorbBtn.TabIndex = 17;
            this.gorbBtn.Text = "Ghost orbs";
            this.gorbBtn.UseVisualStyleBackColor = false;
            this.gorbBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // lightsOffBtn
            // 
            this.lightsOffBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lightsOffBtn.Location = new System.Drawing.Point(484, 291);
            this.lightsOffBtn.Margin = new System.Windows.Forms.Padding(5);
            this.lightsOffBtn.Name = "lightsOffBtn";
            this.lightsOffBtn.Size = new System.Drawing.Size(226, 124);
            this.lightsOffBtn.TabIndex = 22;
            this.lightsOffBtn.Text = "Turns lights on";
            this.lightsOffBtn.UseVisualStyleBackColor = false;
            this.lightsOffBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // breakerBtn
            // 
            this.breakerBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.breakerBtn.Location = new System.Drawing.Point(247, 291);
            this.breakerBtn.Margin = new System.Windows.Forms.Padding(5);
            this.breakerBtn.Name = "breakerBtn";
            this.breakerBtn.Size = new System.Drawing.Size(226, 124);
            this.breakerBtn.TabIndex = 21;
            this.breakerBtn.Text = "Breaker shutoff";
            this.breakerBtn.UseVisualStyleBackColor = false;
            this.breakerBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // freezingBtn
            // 
            this.freezingBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.freezingBtn.Location = new System.Drawing.Point(11, 291);
            this.freezingBtn.Margin = new System.Windows.Forms.Padding(5);
            this.freezingBtn.Name = "freezingBtn";
            this.freezingBtn.Size = new System.Drawing.Size(226, 124);
            this.freezingBtn.TabIndex = 20;
            this.freezingBtn.Text = "Freezing temps";
            this.freezingBtn.UseVisualStyleBackColor = false;
            this.freezingBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // consoleInputTB
            // 
            this.consoleInputTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.consoleInputTB.Location = new System.Drawing.Point(23, 1286);
            this.consoleInputTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.consoleInputTB.Name = "consoleInputTB";
            this.consoleInputTB.Size = new System.Drawing.Size(955, 38);
            this.consoleInputTB.TabIndex = 23;
            // 
            // mimicOrbsBtn
            // 
            this.mimicOrbsBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mimicOrbsBtn.Location = new System.Drawing.Point(11, 425);
            this.mimicOrbsBtn.Margin = new System.Windows.Forms.Padding(5);
            this.mimicOrbsBtn.Name = "mimicOrbsBtn";
            this.mimicOrbsBtn.Size = new System.Drawing.Size(226, 62);
            this.mimicOrbsBtn.TabIndex = 24;
            this.mimicOrbsBtn.Text = "Mimic orbs";
            this.mimicOrbsBtn.UseVisualStyleBackColor = false;
            this.mimicOrbsBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // instaTurnOffLights
            // 
            this.instaTurnOffLights.BackColor = System.Drawing.SystemColors.ControlDark;
            this.instaTurnOffLights.Location = new System.Drawing.Point(247, 425);
            this.instaTurnOffLights.Margin = new System.Windows.Forms.Padding(5);
            this.instaTurnOffLights.Name = "instaTurnOffLights";
            this.instaTurnOffLights.Size = new System.Drawing.Size(226, 62);
            this.instaTurnOffLights.TabIndex = 25;
            this.instaTurnOffLights.Text = "Lights Insta off";
            this.instaTurnOffLights.UseVisualStyleBackColor = false;
            this.instaTurnOffLights.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // doorSlamBtn
            // 
            this.doorSlamBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.doorSlamBtn.Location = new System.Drawing.Point(484, 425);
            this.doorSlamBtn.Margin = new System.Windows.Forms.Padding(5);
            this.doorSlamBtn.Name = "doorSlamBtn";
            this.doorSlamBtn.Size = new System.Drawing.Size(226, 62);
            this.doorSlamBtn.TabIndex = 26;
            this.doorSlamBtn.Text = "door slam";
            this.doorSlamBtn.UseVisualStyleBackColor = false;
            this.doorSlamBtn.Click += new System.EventHandler(this.EvidenceBtn_Click);
            // 
            // evidenceGB
            // 
            this.evidenceGB.Controls.Add(this.doorSlamBtn);
            this.evidenceGB.Controls.Add(this.instaTurnOffLights);
            this.evidenceGB.Controls.Add(this.mimicOrbsBtn);
            this.evidenceGB.Controls.Add(this.lightsOffBtn);
            this.evidenceGB.Controls.Add(this.breakerBtn);
            this.evidenceGB.Controls.Add(this.freezingBtn);
            this.evidenceGB.Controls.Add(this.spiritBoxBtn);
            this.evidenceGB.Controls.Add(this.ghostWritingBtn);
            this.evidenceGB.Controls.Add(this.gorbBtn);
            this.evidenceGB.Controls.Add(this.ultravioletBtn);
            this.evidenceGB.Controls.Add(this.dotsBtn);
            this.evidenceGB.Controls.Add(this.emfBtn);
            this.evidenceGB.Location = new System.Drawing.Point(0, 56);
            this.evidenceGB.Margin = new System.Windows.Forms.Padding(5);
            this.evidenceGB.Name = "evidenceGB";
            this.evidenceGB.Padding = new System.Windows.Forms.Padding(5);
            this.evidenceGB.Size = new System.Drawing.Size(724, 498);
            this.evidenceGB.TabIndex = 27;
            this.evidenceGB.TabStop = false;
            this.evidenceGB.Text = "Evidence";
            // 
            // huntCooldownTimerLbl
            // 
            this.huntCooldownTimerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.huntCooldownTimerLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.huntCooldownTimerLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.huntCooldownTimerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huntCooldownTimerLbl.Location = new System.Drawing.Point(21, 793);
            this.huntCooldownTimerLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.huntCooldownTimerLbl.Name = "huntCooldownTimerLbl";
            this.huntCooldownTimerLbl.Size = new System.Drawing.Size(215, 88);
            this.huntCooldownTimerLbl.TabIndex = 28;
            this.huntCooldownTimerLbl.Text = "+ 25";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 744);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(141, 32);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "Cooldown";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 793);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 88);
            this.label1.TabIndex = 30;
            this.label1.Text = "100";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(247, 744);
            this.lbl2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(94, 32);
            this.lbl2.TabIndex = 31;
            this.lbl2.Text = "Sanity";
            // 
            // remainingGhostsTB
            // 
            this.remainingGhostsTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.remainingGhostsTB.Location = new System.Drawing.Point(747, 81);
            this.remainingGhostsTB.Multiline = true;
            this.remainingGhostsTB.Name = "remainingGhostsTB";
            this.remainingGhostsTB.ReadOnly = true;
            this.remainingGhostsTB.Size = new System.Drawing.Size(872, 462);
            this.remainingGhostsTB.TabIndex = 32;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(2704, 1334);
            this.Controls.Add(this.remainingGhostsTB);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.huntCooldownTimerLbl);
            this.Controls.Add(this.evidenceGB);
            this.Controls.Add(this.consoleInputTB);
            this.Controls.Add(this.terminalLbl);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhasmoHelperV1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.evidenceGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Label terminalLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghostsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evidenceMarkingToolStripMenuItem;
        private System.Windows.Forms.Button emfBtn;
        private System.Windows.Forms.ToolStripTextBox toolStripPassTB;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Button dotsBtn;
        private System.Windows.Forms.Button ultravioletBtn;
        private System.Windows.Forms.Button spiritBoxBtn;
        private System.Windows.Forms.Button ghostWritingBtn;
        private System.Windows.Forms.Button gorbBtn;
        private System.Windows.Forms.Button lightsOffBtn;
        private System.Windows.Forms.Button breakerBtn;
        private System.Windows.Forms.Button freezingBtn;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sorryNogNietKlaarToolStripMenuItem;
        private System.Windows.Forms.TextBox consoleInputTB;
        private System.Windows.Forms.Button mimicOrbsBtn;
        private System.Windows.Forms.Button instaTurnOffLights;
        private System.Windows.Forms.Button doorSlamBtn;
        private System.Windows.Forms.GroupBox evidenceGB;
        private System.Windows.Forms.Label huntCooldownTimerLbl;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox remainingGhostsTB;
        private System.Windows.Forms.ToolStripMenuItem resetEvidence;
    }
}