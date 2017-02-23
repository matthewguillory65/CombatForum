using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{
    public interface IGameManager
    {
        void Start();
        void Idle();
        void Attack();
        void Defend();
        void Dead();
        void End();
    }
}
