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
            Heros Defender = new Heros(10, 200);
            Heros Archer = new Heros(160, 140);
            Heros Warrior = new Heros(180, 120);

            Enemy LavaDragon = new Enemy(300);
            Enemy RockDragon = new Enemy(280);
            Enemy VolticDragon = new Enemy(190);
            Enemy ArmoredDragon = new Enemy(200);
            Enemy SkeleDragon = new Enemy(240);
            Enemy WaterDragon = new Enemy(140);

            List<Heros> Hoomans = new List<Heros>();
            List<Enemy> Drogoons = new List<Enemy>();

            Hoomans.Add(Defender);
            Hoomans.Add(Archer);
            Hoomans.Add(Warrior);

            Drogoons.Add(LavaDragon);
            Drogoons.Add(RockDragon);
            Drogoons.Add(VolticDragon);
            Drogoons.Add(ArmoredDragon);
            Drogoons.Add(SkeleDragon);
            Drogoons.Add(WaterDragon);
            Singleton.Instance.Heroz = Defender;
            Singleton.Instance.currentDrogoon = Drogoons.First();
            Singleton.Instance.currentHero = Hoomans.First();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
