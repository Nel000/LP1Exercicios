using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex25
{
    public abstract class Character
    {
        public string Name { get; }

        public abstract char Move();
    }
}