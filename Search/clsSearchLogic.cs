using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceProjectPrototype.Search
{
    public class clsSearchLogic
    {
        /// <summary>
        /// Searchsql variable 
        /// </summary>
        private readonly clsSearchSQL searchSQL;
        /// <summary>
        /// constructor
        /// </summary>
        public clsSearchLogic()
        {
            searchSQL = new clsSearchSQL();
        }
        /// <summary>
        /// Retreives invoices from DB and fills the search window.
        /// </summary>
        public void LoadInvoices()
        {
            //Call SelectAllInvoices() and Load the search window.
        }
        /// <summary>
        /// Populates the filter comboboxes
        /// </summary>
        public void LoadFilters()
        {
            //Execute SQL query for numbers, dates, and total charges.
        }
        /// <summary>
        /// Filters the invoice based on the chosen criteria
        /// </summary>
        public void FilterInvoices()
        {
            //Apply filters together.
        }

    }
}
