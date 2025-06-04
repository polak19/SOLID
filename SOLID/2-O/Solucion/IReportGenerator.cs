using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O.Solucion
{
     interface IReportGenerator
    {
        //no interesa como se genera el reporte.
        void CreateReport(List<Order> orders);
    }
}
