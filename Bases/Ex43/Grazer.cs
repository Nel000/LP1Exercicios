using System;

namespace Ex43
{
    public class Grazer
    {
        private static int Eat(Terrain t)
        {
            int i = (int) t;

            return i;
        }

        private static int Eat(BonusTerrain bt)
        {
            int i = (int) bt * 10;

            return i;
        }
    }
}