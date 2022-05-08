using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex31
{
    /// <summary>
    /// 1.
    /// </summary>
    public class PowerUp : GameObject, ITaggable
    {
        public string Tag { get; set; }

        public override int Priority()
        {
            return Tag.Length;
        }

        public override bool IsActive()
        {
            if (Priority() == null)
                return false;
            else
                return true;
        }

        // 2.
        public override string ToString()
        {
            return $"X - {X:f2}; Y - {Y:f2}, Tag - {Tag}";
        }
    }
}