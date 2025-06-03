using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_L.Solucion
{
    internal class Bike : ISpeedUp, IBrake, IPark
    {
        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void SpeedUp()
        {
            throw new NotImplementedException();
        }
    }
}
