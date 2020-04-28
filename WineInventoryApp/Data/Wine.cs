namespace WineInventoryApp.Data
{
    /// <summary>
    /// Structure which represents the data in the row of the Wine table.
    /// Each row representing a bottle of wine, containing a numerical id,
    /// a name, country of origin, price, year vintaged, volume of a
    /// bottle, category or type of wine, and an image.
    /// </summary>
    class Wine
    {
        /// <summary>
        /// Primary key for this wine 
        /// </summary>
        int WineId { get; set; }
        
        /// <summary>
        /// The name of the wine.
        /// </summary>
        string WineName { get; set; }

        /// <summary>
        /// This wine's origin country or region.
        /// </summary>
        string Origin { get; set; }

        /// <summary>
        /// Price for one bottle of this wine.
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// The vintage of this wine.
        /// </summary>
        int Year { get; set; }

        /// <summary>
        /// Volume of a bottle of this wine.
        /// </summary>
        int Volume { get; set; }

        /// <summary>
        /// Type of wine: Red, White, Sparkling, etc.
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Array of bytes representing an image.
        /// </summary>
        byte[] Image { get; set; }

        /// <summary>
        /// Standard constructor. Used by AppDatabase class to provide a typed
        /// structure to represent wine.
        /// </summary>
        /// <param name="wineId">Primary key.</param>
        /// <param name="wineName">Name of this wine.</param>
        /// <param name="origin">Country or region of the wine.</param>
        /// <param name="price">Price for a bottle.</param>
        /// <param name="year">Year vintaged.</param>
        /// <param name="volume">Volume of one bottle.</param>
        /// <param name="type">Type of wine.</param>
        /// <param name="image">Image of the wine bottle.</param>
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
