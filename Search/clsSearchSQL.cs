using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceProjectPrototype.Search
{
    public class clsSearchSQL
    {
        /// <summary>
        /// Retrieves all invoices for the search window
        /// </summary>
        /// <returns>All invoices</returns>
        public string SelectAllInvoices()
        {
            string sSQL = "SELECT * FROM Invoices";
            return sSQL;
        }
        /// <summary>
        /// Retrieves unique invoice numbers
        /// </summary>
        /// <returns></returns>
        public string SelectInvoiceNumber()
        {
            string sSQL = "SELECT DISTINCT InvoiceNum FROM Invoices ORDER BY InvoiceNum";
            return sSQL;
        }
        /// <summary>
        /// Retrieves unique invoice dates
        /// </summary>
        /// <returns></returns>
        public string SelectInvoiceDates()
        {
            string sSQL = "SELECT DISTINCT InvoiceDate FROM Invoices ORDER BY InvoiceDate";
            return sSQL;
        }
        /// <summary>
        /// Retrieves unique total charges sorted ins ascending order.
        /// </summary>
        /// <returns></returns>
        public string SelectTotalCharges()
        {
            string sSQL = "SELECT DISTINCT TotalCost FROM Invoices ORDER BY TotalCost ASC";
            return sSQL;
        }
    }
}
