using System;
using System.Windows.Forms;
using WineInventoryApp.Controller;

namespace WineInventoryApp
{
    public partial class AccountDialog : Form
    {
        public string StoredUsername { get; private set; }
        public string StoredPassword { get; private set; }

        public AccountDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool validUser = false;
            bool validPass = false;

            string username = usernameTextBox.Text.Trim();
            validUser = Accounts.ValidateUsername(username);

            string password = passwordTextBox.Text.Trim();
            validPass = Accounts.ValidatePassword(password);

            if(validUser && validPass)
            {
                StoredUsername = username;
                StoredPassword = password;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
