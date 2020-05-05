using System;
using System.Windows.Forms;
using WineInventoryApp.Controller;

namespace WineInventoryApp
{
    public partial class PasswordDialog : Form
    {
        public string StoredPassword { get; private set; }

        public PasswordDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text.Trim();
            if(Accounts.ValidatePassword(password))
            {
                StoredPassword = password;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
