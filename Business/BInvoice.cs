using Data; 
using Entity;
using System;
using System.Collections.Generic;

namespace Business
{
    public class BInvoice
    {
        public List<Invoice> GetInvoicesByDate(DateTime fecha)
        {

            DInvoice dataAccess = new DInvoice();

            List<Invoice> invoices = dataAccess.Get().Where(i => i.date == fecha).ToList();

            return invoices;
        }
    }
}
