namespace WineInventoryApp.Controls.Pages
{
    partial class InventoryPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.inventoryContentPanel = new System.Windows.Forms.Panel();
            this.inventoryListView = new BrightIdeasSoftware.ObjectListView();
            this.removeWineButton = new System.Windows.Forms.Button();
            this.addWineButton = new System.Windows.Forms.Button();
            this.titleLinePicture = new System.Windows.Forms.PictureBox();
            this.wineButtonPanel = new System.Windows.Forms.Panel();
            this.inventoryQuantityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.inventoryNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.inventoryOriginColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.inventoryPriceColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.inventoryYearColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.inventoryVolumeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.inventoryTypeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.inventoryContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLinePicture)).BeginInit();
            this.wineButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(723, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Current Inventory";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchTextBox.Location = new System.Drawing.Point(5, 17);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(196, 20);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // inventoryContentPanel
            // 
            this.inventoryContentPanel.Controls.Add(this.filterTypeComboBox);
            this.inventoryContentPanel.Controls.Add(this.wineButtonPanel);
            this.inventoryContentPanel.Controls.Add(this.inventoryListView);
            this.inventoryContentPanel.Controls.Add(this.searchTextBox);
            this.inventoryContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryContentPanel.Location = new System.Drawing.Point(0, 44);
            this.inventoryContentPanel.Name = "inventoryContentPanel";
            this.inventoryContentPanel.Size = new System.Drawing.Size(723, 360);
            this.inventoryContentPanel.TabIndex = 9;
            // 
            // inventoryListView
            // 
            this.inventoryListView.AllColumns.Add(this.inventoryQuantityColumn);
            this.inventoryListView.AllColumns.Add(this.inventoryNameColumn);
            this.inventoryListView.AllColumns.Add(this.inventoryYearColumn);
            this.inventoryListView.AllColumns.Add(this.inventoryVolumeColumn);
            this.inventoryListView.AllColumns.Add(this.inventoryOriginColumn);
            this.inventoryListView.AllColumns.Add(this.inventoryPriceColumn);
            this.inventoryListView.AllColumns.Add(this.inventoryTypeColumn);
            this.inventoryListView.CellEditUseWholeCell = false;
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inventoryQuantityColumn,
            this.inventoryNameColumn,
            this.inventoryYearColumn,
            this.inventoryVolumeColumn,
            this.inventoryOriginColumn,
            this.inventoryPriceColumn,
            this.inventoryTypeColumn});
            this.inventoryListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.inventoryListView.FullRowSelect = true;
            this.inventoryListView.HideSelection = false;
            this.inventoryListView.Location = new System.Drawing.Point(5, 51);
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.ShowGroups = false;
            this.inventoryListView.Size = new System.Drawing.Size(715, 306);
            this.inventoryListView.TabIndex = 9;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // removeWineButton
            // 
            this.removeWineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeWineButton.Image = global::WineInventoryApp.Properties.Resources.minus;
            this.removeWineButton.Location = new System.Drawing.Point(41, 3);
            this.removeWineButton.Name = "removeWineButton";
            this.removeWineButton.Size = new System.Drawing.Size(32, 32);
            this.removeWineButton.TabIndex = 11;
            this.removeWineButton.UseVisualStyleBackColor = true;
            this.removeWineButton.Click += new System.EventHandler(this.removeWineButton_Click);
            // 
            // addWineButton
            // 
            this.addWineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWineButton.Image = global::WineInventoryApp.Properties.Resources.plus;
            this.addWineButton.Location = new System.Drawing.Point(3, 3);
            this.addWineButton.Name = "addWineButton";
            this.addWineButton.Size = new System.Drawing.Size(32, 32);
            this.addWineButton.TabIndex = 10;
            this.addWineButton.UseVisualStyleBackColor = true;
            this.addWineButton.Click += new System.EventHandler(this.addWineButton_Click);
            // 
            // titleLinePicture
            // 
            this.titleLinePicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLinePicture.Image = global::WineInventoryApp.Properties.Resources.Line;
            this.titleLinePicture.Location = new System.Drawing.Point(0, 26);
            this.titleLinePicture.Name = "titleLinePicture";
            this.titleLinePicture.Size = new System.Drawing.Size(723, 18);
            this.titleLinePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.titleLinePicture.TabIndex = 1;
            this.titleLinePicture.TabStop = false;
            // 
            // wineButtonPanel
            // 
            this.wineButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wineButtonPanel.Controls.Add(this.addWineButton);
            this.wineButtonPanel.Controls.Add(this.removeWineButton);
            this.wineButtonPanel.Location = new System.Drawing.Point(641, 6);
            this.wineButtonPanel.Name = "wineButtonPanel";
            this.wineButtonPanel.Size = new System.Drawing.Size(79, 41);
            this.wineButtonPanel.TabIndex = 12;
            // 
            // inventoryQuantityColumn
            // 
            this.inventoryQuantityColumn.AspectName = "Quantity";
            this.inventoryQuantityColumn.Text = "Qty";
            this.inventoryQuantityColumn.Width = 41;
            // 
            // inventoryNameColumn
            // 
            this.inventoryNameColumn.AspectName = "WineName";
            this.inventoryNameColumn.Text = "Wine";
            this.inventoryNameColumn.Width = 299;
            // 
            // inventoryOriginColumn
            // 
            this.inventoryOriginColumn.AspectName = "Origin";
            this.inventoryOriginColumn.Text = "Origin";
            this.inventoryOriginColumn.Width = 115;
            // 
            // inventoryPriceColumn
            // 
            this.inventoryPriceColumn.AspectName = "Price";
            this.inventoryPriceColumn.Text = "Price";
            this.inventoryPriceColumn.Width = 69;
            // 
            // inventoryYearColumn
            // 
            this.inventoryYearColumn.AspectName = "Year";
            this.inventoryYearColumn.Text = "Year";
            this.inventoryYearColumn.Width = 56;
            // 
            // inventoryVolumeColumn
            // 
            this.inventoryVolumeColumn.AspectName = "Volume";
            this.inventoryVolumeColumn.Text = "Vol (ml)";
            this.inventoryVolumeColumn.Width = 57;
            // 
            // inventoryTypeColumn
            // 
            this.inventoryTypeColumn.AspectName = "Type";
            this.inventoryTypeColumn.Text = "Type";
            this.inventoryTypeColumn.Width = 72;
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.FormattingEnabled = true;
            this.filterTypeComboBox.Items.AddRange(new object[] {
            "Quantity",
            "Name",
            "Year",
            "Volume",
            "Origin",
            "Price",
            "Type"});
            this.filterTypeComboBox.Location = new System.Drawing.Point(207, 17);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterTypeComboBox.TabIndex = 14;
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.inventoryContentPanel);
            this.Controls.Add(this.titleLinePicture);
            this.Controls.Add(this.titleLabel);
            this.Name = "InventoryPage";
            this.Size = new System.Drawing.Size(723, 404);
            this.inventoryContentPanel.ResumeLayout(false);
            this.inventoryContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLinePicture)).EndInit();
            this.wineButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox titleLinePicture;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel inventoryContentPanel;
        private System.Windows.Forms.Button removeWineButton;
        private System.Windows.Forms.Button addWineButton;
        private BrightIdeasSoftware.ObjectListView inventoryListView;
        private System.Windows.Forms.Panel wineButtonPanel;
        private BrightIdeasSoftware.OLVColumn inventoryQuantityColumn;
        private BrightIdeasSoftware.OLVColumn inventoryNameColumn;
        private BrightIdeasSoftware.OLVColumn inventoryYearColumn;
        private BrightIdeasSoftware.OLVColumn inventoryVolumeColumn;
        private BrightIdeasSoftware.OLVColumn inventoryOriginColumn;
        private BrightIdeasSoftware.OLVColumn inventoryPriceColumn;
        private BrightIdeasSoftware.OLVColumn inventoryTypeColumn;
        private System.Windows.Forms.ComboBox filterTypeComboBox;
    }
}
