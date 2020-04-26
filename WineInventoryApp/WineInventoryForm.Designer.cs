namespace WineInventoryApp
{
    partial class WineInventoryForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.accountMgmtPage1 = new WineInventoryApp.Controls.Pages.AccountMgmtPage();
            this.accountMgmtPage = new WineInventoryApp.Controls.Pages.AccountMgmtPage();
            this.contentPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.accountMgmtPage);
            this.contentPanel.Controls.Add(this.accountMgmtPage1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 24);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 426);
            this.contentPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // accountMgmtPage1
            // 
            this.accountMgmtPage1.Location = new System.Drawing.Point(0, 0);
            this.accountMgmtPage1.MinimumSize = new System.Drawing.Size(800, 426);
            this.accountMgmtPage1.Name = "accountMgmtPage1";
            this.accountMgmtPage1.Size = new System.Drawing.Size(800, 426);
            this.accountMgmtPage1.TabIndex = 0;
            // 
            // accountMgmtPage
            // 
            this.accountMgmtPage.BackColor = System.Drawing.SystemColors.Window;
            this.accountMgmtPage.Location = new System.Drawing.Point(0, 0);
            this.accountMgmtPage.MinimumSize = new System.Drawing.Size(800, 426);
            this.accountMgmtPage.Name = "accountMgmtPage";
            this.accountMgmtPage.Size = new System.Drawing.Size(800, 426);
            this.accountMgmtPage.TabIndex = 1;
            // 
            // WineInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "WineInventoryForm";
            this.Text = "Wine Inventory";
            this.contentPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Controls.Pages.AccountMgmtPage accountMgmtPage1;
        private Controls.Pages.AccountMgmtPage accountMgmtPage;
    }
}

