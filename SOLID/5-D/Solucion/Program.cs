using SOLID._2_O.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_D.Solucion
{
    internal class Program
    {
        public static void main()
        {
            Order order= new Order();
            // Simulamos una lista de órdenes
            OrderService service = new OrderService(new AnyOtherMonitoringService()); //definimos el tipo de reporte vamos generar.
            service.GenerateOrder(order);
        }
    }
}
