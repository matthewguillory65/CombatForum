using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{
    class Singleton
    {
        private static Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public Heros currentHero;
        public Enemy currentDrogoon;
        //public FSM GM;
        public Combat Combat;
        public Heros Heroz;
    }
}
