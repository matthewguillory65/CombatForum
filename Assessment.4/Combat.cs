using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{
    class Combat
    {
        void Attack(Heros H1, Heros H2, Enemy Dragon)
        {
            int newAttack;

            newAttack = H1.Attack + H2.Attack;

            if (newAttack > Dragon.Attack)
            {

            }

            else
            {
                H1.Alive = false;
                H2.Alive = false;
            }
        }

        void Defend(Heros H1, Heros H2, Enemy Dragon)
        {
            int newDefense;
            int newAttack;
            newDefense = H1.Defense + H2.Defense;

            if (newDefense > Dragon.Attack)
            {
                newAttack = newDefense - Dragon.Attack;
                Dragon.Attack = newAttack;
            }

            else
            {
                H1.Alive = false;
                H2.Alive = false;
            }
        }
    }
}
