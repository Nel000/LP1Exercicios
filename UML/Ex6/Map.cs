using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex6
{
    public abstract class Map
    {
        public string Name { get; }
        protected string Filename { get; }

        public void PrintPlayerNames();
    }
}