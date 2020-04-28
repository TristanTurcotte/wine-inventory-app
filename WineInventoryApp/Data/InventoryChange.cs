using System;

namespace WineInventoryApp.Data
{
    /// <summary>
    /// Structure which represents the data in the row of an InventoryChange table.
    /// Each row representing a user's adjustment to the Quantity field from the 
    /// Inventory table. An adjustment can either be positive or negative.
    /// </summary>
    public class InventoryChange
    {
        /// <summary>
        /// The primary key for this table. Auto-increments by 1.
        /// </summary>
        public int ChangeId { get; set; }

        /// <summary>
        /// Foreign key from the User table. Identifies which user modified the 
        /// stock on hand in the Inventory table.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Foreign key from the Wine table. Identifies which inventory wine item's
        /// stock on hand was modified from the Inventory table.
        /// </summary>
        public int WineId { get; set; }

        /// <summary>
        /// Amount of items which were taken from or put into inventory.
        /// </summary>
        public int QuantityAdjusted { get; set; }

        /// <summary>
        /// Time and date of when the change was made.
        /// </summary>
        public DateTime DateTimeChanged { get; set; }

        /// <summary>
        /// Standard constructor. Used by AppDatabase class to provide a typed
        /// structure to represent the data of a modification to the stock.
        /// </summary>
        /// <param name="changeId">Primary key</param>
        /// <param name="userId">User table foreign key</param>
        /// <param name="wineId">Wine table foreign key</param>
        /// <param name="quantityAdjusted">Quantity changed, negative or positive</param>
        /// <param name="dateTimeChanged">Time and date of change</param>
        public InventoryChange(int changeId, int userId, int wineId, int quantityAdjusted, DateTime dateTimeChanged)
        {
            ChangeId = changeId;
            UserId = userId;
            WineId = wineId;
            QuantityAdjusted = quantityAdjusted;
            DateTimeChanged = dateTimeChanged;
        }
    }
}
