using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex8
{
    public abstract class NPC
    {
        public float HP { get; protected set; }

        public NPC(float hp)
        {
            HP = hp;
        }

        public void PlayTurn()
        {
            if (FindEnemies())
            {
                AttackEnemies();
            }
            if (FindFood())
            {
                EatFood();
            }
            Move();
        }

        protected abstract bool FindFood();
        protected abstract bool FindEnemies();
        protected abstract void EatFood();
        protected abstract void AttackEnemies();

        protected virtual void Move()
        {
            Console.WriteLine(this.GetType() + " has moved!");
        }
    }
}