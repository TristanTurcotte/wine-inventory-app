namespace WineInventoryApp.Data
{
    /// <summary>
    /// Structure which represents the data in the row of the Inventory table. Each
    /// row containing a WineId and a Quantity. WineId is a foreign key to the Wine
    /// table. Quantity would represent the current value the stock is at.
    /// </summary>
    class InventoryItem
    {
        /// <summary>
        /// The primary foreign key from the Wine table. Auto-increments by 1.
        /// </summary>
        int WineId { get; }

        /// <summary>
        /// Quantity on hand.
        /// </summary>
        int Quantity { get; set; }

        /// <summary>
        /// Standard constructor. Used by AppDatabase class to provide a typed
        /// structure to represent the data of the current stock quantities.
        /// </summary>
        /// <param name="wineId">Primary foreign key from the Wine table.</param>
        /// <param name="quantity">Quantity on hand.</param>
        public InventoryItem(int wineId, int quantity)
        {
            WineId = wineId;
            Quantity = quantity;
        }
    }
}
