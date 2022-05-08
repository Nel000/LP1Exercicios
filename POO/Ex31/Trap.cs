using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex31
{
    public class Trap : GameObject
    {
        public override int Priority() { return int.MaxValue; }
        public void DisableTrap() { Console.WriteLine("Trap is now disabled."); }
    }
}