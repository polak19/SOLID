using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_D.Problema
{
    public  class OrderService
    {
        public readonly DataDogService _dataDogService;
        public OrderService(DataDogService dataDogService)
        {
            _dataDogService = dataDogService;
        }

        public void GenerateOrder(Order order)
        {
            //codigo para generar la Orden 

            //envia notificación to datadog
            _dataDogService.LogEvent("The Order wa sucessfull created");
        }
    }
}
