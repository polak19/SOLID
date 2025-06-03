using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_D.Solucion
{
    internal class AnyOtherMonitoringService : IEventNotificationService
    {
        public void LogEvent(string message)
        {
           //codigo del log del evento en el monitoreo del servicio 
        }
    }
}
