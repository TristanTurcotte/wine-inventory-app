using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineInventoryApp.Data
{
    class InventoryItem
    {
        int WineId { get; }
        int Quantity { get; set; }

        public InventoryItem(int wineId, int quantity)
        {
            WineId = wineId;
            Quantity = quantity;
        }
    }
}
