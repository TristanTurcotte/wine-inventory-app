using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineInventoryApp.Controller;
using WineInventoryApp.Controls.Pages;
using WineInventoryApp.Data;

namespace WineInventoryApp.Controls.Dialogs
{
    public partial class AddWineDialog : Form
    {
        public static int AddedWineId { get; private set; }
        public AddWineDialog()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (typeTextBox.Text != "" &&
                originTextBox.Text != "" && 
                nameTextBox.Text != "" &&
                yearTextBox.Text != "" && 
                PriceTextBox.Text != "" && 
                volTextBox.Text != "" &&
                qtyTextBox.Text != "")
            {
                decimal price = Convert.ToDecimal(PriceTextBox.Text);
                int year = Convert.ToInt32(yearTextBox.Text);
                int vol = Convert.ToInt32(volTextBox.Text);
                int qty = Convert.ToInt32(qtyTextBox.Text);

                int wineId = AppDatabase.WineTable.InsertWine(nameTextBox.Text, originTextBox.Text, price, year, vol, typeTextBox.Text);
                AppDatabase.InventoryTable.UpdateInventory(wineId, qty, Accounts.CurrentUserId);

                AddedWineId = AppDatabase.WineTable.GetIdByNameYearVolume(nameTextBox.Text,year, vol);
                this.DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Please Enter All Inputs");
            }
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DecimalOnly(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void StringOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
