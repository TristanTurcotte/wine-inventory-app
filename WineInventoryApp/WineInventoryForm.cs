using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineInventoryApp
{
    public partial class WineInventoryForm : Form
    {
        // The panel 'contentPanel' will be used as an anchor point for
        // custom user controls to be dynamically placed and removed
        // from the WineInventoryForm GUI.
        // 
        // Custom user control examples:
        // Login page
        // profile page
        // inventory page
        // add/edit wine page
        // add/remove from inventory page
        // orders page, etc.
        //
        // The navigation between these pages can be tracked using
        // an ordered collection that holds the pages, if the user 
        // goes 'back' the control at a given index in the collection
        // would get displayed.
        //
        // WineInventoryForm has a menu bar, 'menuStrip' which can be
        // given different options depending on which page is open.
        // There is also a status bar, 'statusStrip' which can have a
        // progress bar or label to display what is currently happening
        // on the back-end, ex. Loading database query, saving database,
        // etc.

        public WineInventoryForm()
        {
            InitializeComponent();
        }
    }
}
