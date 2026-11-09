using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InvoiceProjectPrototype.Search
{
    /// <summary>
    /// Interaction logic for wndSearch.xaml
    /// </summary>
    public partial class wndSearch : Window
    {
        /// <summary>
        /// Variable to store the invoice selected by the user
        /// </summary>
        public string? SelectedInvoice { get; private set; }
        public wndSearch()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles Invoice selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Get the selected invoice
            // Store invoice ID to Selected Invoice
            // Main will access Selected invoice
            // ShowDialog() returns true.
            // Once an invoice is selected, DialogResult will be set to true and the window will close.

        }
        /// <summary>
        /// Handles Cancel method listener.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // Closes the search window and does not return a selected invoice
            DialogResult = false;
        }
        /// <summary>
        /// Clear search filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            cmbInvoiceNum.SelectedIndex = -1;
            cmbInvoiceDate.SelectedIndex = -1;
            cmbTotalCost.SelectedIndex = -1;
            //Reload invoices (Done after the database is set up.)
        }
    }
}
