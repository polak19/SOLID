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


        public void SaveOrder(Order order)
        {
            try
            {
                _orderRepository.InsertOrder(order);

                var invoice = _invoiceService.CreateInvoice(order);

                _notificationService.EmailInvoice(invoice);
                
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
