using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O.Problema
{
    internal class Programa
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();  // Simulamos una lista de órdenes


            ReportingService service=new ReportingService();
            service.GenerateReport(orders, ReportType.PDF); //enviamos la lista de ordes y el tipo que neceisto generar el reporte.


        }


    }
}
