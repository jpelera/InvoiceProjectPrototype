using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceProjectPrototype.Main
{
    // holds all the SQL queries
    public class clsMainSQL
    {
        // gets all data for a invoice ID
        public string SelectInvoiceData(string InvoiceID)
        {
            string data = "add these in after" + InvoiceID;
            return data;
        }

        // grab inventory item assignments
        public string SelectInvoiceItems(string InvoiceID)
        {
            string data = "add these in" + InvoiceID;
            return data;
        }

        // add any other relevant SQL as needed
    }
}
