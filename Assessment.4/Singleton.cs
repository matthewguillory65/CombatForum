using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{
    public class Singleton
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
        public Heros currentHero2;
        public Enemy currentDrogoon;
        //public FSM GM;
        public Combat Combat;
        public List<Heros> Heroz;
        public List<Enemy> Enemys;
    }
}
