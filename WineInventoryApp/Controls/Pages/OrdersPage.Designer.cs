namespace WineInventoryApp.Controls.Pages
{
    partial class OrdersPage
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.pendingOrdersListView = new BrightIdeasSoftware.ObjectListView();
            this.wineNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.wineQtyColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.vintageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.volumeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.printOrdersButton = new System.Windows.Forms.Button();
            this.orderInventoryPanel = new System.Windows.Forms.Panel();
            this.inventoryHeaderLabel = new System.Windows.Forms.Label();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.orderHeaderLabel = new System.Windows.Forms.Label();
            this.ordersListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.transferRightButton = new System.Windows.Forms.Button();
            this.transferLeftButton = new System.Windows.Forms.Button();
            this.orderPageContentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pendingOrdersListView)).BeginInit();
            this.orderInventoryPanel.SuspendLayout();
            this.ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListView)).BeginInit();
            this.orderPageContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(696, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Order Wine";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pendingOrdersListView
            // 
            this.pendingOrdersListView.AllColumns.Add(this.wineQtyColumn);
            this.pendingOrdersListView.AllColumns.Add(this.wineNameColumn);
            this.pendingOrdersListView.AllColumns.Add(this.vintageColumn);
            this.pendingOrdersListView.AllColumns.Add(this.volumeColumn);
            this.pendingOrdersListView.CellEditUseWholeCell = false;
            this.pendingOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.wineQtyColumn,
            this.wineNameColumn,
            this.vintageColumn,
            this.volumeColumn});
            this.pendingOrdersListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.pendingOrdersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingOrdersListView.FullRowSelect = true;
            this.pendingOrdersListView.HideSelection = false;
            this.pendingOrdersListView.Location = new System.Drawing.Point(0, 22);
            this.pendingOrdersListView.Name = "pendingOrdersListView";
            this.pendingOrdersListView.ShowGroups = false;
            this.pendingOrdersListView.Size = new System.Drawing.Size(275, 315);
            this.pendingOrdersListView.TabIndex = 1;
            this.pendingOrdersListView.UseCompatibleStateImageBehavior = false;
            this.pendingOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // wineNameColumn
            // 
            this.wineNameColumn.AspectName = "WineName";
            this.wineNameColumn.Text = "Name";
            this.wineNameColumn.Width = 154;
            // 
            // wineQtyColumn
            // 
            this.wineQtyColumn.AspectName = "Quantity";
            this.wineQtyColumn.Text = "Qty";
            this.wineQtyColumn.Width = 32;
            // 
            // vintageColumn
            // 
            this.vintageColumn.AspectName = "Year";
            this.vintageColumn.MaximumWidth = 35;
            this.vintageColumn.Text = "Year";
            this.vintageColumn.Width = 35;
            // 
            // volumeColumn
            // 
            this.volumeColumn.AspectName = "Volume";
            this.volumeColumn.MaximumWidth = 60;
            this.volumeColumn.Text = "Vol (ml)";
            this.volumeColumn.Width = 50;
            // 
            // printOrdersButton
            // 
            this.printOrdersButton.Location = new System.Drawing.Point(308, 324);
            this.printOrdersButton.Name = "printOrdersButton";
            this.printOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.printOrdersButton.TabIndex = 2;
            this.printOrdersButton.Text = "Print Report";
            this.printOrdersButton.UseVisualStyleBackColor = true;
            this.printOrdersButton.Click += new System.EventHandler(this.printOrdersButton_Click);
            // 
            // orderInventoryPanel
            // 
            this.orderInventoryPanel.Controls.Add(this.pendingOrdersListView);
            this.orderInventoryPanel.Controls.Add(this.inventoryHeaderLabel);
            this.orderInventoryPanel.Location = new System.Drawing.Point(7, 10);
            this.orderInventoryPanel.Name = "orderInventoryPanel";
            this.orderInventoryPanel.Size = new System.Drawing.Size(275, 337);
            this.orderInventoryPanel.TabIndex = 3;
            // 
            // inventoryHeaderLabel
            // 
            this.inventoryHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryHeaderLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.inventoryHeaderLabel.Name = "inventoryHeaderLabel";
            this.inventoryHeaderLabel.Size = new System.Drawing.Size(275, 22);
            this.inventoryHeaderLabel.TabIndex = 2;
            this.inventoryHeaderLabel.Text = "Inventory";
            this.inventoryHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ordersPanel
            // 
            this.ordersPanel.Controls.Add(this.ordersListView);
            this.ordersPanel.Controls.Add(this.orderHeaderLabel);
            this.ordersPanel.Location = new System.Drawing.Point(409, 10);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(275, 337);
            this.ordersPanel.TabIndex = 4;
            // 
            // orderHeaderLabel
            // 
            this.orderHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderHeaderLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.orderHeaderLabel.Name = "orderHeaderLabel";
            this.orderHeaderLabel.Size = new System.Drawing.Size(275, 22);
            this.orderHeaderLabel.TabIndex = 2;
            this.orderHeaderLabel.Text = "Order List";
            this.orderHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ordersListView
            // 
            this.ordersListView.AllColumns.Add(this.olvColumn1);
            this.ordersListView.AllColumns.Add(this.olvColumn2);
            this.ordersListView.AllColumns.Add(this.olvColumn3);
            this.ordersListView.AllColumns.Add(this.olvColumn4);
            this.ordersListView.CellEditUseWholeCell = false;
            this.ordersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.ordersListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ordersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersListView.FullRowSelect = true;
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(0, 22);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.ShowGroups = false;
            this.ordersListView.Size = new System.Drawing.Size(275, 315);
            this.ordersListView.TabIndex = 1;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Quantity";
            this.olvColumn1.Text = "Qty";
            this.olvColumn1.Width = 32;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "WineName";
            this.olvColumn2.Text = "Name";
            this.olvColumn2.Width = 154;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Year";
            this.olvColumn3.MaximumWidth = 35;
            this.olvColumn3.Text = "Year";
            this.olvColumn3.Width = 35;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Volume";
            this.olvColumn4.MaximumWidth = 60;
            this.olvColumn4.Text = "Vol (ml)";
            this.olvColumn4.Width = 50;
            // 
            // transferRightButton
            // 
            this.transferRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferRightButton.Location = new System.Drawing.Point(329, 142);
            this.transferRightButton.Name = "transferRightButton";
            this.transferRightButton.Size = new System.Drawing.Size(35, 29);
            this.transferRightButton.TabIndex = 5;
            this.transferRightButton.Text = "->";
            this.transferRightButton.UseVisualStyleBackColor = true;
            this.transferRightButton.Click += new System.EventHandler(this.transferRightButton_Click);
            // 
            // transferLeftButton
            // 
            this.transferLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferLeftButton.Location = new System.Drawing.Point(329, 191);
            this.transferLeftButton.Name = "transferLeftButton";
            this.transferLeftButton.Size = new System.Drawing.Size(35, 29);
            this.transferLeftButton.TabIndex = 6;
            this.transferLeftButton.Text = "<-";
            this.transferLeftButton.UseVisualStyleBackColor = true;
            this.transferLeftButton.Click += new System.EventHandler(this.transferLeftButton_Click);
            // 
            // orderPageContentPanel
            // 
            this.orderPageContentPanel.Controls.Add(this.printOrdersButton);
            this.orderPageContentPanel.Controls.Add(this.transferLeftButton);
            this.orderPageContentPanel.Controls.Add(this.orderInventoryPanel);
            this.orderPageContentPanel.Controls.Add(this.transferRightButton);
            this.orderPageContentPanel.Controls.Add(this.ordersPanel);
            this.orderPageContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPageContentPanel.Location = new System.Drawing.Point(0, 41);
            this.orderPageContentPanel.Name = "orderPageContentPanel";
            this.orderPageContentPanel.Size = new System.Drawing.Size(696, 363);
            this.orderPageContentPanel.TabIndex = 7;
            // 
            // OrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderPageContentPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "OrdersPage";
            this.Size = new System.Drawing.Size(696, 404);
            ((System.ComponentModel.ISupportInitialize)(this.pendingOrdersListView)).EndInit();
            this.orderInventoryPanel.ResumeLayout(false);
            this.ordersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersListView)).EndInit();
            this.orderPageContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private BrightIdeasSoftware.ObjectListView pendingOrdersListView;
        private BrightIdeasSoftware.OLVColumn wineNameColumn;
        private BrightIdeasSoftware.OLVColumn wineQtyColumn;
        private BrightIdeasSoftware.OLVColumn vintageColumn;
        private BrightIdeasSoftware.OLVColumn volumeColumn;
        private System.Windows.Forms.Button printOrdersButton;
        private System.Windows.Forms.Panel orderInventoryPanel;
        private System.Windows.Forms.Label inventoryHeaderLabel;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Label orderHeaderLabel;
        private BrightIdeasSoftware.ObjectListView ordersListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Button transferRightButton;
        private System.Windows.Forms.Button transferLeftButton;
        private System.Windows.Forms.Panel orderPageContentPanel;
    }
}