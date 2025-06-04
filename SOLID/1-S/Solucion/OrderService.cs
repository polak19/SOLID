using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_S.Solucion
{
    internal class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IInvoiceService _invoiceService;
        private readonly INotificationService _notificationService;
        private readonly ILoggerService _loggerService;

        //tenemos un contructor de recibe por parametros las dependencias.
        //las dependencias son inyectadas.
        public OrderService(IOrderRepository orderRepository,
                            IInvoiceService invoiceService, 
                            INotificationService notifficationService, 
                            ILoggerService loogerService) 
        {
            _orderRepository = orderRepository;
            _notificationService = notifficationService;
            _invoiceService = invoiceService;
            _loggerService = loogerService;
        }


    
        /// Conecta los distintos servicios por inyección. 
       
        public void SaveOrder(Order order)
        {
            try
            {
                //tiene los mismos metodos
                //pero ahora tiene dependencias.
                _orderRepository.InsertOrder(order);

                var invoice = _invoiceService.CreateInvoice(order);

                _notificationService.EmailInvoice(invoice);
                
                //como registro el login por el servicio
                _loggerService.Info("The order has been complete");
            }
            catch (Exception e)
            {
                _loggerService.Error(e.Message,e);
                throw;
            }
        }



    }
}
