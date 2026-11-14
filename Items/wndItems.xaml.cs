using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace InvoiceProjectPrototype.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml.
    /// </summary>
    public partial class wndItems : Window
    {
        /// <summary>
        /// Items logic class.
        /// </summary>
        private clsItemsLogic itemsLogic;

        /// <summary>
        /// Set to true when an item is added, edited, or deleted.
        /// Main opens this window with ShowDialog(), then reads this variable after it closes.
        /// If true, Main reloads its items combo box and current invoice's items.
        /// </summary>
        public bool bItemsChanged { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public wndItems()
        {
            InitializeComponent();
            itemsLogic = new clsItemsLogic();
            bItemsChanged = false;
            // Load all items into DataGrid.
        }

        /// <summary>
        /// Adds a new item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Validate input, insert new item, reload the DataGrid.
            // bItemsChanged = true;
        }

        /// <summary>
        /// Saves changes to selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            // Update only the description and cost (code is primary key).
            // bItemsChanged = true;
        }

        /// <summary>
        /// Deletes selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // If item is on any invoices, show message listing those invoices and don't delete.
            // Otherwise delete item and reload the DataGrid.
            // bItemsChanged = true;
        }

        /// <summary>
        /// Closes window and returns to Main.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
