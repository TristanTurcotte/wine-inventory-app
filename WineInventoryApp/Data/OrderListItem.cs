using System;
using System.Collections.Generic;

namespace WineInventoryApp.Data
{
    class OrderListItem
    {
        public int Quantity { get; set; }
        public String WineName { get; set; }
        public int Year { get; set; }
        public int Volume { get; set; }

        public OrderListItem(Wine listItem, InventoryItem quantity)
        {
            WineName = listItem.WineName;
            Year = listItem.Year;
            Volume = listItem.Volume;
            Quantity = quantity.Quantity;
        }

        public static List<OrderListItem> ConstructFromLists(List<Wine> wine, List<InventoryItem> inventory)
        {
            // Ensure the lists are sorted correctly so the wine IDs are in the same positions in both lists
            wine.Sort((a, b) => a.WineId.CompareTo(b.WineId));
            inventory.Sort((a, b) => a.WineId.CompareTo(b.WineId));

            // Create and populate the list
            List<OrderListItem> orderItems = new List<OrderListItem>();
            for(int i = 0; i < wine.Count; i++)
            {
                orderItems.Add(new OrderListItem(wine[i], inventory[i]));
            }

            return orderItems;
        }

        public override string ToString()
        {
            return string.Format("{{Q:{0}, N:{1}, Y:{2}, V:{3}}", Quantity, WineName, Year, Volume);
        }
    }
}
