using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_I.Problema
{
    internal class Program
    {
        public static void main()
        {
            BurgerOrderService service = new BurgerOrderService();
            
            service.OrderBurger(2);  //aca no se nota que hay un problema, pero en la arquitectura de la app hay un problema
        }
    }
}
