using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_S.Solucion
{
    interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }
    class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            //codigo para enviar la factura por correo electronico
            return true;
        }
    }
}
