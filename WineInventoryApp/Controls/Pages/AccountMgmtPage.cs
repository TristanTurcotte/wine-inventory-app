using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WineInventoryApp.Data;

namespace WineInventoryApp.Controls.Pages
{
    public partial class AccountMgmtPage : UserControl
    {
        public AccountMgmtPage()
        {
            InitializeComponent();
            InitializeAccountsListView();
        }

        public void InitializeAccountsListView()
        {
            accessLevelColumn.AspectGetter = delegate (object o)
            {
                return ((User)o).AccessString();
            };

            List<User> users = AppDatabase.UserTable.GetAllUsers();

            foreach(var u in users)
            {
                System.Diagnostics.Debug.WriteLine(u);
            }

            accountsListView.SetObjects(users);
        }

        private void enableEditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(enableEditCheckBox.Checked)
            {
                accountInfoModeLabel.Text = "Edit Account Info";
                EnableAccountInfoPanel(true);
            }
            else
            {
                accountInfoModeLabel.Text = "View Account Info";
                EnableAccountInfoPanel(false);
            }
        }

        private void accountsListView_SelectionChanged(object sender, EventArgs e)
        {
            User user = (User)accountsListView.SelectedObject;
            if(user != null)
            {
                PopulateAccountInfoPanel(user);
            } else
            {
                ClearAccountInfoPanel();
            }
            
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User user = (User)accountsListView.SelectedObject;

            int userId = user.UserId;

            string username = usernameTextBox.Text.Trim();
            int access = User.GetAccessLevelFromString(accessLevelComboBox.Text);

            if(!username.Equals(user.Username) && !AppDatabase.UserTable.ContainsUsername(username))
            {
                AppDatabase.UserTable.UpdateUsername(userId, username);
                user.Username = username;
            }

            if(user.AccessLevel != 3 && access != user.AccessLevel)
            {
                AppDatabase.UserTable.UpdateUserAccessLevel(userId, access);
                user.AccessLevel = access;
            }

            accountsListView.RefreshObject(user);
        }

        private void PopulateAccountInfoPanel(User user)
        {
            enableEditCheckBox.Checked = false;

            userIdTextBox.Text = user.UserId.ToString();
            usernameTextBox.Text = user.Username;
            accessLevelComboBox.Text = user.AccessString();
            createdDateTextBox.Text = user.CreatedDate.ToShortDateString();
            lastLoginTextBox.Text = user.LastLoginTime.ToString();
        }

        private void ClearAccountInfoPanel()
        {
            userIdTextBox.Text = "";
            usernameTextBox.Text = "";
            accessLevelComboBox.Text = "";
            createdDateTextBox.Text = "";
            lastLoginTextBox.Text = "";

            enableEditCheckBox.Checked = false;
        }

        private void EnableAccountInfoPanel(bool enable)
        {
            usernameTextBox.Enabled = enable;
            usernameTextBox.ReadOnly = !enable;
            accessLevelComboBox.Enabled = enable;

            saveButton.Enabled = enable;
        }
    }
}
