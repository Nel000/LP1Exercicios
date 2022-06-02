using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex47
{
    public interface ILightSource
    {
        double Illuminance { get; }
    }
}