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
            this.filterLabel = new System.Windows.Forms.Label();
            this.quantityFilterTextBox = new System.Windows.Forms.TextBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(246, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(199, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Order Wine";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(3, 63);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(263, 16);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Only show wine with at most given Quantity:";
            // 
            // quantityFilterTextBox
            // 
            this.quantityFilterTextBox.Location = new System.Drawing.Point(272, 61);
            this.quantityFilterTextBox.Name = "quantityFilterTextBox";
            this.quantityFilterTextBox.Size = new System.Drawing.Size(45, 20);
            this.quantityFilterTextBox.TabIndex = 3;
            this.quantityFilterTextBox.Text = "20";
            this.quantityFilterTextBox.TextChanged += new System.EventHandler(this.quantityFilterTextBox_TextChanged);
            this.quantityFilterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityFilterTextBox_KeyDown);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 87);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.Size = new System.Drawing.Size(696, 317);
            this.orderDataGridView.TabIndex = 0;
            // 
            // OrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.quantityFilterTextBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "OrdersPage";
            this.Size = new System.Drawing.Size(696, 404);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox quantityFilterTextBox;
        private System.Windows.Forms.DataGridView orderDataGridView;
    }
}