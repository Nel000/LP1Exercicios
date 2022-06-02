using System;

namespace Ex47
{
    public class Star : ILightSource, IComparable<Star>
    {
        private const double d = 5.67f * -8f;

        private readonly double a, t;

        public double Illuminance => d * a * Math.Pow(t, 4);

        public Star(double a, double t)
        {
            this.a = a;
            this.t = t;
        }

        public int CompareTo(Star other)
        {
            if (other is null) return 1;

            if (other.Illuminance - Illuminance < 0) return -1;

            return 0; 
        }
    }
}