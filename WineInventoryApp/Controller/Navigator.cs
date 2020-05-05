using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WineInventoryApp.Data;

namespace WineInventoryApp.Controller
{
    /// <summary>
    /// A singleton to keep track of navigation through the app. Keeps track of every page that was visited
    /// as well as the order they were visited. Facilitates navigating forward and back between pages.
    /// </summary>
    class Navigator
    {
        private static Navigator navigator;

        private WineInventoryForm form;
        private Panel contentPanel;
        private List<UserControl> navList;
        private int navigationIndex;

        /// <summary>
        /// Creates a navigator object to navigate through the different pages in the given form.
        /// </summary>
        /// <param name="form">Form that this navigator is paired with.</param>
        /// <param name="contentPanel">The panel where the navigator will place the pages.</param>
        public Navigator(WineInventoryForm form, Panel contentPanel)
        {
            this.form = form;
            this.contentPanel = contentPanel;
            navList = new List<UserControl>();
            navigationIndex = -1;

            Navigator.navigator = this;
        }

        /// <summary>
        /// Returns the navigator for this application.
        /// </summary>
        /// <returns>Currently active navigator object.</returns>
        public static Navigator GetNavigator()
        {
            return navigator;
        }

        /// <summary>
        /// Switches the currently displayed page.
        /// </summary>
        /// <param name="page">Page UserControl to switch to.</param>
        /// <param name="displayNavigation">To display the navigation panel or not.</param>
        /// <returns>The page UserControl that was switched to.</returns>
        private UserControl SwitchToPage(UserControl page, bool displayNavigation = true)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(page);

            form.UpdateBackForwardButtons();
            
            return page;
        }

        /// <summary>
        /// Sets if the left-hand side navigation panel is visible.
        /// </summary>
        /// <param name="visible">If the navigation panel is to be visible and active.</param>
        public void SetNavigationPanelVisible(bool visible)
        {
            if(Accounts.CurrentUserId != -1)
            {
                int access = AppDatabase.UserTable.GetUserById(Accounts.CurrentUserId).AccessLevel;
                form.SetAccountManagementButton(access >= 2);
            }
            form.SetNavigationPanel(visible);
        }

        /// <summary>
        /// Go back one page from the current page. If the navigation has not been given a page before,
        /// throws an exception. If currently on the first page of the list, returns the page back.
        /// Otherwise it will return the page before the currently opened page.
        /// </summary>
        /// <returns>A UserControl which is to be added as an element to the main form.</returns>
        public UserControl NavigateBack()
        {
            if (navigationIndex < 0)
            {
                throw new ArgumentOutOfRangeException($"Cannot navigate back when currently on page {navigationIndex}.");
            }
            else if (navigationIndex == 0)
            {
                return SwitchToPage(navList[0]);
            }
            else
            {
                return SwitchToPage(navList[--navigationIndex]);
            }
        }

        /// <summary>
        /// Go forward one page from the current page, or go to a new page if a UserControl was passed.
        /// </summary>
        /// <param name="page">Optional. If given, the current page will navigate to the given page.</param>
        /// <returns>A UserControl which is to be added as an element to the main form.</returns>
        public UserControl NavigateForward(UserControl page = null)
        {
            // Going to a page that was already visited
            if (page == null)
            {
                if (navigationIndex < navList.Count - 1) // Can still navigate forward
                {
                    return SwitchToPage(navList[++navigationIndex]);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Cannot navigate forward to a non-existant page. navList.Count={navList.Count}, navIndex={navigationIndex}");
                }
            }
            else // Going to a new page
            {
                if (navigationIndex == navList.Count - 1) // Currently at the most recent page
                {
                    navList.Add(page);
                    navigationIndex++;
                }
                else // User navigated back previously and is heading to a new page
                {
                    navList.RemoveRange(++navigationIndex, navList.Count - navigationIndex);
                    navList.Add(page);
                }

                return SwitchToPage(page);
            }
        }

        /// <summary>
        /// Gets the index of the currently opened page.
        /// </summary>
        /// <returns>Currently opened page index of the pages being tracked.</returns>
        public int GetIndex()
        {
            return navigationIndex;
        }

        /// <summary>
        /// Gets the count of the number of pages being tracked.
        /// </summary>
        /// <returns>Total pages being tracked.</returns>
        public int GetCount()
        {
            return navList.Count;
        }

        /// <summary>
        /// Removes all tracked page information and resets the navigation to only include the
        /// currently opened page.
        /// </summary>
        public void PurgeNavigationHistory()
        {
            if (navList.Count < 1)
            {
                return;
            }

            UserControl currentPage = navList[navigationIndex];

            navList.Clear();
            navList.Add(currentPage);
            navigationIndex = 0;

            form.UpdateBackForwardButtons();
        }

        /// <summary>
        /// Determines if backwards navigation is currently possible from the current index.
        /// </summary>
        /// <returns>True, if and only if backwards navigation is valid, otherwise false.</returns>
        public bool CanNavigateBack()
        {
            return navigationIndex > 0;
        }

        /// <summary>
        /// Determines if forward navigation is currently possible from the current index without adding a new page.
        /// </summary>
        /// <returns>True, if and only if forwards navigation is valid without creating a new page, otherwise false.</returns>
        public bool CanNavigateForward()
        {
            return navigationIndex < navList.Count - 1;
        }
    }
}