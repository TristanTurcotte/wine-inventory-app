using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineInventoryApp.Data
{
    class Wine
    {
        int WineId { get; set; }
        string WineName { get; set; }
        string Origin { get; set; }
        decimal Price { get; set; }
        int Year { get; set; }
        int Volume { get; set; }
        string Type { get; set; }
        byte[] Image { get; set; }

        public Wine(int wineId, string wineName, string origin, decimal price, int year, int volume, string type, byte[] image)
        {
            WineId = wineId;
            WineName = wineName ?? "";
            Origin = origin ?? "";
            Price = price;
            Year = year;
            Volume = volume;
            Type = type ?? "";
            Image = image ?? new byte[0];
        }
    }
}
