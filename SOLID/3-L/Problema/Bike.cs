using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_L.Problema
{
    internal class Bike:Vehicle
    {
        public override void SpeedUp()
        {
            //codigo speedUp
        }
        public override void Brake()
        {
           //codigo brake 
        }
        public override void Park()
        {
           //Codigo Park
        }
        public override void TakeOff()
        {
          throw new NotImplementedException("Bikes cannot take off");
        }
        public override void Land()
        {
           throw new NotImplementedException("Bikes cannot land");
        }
    }
}
