using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceProjectPrototype.Items
{
    public class clsItemsLogic
    {
        /// <summary>
        /// Items SQL class.
        /// </summary>
        private readonly clsItemsSQL itemsSQL;

        /// <summary>
        /// Constructor.
        /// </summary>
        public clsItemsLogic()
        {
            itemsSQL = new clsItemsSQL();
        }

        /// <summary>
        /// Retrieves all items from the DB for DataGrid.
        /// </summary>
        public void LoadItems()
        {
            // Call SelectAllItems() and load DataGrid.
        }

        /// <summary>
        /// Adds new item.
        /// </summary>
        public void AddItem()
        {
            // Validate input, then call InsertItem().
        }

        /// <summary>
        /// Updates existing item.
        /// </summary>
        public void UpdateItem()
        {
            // Validate input, then call UpdateItem().
        }

        /// <summary>
        /// Deletes item if it isn't on any invoices.
        /// </summary>
        public void DeleteItem()
        {
            // Call SelectInvoicesWithItem() first; only call DeleteItem() if no invoices use it.
        }
    }
}
