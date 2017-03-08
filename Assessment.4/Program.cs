using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment._4
{
    static class Program
    {
        enum States
        {
            init, idle, exit
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Heros Defender = new Heros(10, 200, "Defender");
            Heros Archer = new Heros(160, 140, "Archer");
            Heros Warrior = new Heros(180, 120, "Warrior");

            Enemy LavaDragon = new Enemy(300, "LavaDragon");
            Enemy RockDragon = new Enemy(280, "Armored Dragon");
            Enemy VolticDragon = new Enemy(190, "VolticDragon");
            Enemy ArmoredDragon = new Enemy(200, "RockDragon");
            Enemy SkeleDragon = new Enemy(240, "SkeleDragon");
            Enemy WaterDragon = new Enemy(140, "WaterDragon");

            Singleton.Instance.Heroz = new List<Heros>();
            List<Enemy> Drogoons = new List<Enemy>();

            Singleton.Instance.Heroz.Add(Defender);
            Singleton.Instance.Heroz.Add(Archer);
            Singleton.Instance.Heroz.Add(Warrior);

            //This Lambda: Uses a ForEach loop, while x = the numeral in the list, (in this instance), until the list is done
            //int i = Singleton.Instance.Heroz.Count() - 1;
            //Singleton.Instance.Heroz.ForEach((x => Singleton.Instance.Heroz.Add(x)));


            Drogoons.Add(LavaDragon);
            Drogoons.Add(RockDragon);
            Drogoons.Add(VolticDragon);
            Drogoons.Add(ArmoredDragon);
            Drogoons.Add(SkeleDragon);
            Drogoons.Add(WaterDragon);
            
            Singleton.Instance.currentDrogoon = Drogoons.First();
            //Singleton.Instance.currentHero = Singleton.Instance.Heroz.First();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
