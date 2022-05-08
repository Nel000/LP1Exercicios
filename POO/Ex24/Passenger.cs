using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex24
{
    public struct Passenger
    {
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { if (value < 5) weight = 5; else weight = value; }
        }
    }
}