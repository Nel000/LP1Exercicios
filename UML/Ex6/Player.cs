using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex6
{
    public class Player
    {
        public int ID { get; }
        public string Name { get; }
        private double health;
        private double shield;

        public void PrintPlayerName();
    }
}