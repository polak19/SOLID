﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_L.Problema
{
    abstract class Vehicle
    {
        public virtual void Park(){}
        public virtual void Land() { }
        public virtual void TakeOff() { }   
        public virtual void Brake() { }
        public virtual void SpeedUp() { }

    }
}
