using System;
using System.Windows.Forms;
using WineInventoryApp.Controller;
using WineInventoryApp.Controls.Pages;

namespace WineInventoryApp
{
    public partial class WineInventoryForm : Form
    {
        private Navigator navigator;

        public WineInventoryForm()
        {
            InitializeComponent();

            // Prepare the navigator
            navigator = new Navigator(this, contentPanel);

            // Prepare the initial login page
            LoginPage loginPage = new LoginPage();

            navigator.NavigateForward(loginPage);
        }

        public void SetNavigationPanel(bool enabled)
        {
            navPanel.Enabled = enabled;
            navPanel.Visible = enabled;
        }

        public void SetAccountManagementButton(bool enabled)
        {
            navAccountsButton.Enabled = enabled;
        }

        //=================================//
        // Forward and Backward navigation //
        //=================================//
        private void backNavButton_Click(object sender, EventArgs e)
        {
            if (navigator.CanNavigateBack())
            {
                navigator.NavigateBack();
            }
        }

        private void forwardNavButton_Click(object sender, EventArgs e)
        {
            if (navigator.CanNavigateForward())
            {
                navigator.NavigateForward();
            }
        }

        /// <summary>
        /// Sets whether the forward and back navigation is enabled or not. Called by Navigator class.
        /// </summary>
        public void UpdateBackForwardButtons()
        {
            backNavButton.Enabled = navigator.CanNavigateBack();
            forwardNavButton.Enabled = navigator.CanNavigateForward();
        }

        //================================//
        // Application navigation buttons //
        //================================//
        private void navInventoryButton_Click(object sender, EventArgs e)
        {
            navigator.NavigateForward(new InventoryPage());
        }

        private void navOrdersButton_Click(object sender, EventArgs e)
        {
            navigator.NavigateForward(new OrdersPage());
        }

        private void navAccountsButton_Click(object sender, EventArgs e)
        {
            navigator.NavigateForward(new AccountMgmtPage());
        }

        private void navLogoutButton_Click(object sender, EventArgs e)
        {
            Accounts.Logout();

            navigator.NavigateForward(new LoginPage());
            navigator.PurgeNavigationHistory();

            SetNavigationPanel(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigator.NavigateForward(new SettingsPage());
        }
    }
}
