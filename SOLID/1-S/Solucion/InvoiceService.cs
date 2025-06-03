using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_S.Solucion
{
    interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }
    class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            //codigo para crear la factura
            return new Invoice();
        }
    }
}
