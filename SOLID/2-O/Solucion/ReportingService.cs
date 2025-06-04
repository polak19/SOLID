using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O.Solucion
{
    internal class ReportingService
    {
        //nuevamente hacemos una inyección de dependencia. 

        private readonly IReportGenerator _reportGenerator;
        public ReportingService(IReportGenerator reportGenerator) 
        {
            _reportGenerator = reportGenerator;
        }

        //lo unico que le importa a la clase es como se realizara los reportes, por la lista de ordes.
        public void GenerateReport(List<Order> orders)
        {
            _reportGenerator.CreateReport(orders);
        }
    }
}
