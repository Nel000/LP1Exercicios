using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex25
{
    public class NPC : Character
    {   
        public override char Move()
        {
            Random rand = new Random();

            string directions = "NSWE";

            return directions[rand.Next(directions.Length)];
        }
    }
}