using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_I.Problema
{
    internal interface IFoodOrderService
    {
        void OrderBurger(int quantity);
        void OrderPizza(int quantity);
        void OrderSalad(int quantity);
    }
}
