using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex24
{
    public class Car : Vehicle
    {
        private Passenger[] passengers;
        public Car(double value, int numPassengers, float avgWeight) : base(value)
        {
            Random r = new Random();
            passengers = new Passenger[numPassengers];
            for (int i = 0; i < numPassengers; i++)
            {
                passengers[i] = new Passenger()
                {
                    Weight = avgWeight + r.Next(-10, 10)
                };
            }
        }

        // b)
        public double GetTotalWeight()
        {   
            double totalWeight = 0;
            for (int i = 0; i < passengers.Length; i++)
            {
                totalWeight += passengers[i].Weight;
            }
            return totalWeight;
        }
    }
}