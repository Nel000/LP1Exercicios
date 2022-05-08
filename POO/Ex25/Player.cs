using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex25
{
    public class Player : Character
    {
        public override char Move()
        {
            Console.WriteLine("Move in a direction:\n" +
                "W - North; A - West; S - South, D - East");

            char input = Console.ReadLine().ToUpper()[0];

            switch(input)
            {
                case 'W': return 'N';
                case 'A': return 'W';
                case 'S': return 'S';
                case 'D': return 'E';
                default: return '?';
            }
        }
    }
}