using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_S.Solucion
{
    interface IOrderRepository
    {
        public bool InsertOrder(Order order);
    }
    class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            //codigo para insertar la orden en una base de datos
            return true;
        }
    }
}
