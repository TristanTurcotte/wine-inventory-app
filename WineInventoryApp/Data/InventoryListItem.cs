using System.Collections.Generic;

namespace WineInventoryApp.Data
{
    class InventoryListItem
    {
        public int Quantity { get; set; }
        public string WineName { get; set; }
        public string Origin { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }

        public InventoryListItem(Wine wineData, InventoryItem inventoryData)
        {
            Quantity = inventoryData.Quantity;
            WineName = wineData.WineName;
            Origin = wineData.Origin;
            Price = wineData.Price;
            Year = wineData.Year;
            Volume = wineData.Volume;
            Type = wineData.Type;
        }

        public static List<InventoryListItem> ConstructFromLists(List<Wine> wine, List<InventoryItem> inventory)
        {
            // Ensure the lists are sorted correctly so the wine IDs are in the same positions in both lists
            wine.Sort((a, b) => a.WineId.CompareTo(b.WineId));
            inventory.Sort((a, b) => a.WineId.CompareTo(b.WineId));

            // Create and populate the list
            List<InventoryListItem> invItems = new List<InventoryListItem>();
            for (int i = 0; i < wine.Count; i++)
            {
                invItems.Add(new InventoryListItem(wine[i], inventory[i]));
            }

            return invItems;
        }
    }
}
