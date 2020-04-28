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
            this.navPanel = new System.Windows.Forms.Panel();
            this.backNavButton = new System.Windows.Forms.Button();
            this.forwardNavButton = new System.Windows.Forms.Button();
            this.backForwardPanel = new System.Windows.Forms.Panel();
            this.navigationFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.navInventoryButton = new System.Windows.Forms.Button();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.navWineListButton = new System.Windows.Forms.Button();
            this.navOrdersButton = new System.Windows.Forms.Button();
            this.navAccountsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.navLogoutButton = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.backForwardPanel.SuspendLayout();
            this.navigationFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(104, 24);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(696, 404);
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
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
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
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.navPanel.Controls.Add(this.navigationFlowLayout);
            this.navPanel.Controls.Add(this.backForwardPanel);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Enabled = false;
            this.navPanel.Location = new System.Drawing.Point(0, 24);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(104, 404);
            this.navPanel.TabIndex = 3;
            this.navPanel.Visible = false;
            // 
            // backNavButton
            // 
            this.backNavButton.Enabled = false;
            this.backNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backNavButton.Location = new System.Drawing.Point(3, 3);
            this.backNavButton.Name = "backNavButton";
            this.backNavButton.Size = new System.Drawing.Size(32, 32);
            this.backNavButton.TabIndex = 0;
            this.backNavButton.Text = "<";
            this.backNavButton.UseVisualStyleBackColor = true;
            this.backNavButton.Click += new System.EventHandler(this.backNavButton_Click);
            // 
            // forwardNavButton
            // 
            this.forwardNavButton.Enabled = false;
            this.forwardNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forwardNavButton.Location = new System.Drawing.Point(69, 3);
            this.forwardNavButton.Name = "forwardNavButton";
            this.forwardNavButton.Size = new System.Drawing.Size(32, 32);
            this.forwardNavButton.TabIndex = 1;
            this.forwardNavButton.Text = ">";
            this.forwardNavButton.UseVisualStyleBackColor = true;
            this.forwardNavButton.Click += new System.EventHandler(this.forwardNavButton_Click);
            // 
            // backForwardPanel
            // 
            this.backForwardPanel.Controls.Add(this.backNavButton);
            this.backForwardPanel.Controls.Add(this.forwardNavButton);
            this.backForwardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backForwardPanel.Location = new System.Drawing.Point(0, 0);
            this.backForwardPanel.Name = "backForwardPanel";
            this.backForwardPanel.Size = new System.Drawing.Size(104, 39);
            this.backForwardPanel.TabIndex = 2;
            // 
            // navigationFlowLayout
            // 
            this.navigationFlowLayout.Controls.Add(this.separatorLabel);
            this.navigationFlowLayout.Controls.Add(this.navInventoryButton);
            this.navigationFlowLayout.Controls.Add(this.navWineListButton);
            this.navigationFlowLayout.Controls.Add(this.navOrdersButton);
            this.navigationFlowLayout.Controls.Add(this.navAccountsButton);
            this.navigationFlowLayout.Controls.Add(this.label1);
            this.navigationFlowLayout.Controls.Add(this.navLogoutButton);
            this.navigationFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFlowLayout.Location = new System.Drawing.Point(0, 39);
            this.navigationFlowLayout.Name = "navigationFlowLayout";
            this.navigationFlowLayout.Size = new System.Drawing.Size(104, 365);
            this.navigationFlowLayout.TabIndex = 3;
            // 
            // navInventoryButton
            // 
            this.navInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.navInventoryButton.Location = new System.Drawing.Point(3, 5);
            this.navInventoryButton.Name = "navInventoryButton";
            this.navInventoryButton.Size = new System.Drawing.Size(98, 29);
            this.navInventoryButton.TabIndex = 0;
            this.navInventoryButton.Text = "Inventory";
            this.navInventoryButton.UseVisualStyleBackColor = true;
            this.navInventoryButton.Click += new System.EventHandler(this.navInventoryButton_Click);
            // 
            // separatorLabel
            // 
            this.separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.separatorLabel.Location = new System.Drawing.Point(3, 0);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(98, 2);
            this.separatorLabel.TabIndex = 3;
            // 
            // navWineListButton
            // 
            this.navWineListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.navWineListButton.Location = new System.Drawing.Point(3, 40);
            this.navWineListButton.Name = "navWineListButton";
            this.navWineListButton.Size = new System.Drawing.Size(98, 29);
            this.navWineListButton.TabIndex = 4;
            this.navWineListButton.Text = "Wine List";
            this.navWineListButton.UseVisualStyleBackColor = true;
            // 
            // navOrdersButton
            // 
            this.navOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.navOrdersButton.Location = new System.Drawing.Point(3, 75);
            this.navOrdersButton.Name = "navOrdersButton";
            this.navOrdersButton.Size = new System.Drawing.Size(98, 29);
            this.navOrdersButton.TabIndex = 5;
            this.navOrdersButton.Text = "Orders";
            this.navOrdersButton.UseVisualStyleBackColor = true;
            this.navOrdersButton.Click += new System.EventHandler(this.navOrdersButton_Click);
            // 
            // navAccountsButton
            // 
            this.navAccountsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.navAccountsButton.Location = new System.Drawing.Point(3, 110);
            this.navAccountsButton.Name = "navAccountsButton";
            this.navAccountsButton.Size = new System.Drawing.Size(98, 29);
            this.navAccountsButton.TabIndex = 6;
            this.navAccountsButton.Text = "Accounts";
            this.navAccountsButton.UseVisualStyleBackColor = true;
            this.navAccountsButton.Click += new System.EventHandler(this.navAccountsButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 2);
            this.label1.TabIndex = 7;
            // 
            // navLogoutButton
            // 
            this.navLogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.navLogoutButton.Location = new System.Drawing.Point(3, 147);
            this.navLogoutButton.Name = "navLogoutButton";
            this.navLogoutButton.Size = new System.Drawing.Size(98, 29);
            this.navLogoutButton.TabIndex = 8;
            this.navLogoutButton.Text = "Logout";
            this.navLogoutButton.UseVisualStyleBackColor = true;
            this.navLogoutButton.Click += new System.EventHandler(this.navLogoutButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // WineInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Name = "WineInventoryForm";
            this.Text = "Wine Inventory";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.navPanel.ResumeLayout(false);
            this.backForwardPanel.ResumeLayout(false);
            this.navigationFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button forwardNavButton;
        private System.Windows.Forms.Button backNavButton;
        private System.Windows.Forms.FlowLayoutPanel navigationFlowLayout;
        private System.Windows.Forms.Button navInventoryButton;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Panel backForwardPanel;
        private System.Windows.Forms.Button navWineListButton;
        private System.Windows.Forms.Button navOrdersButton;
        private System.Windows.Forms.Button navAccountsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button navLogoutButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

