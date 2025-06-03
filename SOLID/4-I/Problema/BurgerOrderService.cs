using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_I.Problema
{
    internal class BurgerOrderService : IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            //implementacion de la orden de hamburguesas
        }

        public void OrderPizza(int quantity)
        {
            throw new NotImplementedException("no puede realizar la orden");
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException("no puede realizar la orden");
        }
    }
}
