using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WineInventoryApp.Data;

namespace WineInventoryApp.Controls.Pages
{
    public partial class OrdersPage : UserControl
    {
        public OrdersPage()
        {
            InitializeComponent();
            InitializeOrderLists();
        }

        /// <summary>
        /// Populate the ObjectListViews with wine data.
        /// </summary>
        private void InitializeOrderLists()
        {
            List<OrderListItem> pendingList = OrderListItem.ConstructFromLists(AppDatabase.WineTable.GetAllWine(), AppDatabase.InventoryTable.GetInventory());
            List<OrderListItem> toOrderList = new List<OrderListItem>();

            for(int i = pendingList.Count - 1; i >= 0; i--)
            {
                if(pendingList[i].Quantity <= 0)
                {
                    toOrderList.Add(pendingList[i]);
                    pendingList.Remove(pendingList[i]);
                }
            }

            pendingOrdersListView.SetObjects(pendingList);
            ordersListView.SetObjects(toOrderList);
        }

        /// <summary>
        /// Move selected items from the pending list to the order list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transferRightButton_Click(object sender, EventArgs e)
        {
            if(pendingOrdersListView.SelectedObjects.Count > 0)
            {
                ordersListView.AddObjects(pendingOrdersListView.SelectedObjects);

                pendingOrdersListView.RemoveObjects(pendingOrdersListView.SelectedObjects);
            }
        }

        /// <summary>
        /// Move selected items from the order list to the pending list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transferLeftButton_Click(object sender, EventArgs e)
        {
            if(ordersListView.SelectedObjects.Count > 0)
            {
                pendingOrdersListView.AddObjects(ordersListView.SelectedObjects);

                ordersListView.RemoveObjects(ordersListView.SelectedObjects);
            }
        }

        /// <summary>
        /// Create a new form, the objects from the ordersListView will be sent to it to generate a report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printOrdersButton_Click(object sender, EventArgs e)
        {
            var orderList = ordersListView.Objects;

            // Display objects in debug
            System.Diagnostics.Debug.WriteLine("Objects to send to print report form:\n[");
            foreach(OrderListItem obj in orderList)
            {
                System.Diagnostics.Debug.Write("{0}, ", obj.ToString());
            }
            System.Diagnostics.Debug.WriteLine("]");
        }
    }
}
