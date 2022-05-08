using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex31
{
    public abstract class GameObject
    {
        public float X { get; protected set; }
        public float Y { get; protected set; }
        public abstract int Priority();
        public virtual bool IsActive() { return true; }
    }
}