namespace WineInventoryApp.Controls.Dialogs
{
    partial class AddWineDialog
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
            this.addButton = new System.Windows.Forms.Button();
            this.Qty = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.volTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(75, 368);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 49);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.Location = new System.Drawing.Point(43, 54);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(39, 22);
            this.Qty.TabIndex = 1;
            this.Qty.Text = "Qty";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(144, 54);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextBox.TabIndex = 2;
            this.qtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(144, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringOnly);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(144, 133);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 6;
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // volTextBox
            // 
            this.volTextBox.Location = new System.Drawing.Point(144, 176);
            this.volTextBox.Name = "volTextBox";
            this.volTextBox.Size = new System.Drawing.Size(100, 20);
            this.volTextBox.TabIndex = 8;
            this.volTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vol (ml)";
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(144, 218);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(100, 20);
            this.originTextBox.TabIndex = 10;
            this.originTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringOnly);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Origin";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(144, 262);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 12;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalOnly);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(144, 305);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 14;
            this.typeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringOnly);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type";
            // 
            // AddWineDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 449);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.volTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.addButton);
            this.Name = "AddWineDialog";
            this.Text = "Add Wine ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox volTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label7;
    }
}