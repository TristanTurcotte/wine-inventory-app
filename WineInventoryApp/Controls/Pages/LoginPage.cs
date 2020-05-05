using System;
using System.Windows.Forms;
using WineInventoryApp.Controller;

namespace WineInventoryApp.Controls.Pages
{
    public partial class LoginPage : UserControl
    {
// Page for login to the application. Will be the main page to be opened.
        public LoginPage()
        {
            InitializeComponent();

            int userId = Accounts.CreateUser("testadmin", "123321", 2);
            System.Diagnostics.Debug.WriteLine("Was is successful? {0}", userId);
        }

        private void SetInvalidLabel(bool visible)
        {
            invalidEntryLabel.Visible = visible;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            bool validLogin = Accounts.TryLogin(username, password);
            if(!validLogin)
            {
                SetInvalidLabel(true);
                return;
            }
            
            Navigator nav = Navigator.GetNavigator();
            nav.NavigateForward(new InventoryPage());
            nav.SetNavigationPanelVisible(true);
            nav.PurgeNavigationHistory();
        }
    }
}
