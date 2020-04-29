using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineInventoryApp.Data;

namespace WineInventoryApp.Controls.Pages
{
    public partial class OrdersPage : UserControl
    {
        private static Keys[] VALID_NUM_KEYS = new Keys[] {
            Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,
            Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4,
            Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9,
            Keys.Enter, Keys.Back, Keys.Delete, Keys.Left, Keys.Right, Keys.Up, Keys.Down
        };

        public OrdersPage()
        {
            InitializeComponent();

            orderDataGridView.DataSource = AppDatabase.GetWineInventoryTableBinding();
            AppDatabase.WineInventoryTable.QuerryWineByAtMostQuantity(20);
        }

        private void quantityFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string inputText = quantityFilterTextBox.Text;

            bool validInput = int.TryParse(inputText, out int parsedValue);

            if(validInput)
            {
                AppDatabase.WineInventoryTable.QuerryWineByAtMostQuantity(parsedValue);
            }
        }

        private void quantityFilterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(!VALID_NUM_KEYS.Contains(e.KeyCode))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
