using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceProjectPrototype.Main
{
    public class clsMainLogic
    {
        private clsMainSQL Queries;

        public clsMainLogic()
        {
            Queries = new clsMainSQL();
        }
    }
}
