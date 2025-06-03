using SOLID._5_D.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_D.Solucion
{
    public  class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;
        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            // Lógica para generar la orden
            _eventNotificationService.LogEvent("The Order was successfully created");
        }
    }
}
