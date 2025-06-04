using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O.Problema
{
    //Se clase con más reportes 
    internal class ReportingService_2
    {
        public void GenerateReport(List<Order> orders, ReportType_2 type)
        {
            if (type == ReportType_2.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType_2.Excel)
            {
                CreateExcelReport(orders);
            }
            else if (type == ReportType_2.JSON)
            {
                CreateJSONReport(orders);
            }
            else if (type == ReportType_2.XML)
            {
                CreateXMLReport(orders);
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
        public void CreateJSONReport(List<Order> orders)
        {
            // Lógica para crear un reporte en JSON
            Console.WriteLine("Generating PDF report...");
        }
        public void CreateXMLReport(List<Order> orders)
        {
            // Lógica para crear un reporte en XML
            Console.WriteLine("Generating PDF report...");
        }
    }

}
