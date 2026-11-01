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

namespace InvoiceProjectPrototype.Main
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        private clsMainLogic MainLogic;
        
        public wndMain()
        {
            InitializeComponent();
            MainLogic = new clsMainLogic();
        }

        // this will call the search window
        private void MenuSearchForInvoice_Click(object sender, RoutedEventArgs e)
        {
            // figure out what to pass on
        }

        // this will call the items window
        private void MenuManageItems_Click(object sender, RoutedEventArgs e)
        {
            // figure out what to pass on
        }

        // created for later when these are prepped, this should save the invoice
        private void ButtonSaveInvoice_Click(object sender, RoutedEventArgs e)
        {

        }

        // this should delete the invoice
        private void ButtonDeleteInvoice_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
