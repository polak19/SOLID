using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O.Problema
{
    //la clases es la generadoa los reportes.
    //¿que pasa el cliente debe generar mas reporates?
    internal class ReportingService
    {

        public void GenerateReport(List<Order> orders, ReportType type)
        {
            if (type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type==ReportType.Excel)
            {
                CreateExcelReport(orders);
            }
        }

        public void CreatePDFReport(List<Order> orders)
        {
            // Lógica para crear un reporte en PDF
            Console.WriteLine("Generating PDF report...");
        }
        public void CreateExcelReport(List<Order> orders)
        {
            // Lógica para crear un reporte en PDF
            Console.WriteLine("Generating PDF report...");
        }
    }
}
