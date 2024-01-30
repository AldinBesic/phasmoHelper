namespace BBI_PhasmoHelperV1
{
    partial class StartUpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpMenu));
            this.ServerButton = new System.Windows.Forms.Button();
            this.OfflineButton = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.AddOrChangeGhost = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServerButton
            // 
            this.ServerButton.Location = new System.Drawing.Point(12, 12);
            this.ServerButton.Name = "ServerButton";
            this.ServerButton.Size = new System.Drawing.Size(200, 150);
            this.ServerButton.TabIndex = 0;
            this.ServerButton.Text = "Server Mode";
            this.ServerButton.UseVisualStyleBackColor = true;
            this.ServerButton.Click += new System.EventHandler(this.ServerButton_Click);
            // 
            // OfflineButton
            // 
            this.OfflineButton.Location = new System.Drawing.Point(218, 12);
            this.OfflineButton.Name = "OfflineButton";
            this.OfflineButton.Size = new System.Drawing.Size(200, 150);
            this.OfflineButton.TabIndex = 1;
            this.OfflineButton.Text = "Offline Mode";
            this.OfflineButton.UseVisualStyleBackColor = true;
            this.OfflineButton.Click += new System.EventHandler(this.OfflineButton_Click);
            // 
            // TB1
            // 
            this.TB1.Cursor = System.Windows.Forms.Cursors.No;
            this.TB1.Location = new System.Drawing.Point(488, 14);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.Size = new System.Drawing.Size(211, 148);
            this.TB1.TabIndex = 2;
            this.TB1.Text = "hoi gang, gebruik de server mode niet, die is voor debug doeleinden en niet af/ni" +
    "et gemaakt/ kapot/ kut/ sloopt je computer";
            // 
            // AddOrChangeGhost
            // 
            this.AddOrChangeGhost.Location = new System.Drawing.Point(12, 168);
            this.AddOrChangeGhost.Name = "AddOrChangeGhost";
            this.AddOrChangeGhost.Size = new System.Drawing.Size(200, 114);
            this.AddOrChangeGhost.TabIndex = 3;
            this.AddOrChangeGhost.Text = "Edit Ghosts";
            this.AddOrChangeGhost.UseVisualStyleBackColor = true;
            this.AddOrChangeGhost.Click += new System.EventHandler(this.AddOrChangeGhost_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 288);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(200, 26);
            this.pass.TabIndex = 4;
            // 
            // StartUpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 324);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.AddOrChangeGhost);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.OfflineButton);
            this.Controls.Add(this.ServerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUpMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu";
            this.Load += new System.EventHandler(this.StartUpMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ServerButton;
        private System.Windows.Forms.Button OfflineButton;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button AddOrChangeGhost;
        private System.Windows.Forms.TextBox pass;
    }
}

