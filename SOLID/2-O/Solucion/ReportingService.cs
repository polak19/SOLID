using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O.Solucion
{
    internal class ReportingService
    {
        private readonly IReportGenerator _reportGenerator;
        public ReportingService(IReportGenerator reportGenerator) 
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport(List<Order> orders)
        {
            _reportGenerator.CreateReport(orders);
        }
    }
}
