using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineInventoryApp.Controller;
using WineInventoryApp.Controls.Pages;

namespace WineInventoryApp
{
    public partial class WineInventoryForm : Form
    {
        private bool loggedIn;
        private Navigator navigator;

        public WineInventoryForm()
        {
            InitializeComponent();

            // Prepare the navigator
            navigator = new Navigator(this, contentPanel);

            // Prepare the initial login page
            loggedIn = false;
            LoginPage loginPage = new LoginPage();

            navigator.NavigateForward(loginPage);
        }

        public void SetNavigationPanel(bool enabled)
        {
            navPanel.Enabled = enabled;
            navPanel.Visible = enabled;
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

        private void navWineListButton_Click(object sender, EventArgs e)
        {
            // Non-existant
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
            loggedIn = false;
            navigator.NavigateForward(new LoginPage());
            navigator.PurgeNavigationHistory();

            SetNavigationPanel(false);
        }
    }
}
