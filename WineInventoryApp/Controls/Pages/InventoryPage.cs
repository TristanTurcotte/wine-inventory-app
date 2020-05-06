using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WineInventoryApp.Controls.Dialogs;
using WineInventoryApp.Data;


// TODO: Add controls and logic to page for changing the quantity on hand for a selected wine entry.

namespace WineInventoryApp.Controls.Pages
{

    public partial class InventoryPage : UserControl
    {
        private static readonly int EDIT_INTERVAL_TIME = 250;
        private bool searchPlaceholder = true;
        private List<InventoryListItem> pulledInventoryData;
        private DateTime textLastUpdate;
        private Timer searchTimer;

        public InventoryPage()
        {
            InitializeComponent();
            InitializeInventoryList();
            InitializeTimer();

            filterTypeComboBox.SelectedIndex = 1;
        }

        /// <summary>
        /// Populate the inventoryListView object with wine data.
        /// </summary>
        private void InitializeInventoryList()
        {
            pulledInventoryData = InventoryListItem.ConstructFromLists(AppDatabase.WineTable.GetAllWine(), AppDatabase.InventoryTable.GetInventory());

            inventoryListView.SetObjects(pulledInventoryData);
        }

        private void InitializeTimer()
        {
            searchTimer = new Timer();

            searchTimer.Tick += new EventHandler(SearchTimerEventHandler);
            searchTimer.Interval = EDIT_INTERVAL_TIME;
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            textLastUpdate = DateTime.Now;
            if (searchPlaceholder)
            {
                searchPlaceholder = false;

                searchTextBox.Text = "";
                searchTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if(searchTextBox.Text.Trim() == "")
            {
                searchPlaceholder = true;

                searchTextBox.Text = "Search";
                searchTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void addWineButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement add new wine entry.

            AddWineDialog dialog = new AddWineDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                InventoryItem inventoryItem = new InventoryItem(AddWineDialog.AddedWineId, AppDatabase.InventoryTable.GetQuantity(AddWineDialog.AddedWineId));

                InventoryListItem inventoryListItem = new InventoryListItem(AppDatabase.WineTable.GetWineById(AddWineDialog.AddedWineId), inventoryItem);

                inventoryListView.AddObject(inventoryListItem);
                
            }
        }

        private void removeWineButton_Click(object sender, EventArgs e)
        {
            InventoryListItem item = (InventoryListItem)inventoryListView.SelectedObject;
            
            if (item != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete wine " + item.WineName, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AppDatabase.WineTable.DeleteWine(item.WineId);
                    inventoryListView.RemoveObject(item);
                }
            }
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(searchTimer.Enabled)
            {
                searchTimer.Stop();
            }

            searchTimer.Start();
        }

        /// <summary>
        /// EventHandler that is called after interval ms time is passed since last edit of the search text.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void SearchTimerEventHandler(object o, EventArgs e)
        {
            searchTimer.Stop();
            
            if(searchPlaceholder)
                return;

            string filter = searchTextBox.Text.Trim().ToLower();
            string type = filterTypeComboBox.Text;

            switch (type)
            {
                case "Quantity":
                    if (int.TryParse(filter, out int qtyFilter))
                        FilterByQuantity(qtyFilter);
                    else
                        inventoryListView.SetObjects(pulledInventoryData);
                    break;
                case "Name": FilterByName(filter); break;
                case "Year":
                    if (int.TryParse(filter, out int yearFilter))
                        FilterByYear(yearFilter);
                    else
                        inventoryListView.SetObjects(pulledInventoryData);
                    break;
                case "Volume":
                    if (int.TryParse(filter, out int volFilter))
                        FilterByVolume(volFilter);
                    else
                        inventoryListView.SetObjects(pulledInventoryData);
                    break;
                case "Origin": FilterByOrigin(filter); break;
                case "Price":
                    if (decimal.TryParse(filter, out decimal priceFilter))
                        FilterByPrice(priceFilter);
                    else
                        inventoryListView.SetObjects(pulledInventoryData);
                    break;
                case "Type": FilterByType(filter); break;
            }

            System.Diagnostics.Debug.WriteLine("filter={0},type={1}", filter, type);
        }

        private void FilterByQuantity(int qty)
        {
            List<InventoryListItem> filteredList = new List<InventoryListItem>();

            foreach (InventoryListItem item in pulledInventoryData)
            {
                if(item.Quantity <= qty) // Make a selector for <= or >= or =, etc.
                {
                    filteredList.Add(item);
                }
            }

            inventoryListView.SetObjects(filteredList);
        }

        private void FilterByName(string name)
        {
            List<InventoryListItem> filteredList = new List<InventoryListItem>();

            foreach (InventoryListItem item in pulledInventoryData)
            {
                if (item.WineName.ToLower().Contains(name))
                {
                    filteredList.Add(item);
                }
            }

            inventoryListView.SetObjects(filteredList);
        }

        private void FilterByYear(int year)
        {
            List<InventoryListItem> filteredList = new List<InventoryListItem>();

            foreach (InventoryListItem item in pulledInventoryData)
            {
                if (item.Year == year) // Make a selector for <= or >= or =, etc.
                {
                    filteredList.Add(item);
                }
            }

            inventoryListView.SetObjects(filteredList);
        }

        private void FilterByVolume(int volume)
        {
            List<InventoryListItem> filteredList = new List<InventoryListItem>();

            foreach (InventoryListItem item in pulledInventoryData)
            {
                if (item.Volume <= volume) // Make a selector for <= or >= or =, etc.
                {
                    filteredList.Add(item);
                }
            }

            inventoryListView.SetObjects(filteredList);
        }

        private void FilterByOrigin(string origin)
        {
            List<InventoryListItem> filteredList = new List<InventoryListItem>();

            foreach (InventoryListItem item in pulledInventoryData)
            {
                if (item.Origin.ToLower().Contains(origin))
                {
                    filteredList.Add(item);
                }
            }

            inventoryListView.SetObjects(filteredList);
        }

        private void FilterByPrice(decimal price)
        {
            List<InventoryListItem> filteredList = new List<InventoryListItem>();

            foreach (InventoryListItem item in pulledInventoryData)
            {
                if (item.Price <= price) // Make a selector for <= or >= or =, etc.
                {
                    filteredList.Add(item);
                }
            }

            inventoryListView.SetObjects(filteredList);
        }

        private void FilterByType(string type)
        {
            List<InventoryListItem> filteredList = new List<InventoryListItem>();

            foreach (InventoryListItem item in pulledInventoryData)
            {
                if (item.Type.ToLower().Contains(type))
                {
                    filteredList.Add(item);
                }
            }

            inventoryListView.SetObjects(filteredList);
        }
    }
}
