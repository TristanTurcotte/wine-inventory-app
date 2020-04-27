using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineInventoryApp.Data
{
    class InventoryChange
    {
        int ChangeId { get; set; }
        int UserId { get; set; }
        int WineId { get; set; }
        int QuantityAdjusted { get; set; }
        DateTime DateTimeChanged { get; set; }

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
