using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex23
{
    public class Gun : Weapon
    {
        private Bullet[] bullets;

        // b)
        public int NumberOfBullets => bullets.Length;

        public Gun(float value, int numBullets, float calibre) : base(value)
        {
            bullets = new Bullet[numBullets];
            for (int i = 0; i < numBullets; i++)
            {
                bullets[i] = new Bullet() { Calibre = calibre };
            }
        }
    }
}