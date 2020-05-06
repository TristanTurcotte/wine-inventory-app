using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineInventoryApp.Controls.Pages
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
        }


        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                this.BackColor = Color.Gray;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                this.BackColor = Color.White;
            }
        }
    }
}
