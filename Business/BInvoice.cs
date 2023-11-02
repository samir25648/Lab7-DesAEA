using Data; 
using Entity;
using System;
using System.Collections.Generic;

namespace Business
{
    public class BInvoice
    {

        public List<Invoice> GetInvoicesByDate()
        {
            DInvoice dataAccess = new DInvoice();
            List<Invoice> invoices = dataAccess.Get();
            return invoices;
        }

        public bool insert(Invoice invoice)
        {
            DInvoice insertar = new DInvoice();
            insertar.insert(invoice);
            return true;
        }

        public bool DeleteRecord(int invoiceID) 
        {
            DInvoice delete = new DInvoice();

            return delete.eliminar(invoiceID);

        }
    }
}
    