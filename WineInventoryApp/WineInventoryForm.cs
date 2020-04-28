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
        private Navigator navigator;

        public WineInventoryForm()
        {
            InitializeComponent();

            // Prepare the navigator
            navigator = new Navigator(contentPanel);

            // Prepare the initial login page
            LoginPage loginPage = new LoginPage();

            navigator.NavigateForward(loginPage);
        }

        //=================================//
        // Forward and Backward navigation //
        //=================================//
        private void backNavButton_Click(object sender, EventArgs e)
        {

        }

        private void forwardNavButton_Click(object sender, EventArgs e)
        {

        }

        //================================//
        // Application navigation buttons //
        //================================//
        private void navInventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void navWineListButton_Click(object sender, EventArgs e)
        {

        }

        private void navOrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void navAccountsButton_Click(object sender, EventArgs e)
        {

        }

        private void navLogoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
