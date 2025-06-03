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
            
        }
        public override void Brake()
        {
            
        }
        public override void Park()
        {
           
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
