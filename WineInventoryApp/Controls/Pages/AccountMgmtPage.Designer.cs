namespace WineInventoryApp.Controls.Pages
{
    partial class AccountMgmtPage
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.accountInfoPanel = new System.Windows.Forms.Panel();
            this.enableEditCheckBox = new System.Windows.Forms.CheckBox();
            this.accountInfoModeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountsListView = new BrightIdeasSoftware.ObjectListView();
            this.userIdColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.usernameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.accessLevelColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dateCreatedColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastLoginColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.accessLevelLabel = new System.Windows.Forms.Label();
            this.accessLevelComboBox = new System.Windows.Forms.ComboBox();
            this.createdDateTextBox = new System.Windows.Forms.TextBox();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.lastLoginTextBox = new System.Windows.Forms.TextBox();
            this.lastLoginLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.titleLinePicture = new System.Windows.Forms.PictureBox();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.passwordButton = new System.Windows.Forms.Button();
            this.accountInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLinePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(723, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Account Management";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(0, 44);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(723, 39);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Hello, Jacob";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountInfoPanel
            // 
            this.accountInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountInfoPanel.Controls.Add(this.passwordButton);
            this.accountInfoPanel.Controls.Add(this.lastLoginTextBox);
            this.accountInfoPanel.Controls.Add(this.lastLoginLabel);
            this.accountInfoPanel.Controls.Add(this.createdDateTextBox);
            this.accountInfoPanel.Controls.Add(this.createdDateLabel);
            this.accountInfoPanel.Controls.Add(this.accessLevelComboBox);
            this.accountInfoPanel.Controls.Add(this.accessLevelLabel);
            this.accountInfoPanel.Controls.Add(this.usernameTextBox);
            this.accountInfoPanel.Controls.Add(this.usernameLabel);
            this.accountInfoPanel.Controls.Add(this.saveButton);
            this.accountInfoPanel.Controls.Add(this.userIdTextBox);
            this.accountInfoPanel.Controls.Add(this.userIdLabel);
            this.accountInfoPanel.Controls.Add(this.enableEditCheckBox);
            this.accountInfoPanel.Controls.Add(this.accountInfoModeLabel);
            this.accountInfoPanel.Controls.Add(this.label1);
            this.accountInfoPanel.Location = new System.Drawing.Point(492, 86);
            this.accountInfoPanel.Name = "accountInfoPanel";
            this.accountInfoPanel.Size = new System.Drawing.Size(228, 200);
            this.accountInfoPanel.TabIndex = 13;
            // 
            // enableEditCheckBox
            // 
            this.enableEditCheckBox.AutoSize = true;
            this.enableEditCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableEditCheckBox.Location = new System.Drawing.Point(142, 4);
            this.enableEditCheckBox.Name = "enableEditCheckBox";
            this.enableEditCheckBox.Size = new System.Drawing.Size(81, 20);
            this.enableEditCheckBox.TabIndex = 1;
            this.enableEditCheckBox.Text = "Edit Mode";
            this.enableEditCheckBox.UseVisualStyleBackColor = true;
            this.enableEditCheckBox.CheckedChanged += new System.EventHandler(this.enableEditCheckBox_CheckedChanged);
            // 
            // accountInfoModeLabel
            // 
            this.accountInfoModeLabel.AutoSize = true;
            this.accountInfoModeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfoModeLabel.Location = new System.Drawing.Point(4, 4);
            this.accountInfoModeLabel.Name = "accountInfoModeLabel";
            this.accountInfoModeLabel.Size = new System.Drawing.Size(112, 17);
            this.accountInfoModeLabel.TabIndex = 0;
            this.accountInfoModeLabel.Text = "View Account Info";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 1);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // accountsListView
            // 
            this.accountsListView.AllColumns.Add(this.userIdColumn);
            this.accountsListView.AllColumns.Add(this.usernameColumn);
            this.accountsListView.AllColumns.Add(this.accessLevelColumn);
            this.accountsListView.AllColumns.Add(this.dateCreatedColumn);
            this.accountsListView.AllColumns.Add(this.lastLoginColumn);
            this.accountsListView.CellEditUseWholeCell = false;
            this.accountsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userIdColumn,
            this.usernameColumn,
            this.accessLevelColumn,
            this.dateCreatedColumn,
            this.lastLoginColumn});
            this.accountsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.accountsListView.FullRowSelect = true;
            this.accountsListView.HideSelection = false;
            this.accountsListView.Location = new System.Drawing.Point(3, 86);
            this.accountsListView.MultiSelect = false;
            this.accountsListView.Name = "accountsListView";
            this.accountsListView.ShowGroups = false;
            this.accountsListView.Size = new System.Drawing.Size(483, 315);
            this.accountsListView.TabIndex = 16;
            this.accountsListView.UseCompatibleStateImageBehavior = false;
            this.accountsListView.View = System.Windows.Forms.View.Details;
            this.accountsListView.SelectionChanged += new System.EventHandler(this.accountsListView_SelectionChanged);
            // 
            // userIdColumn
            // 
            this.userIdColumn.AspectName = "UserId";
            this.userIdColumn.Text = "User ID";
            this.userIdColumn.Width = 62;
            // 
            // usernameColumn
            // 
            this.usernameColumn.AspectName = "Username";
            this.usernameColumn.Text = "Username";
            this.usernameColumn.Width = 138;
            // 
            // accessLevelColumn
            // 
            this.accessLevelColumn.AspectName = "";
            this.accessLevelColumn.Text = "Access Level";
            this.accessLevelColumn.Width = 85;
            // 
            // dateCreatedColumn
            // 
            this.dateCreatedColumn.AspectName = "CreatedDate";
            this.dateCreatedColumn.Text = "Created";
            this.dateCreatedColumn.Width = 87;
            // 
            // lastLoginColumn
            // 
            this.lastLoginColumn.AspectName = "LastLoginTime";
            this.lastLoginColumn.Text = "Last Login";
            this.lastLoginColumn.Width = 105;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(4, 35);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(46, 13);
            this.userIdLabel.TabIndex = 3;
            this.userIdLabel.Text = "User ID:";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Enabled = false;
            this.userIdTextBox.Location = new System.Drawing.Point(84, 32);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(139, 20);
            this.userIdTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(118, 164);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 32);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(84, 59);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(139, 20);
            this.usernameTextBox.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(4, 62);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username:";
            // 
            // accessLevelLabel
            // 
            this.accessLevelLabel.AutoSize = true;
            this.accessLevelLabel.Location = new System.Drawing.Point(4, 88);
            this.accessLevelLabel.Name = "accessLevelLabel";
            this.accessLevelLabel.Size = new System.Drawing.Size(74, 13);
            this.accessLevelLabel.TabIndex = 8;
            this.accessLevelLabel.Text = "Access Level:";
            // 
            // accessLevelComboBox
            // 
            this.accessLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessLevelComboBox.Enabled = false;
            this.accessLevelComboBox.FormattingEnabled = true;
            this.accessLevelComboBox.Items.AddRange(new object[] {
            "Disabled",
            "Waiter",
            "Admin",
            "Owner"});
            this.accessLevelComboBox.Location = new System.Drawing.Point(84, 85);
            this.accessLevelComboBox.Name = "accessLevelComboBox";
            this.accessLevelComboBox.Size = new System.Drawing.Size(139, 21);
            this.accessLevelComboBox.TabIndex = 9;
            // 
            // createdDateTextBox
            // 
            this.createdDateTextBox.Enabled = false;
            this.createdDateTextBox.Location = new System.Drawing.Point(84, 112);
            this.createdDateTextBox.Name = "createdDateTextBox";
            this.createdDateTextBox.ReadOnly = true;
            this.createdDateTextBox.Size = new System.Drawing.Size(139, 20);
            this.createdDateTextBox.TabIndex = 11;
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(4, 115);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(73, 13);
            this.createdDateLabel.TabIndex = 10;
            this.createdDateLabel.Text = "Created Date:";
            // 
            // lastLoginTextBox
            // 
            this.lastLoginTextBox.Enabled = false;
            this.lastLoginTextBox.Location = new System.Drawing.Point(84, 138);
            this.lastLoginTextBox.Name = "lastLoginTextBox";
            this.lastLoginTextBox.ReadOnly = true;
            this.lastLoginTextBox.Size = new System.Drawing.Size(139, 20);
            this.lastLoginTextBox.TabIndex = 13;
            // 
            // lastLoginLabel
            // 
            this.lastLoginLabel.AutoSize = true;
            this.lastLoginLabel.Location = new System.Drawing.Point(4, 141);
            this.lastLoginLabel.Name = "lastLoginLabel";
            this.lastLoginLabel.Size = new System.Drawing.Size(59, 13);
            this.lastLoginLabel.TabIndex = 12;
            this.lastLoginLabel.Text = "Last Login:";
            // 
            // createAccountButton
            // 
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.createAccountButton.Image = global::WineInventoryApp.Properties.Resources.CreateAccIcon;
            this.createAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createAccountButton.Location = new System.Drawing.Point(492, 292);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(228, 52);
            this.createAccountButton.TabIndex = 17;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
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
            // deleteAccountButton
            // 
            this.deleteAccountButton.Enabled = false;
            this.deleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteAccountButton.Image = global::WineInventoryApp.Properties.Resources.DeleteAccIcon;
            this.deleteAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAccountButton.Location = new System.Drawing.Point(492, 349);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(228, 52);
            this.deleteAccountButton.TabIndex = 18;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.Enabled = false;
            this.passwordButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.passwordButton.Location = new System.Drawing.Point(3, 164);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(105, 32);
            this.passwordButton.TabIndex = 14;
            this.passwordButton.Text = "Password";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // AccountMgmtPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.accountsListView);
            this.Controls.Add(this.accountInfoPanel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.titleLinePicture);
            this.Controls.Add(this.titleLabel);
            this.MinimumSize = new System.Drawing.Size(723, 404);
            this.Name = "AccountMgmtPage";
            this.Size = new System.Drawing.Size(723, 404);
            this.accountInfoPanel.ResumeLayout(false);
            this.accountInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLinePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox titleLinePicture;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel accountInfoPanel;
        private System.Windows.Forms.CheckBox enableEditCheckBox;
        private System.Windows.Forms.Label accountInfoModeLabel;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.ObjectListView accountsListView;
        private BrightIdeasSoftware.OLVColumn userIdColumn;
        private BrightIdeasSoftware.OLVColumn usernameColumn;
        private BrightIdeasSoftware.OLVColumn accessLevelColumn;
        private BrightIdeasSoftware.OLVColumn dateCreatedColumn;
        private BrightIdeasSoftware.OLVColumn lastLoginColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox lastLoginTextBox;
        private System.Windows.Forms.Label lastLoginLabel;
        private System.Windows.Forms.TextBox createdDateTextBox;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.ComboBox accessLevelComboBox;
        private System.Windows.Forms.Label accessLevelLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button passwordButton;
    }
}
