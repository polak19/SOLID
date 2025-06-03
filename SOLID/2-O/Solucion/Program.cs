using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O.Solucion
{
    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();  // Simulamos una lista de órdenes
            ReportingService service = new ReportingService(new ReportGeneratorPDF());
            service.GenerateReport(orders);
             
        }
    }
}
