using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceProjectPrototype.Items
{
    public class clsItemsSQL
    {
        /// <summary>
        /// Retrieves all items.
        /// </summary>
        /// <returns>All items.</returns>
        public string SelectAllItems()
        {
            string sSQL = "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc";
            return sSQL;
        }

        /// <summary>
        /// Retrieves the distinct invoices an item is used on.
        /// </summary>
        /// <param name="sItemCode">Item code.</param>
        /// <returns>Invoice numbers that use item.</returns>
        public string SelectInvoicesWithItem(string sItemCode)
        {
            string sSQL = "SELECT DISTINCT InvoiceNum FROM LineItems WHERE ItemCode = '" + sItemCode + "'";
            return sSQL;
        }

        /// <summary>
        /// Inserts new item.
        /// </summary>
        /// <param name="sItemCode">Item code.</param>
        /// <param name="sItemDesc">Item description.</param>
        /// <param name="sCost">Item cost.</param>
        /// <returns>Insert statement.</returns>
        public string InsertItem(string sItemCode, string sItemDesc, string sCost)
        {
            string sSQL = "INSERT INTO ItemDesc (ItemCode, ItemDesc, Cost) VALUES ('" + sItemCode + "', '" + sItemDesc + "', " + sCost + ")";
            return sSQL;
        }

        /// <summary>
        /// Updates item's description and cost.
        /// </summary>
        /// <param name="sItemCode">Item code.</param>
        /// <param name="sItemDesc">New description.</param>
        /// <param name="sCost">New cost.</param>
        /// <returns>Update statement.</returns>
        public string UpdateItem(string sItemCode, string sItemDesc, string sCost)
        {
            string sSQL = "UPDATE ItemDesc SET ItemDesc = '" + sItemDesc + "', Cost = " + sCost + " WHERE ItemCode = '" + sItemCode + "'";
            return sSQL;
        }

        /// <summary>
        /// Deletes item.
        /// </summary>
        /// <param name="sItemCode">Item code.</param>
        /// <returns>Delete statement.</returns>
        public string DeleteItem(string sItemCode)
        {
            string sSQL = "DELETE FROM ItemDesc WHERE ItemCode = '" + sItemCode + "'";
            return sSQL;
        }
    }
}
