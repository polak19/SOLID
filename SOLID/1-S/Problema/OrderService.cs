using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_S.Problema
{
    internal class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);
                
                var invoice = this.CreateInvoice(order);

                this.EmailInvoice(invoice);

                File.WriteAllText(@"c:\InfoLog.txt","The order has been complete");
            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", e.Message);
                throw;
            }
        }

        public bool InsertOrder(Order order)
        {
            //codigo para insertar la orden en una base de datos
            return true;
        }

        public Invoice CreateInvoice(Order order)
        {
            //codigo para crear la factura
            return new Invoice();
        }

        public bool EmailInvoice(Invoice invoice)
        {
            //codigo para enviar la factura por correo electronico
            return true;
        }
    }


    internal class Order 
    {
        
    }

    public class Invoice
    {
        // Propiedades de la factura
    }
}
