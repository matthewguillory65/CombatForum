using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace Assessment._4
{
    public partial class Form1 : Form
    {
        Singleton SI = Singleton.Instance;
        public Form1()
        {

            InitializeComponent();
            Singleton.Instance.Heroz.ForEach(x =>
            {
                comboBox1.Items.Add(x.Name);
                comboBox2.Items.Add(x.Name);

            });


            textBox2.Text = SI.currentDrogoon.Attack.ToString();
            textBox3.Text = SI.currentDrogoon.Alive.ToString();
            textBox1.Text = SI.currentDrogoon.Name;
            if (!Singleton.Instance.currentDrogoon.Alive)
            {
                Singleton.Instance.Combat.IfDead().ToString();
            }

            //textBox2.Text = SI.currentDrogoon.Attack.ToString();
            //    textBox3.Text = SI.currentDrogoon.Alive.ToString();
            //    textBox1.Text = SI.currentDrogoon.Name;
            //    if (!Singleton.Instance.currentDrogoon.Alive)
            //        Singleton.Instance.Combat.IfDead().ToString();
        }
        void SetUp()
        {
            AssessmentSerialization<List<Heros>>.Serialize("ListofPlayersDefualt", SI.Heroz);
        }

        public void CaseStatements()
        {
            //switch (SI.GM.currentState.ToUpper())
            //{
            //    case "START":
            //        break;
            //    case "IDLE":
            //        break;
            //    case "CHOOSECHARACTERS":
            //        break;
            //    case "ATKORDEF":
            //        break;
            //    case "BATTLE":
            //        break;
            //    case "END":
            //        break;
            //}
        }

        //comboBox1.Items.Add(new Heros(10, 200, "Defender"));
        //comboBox1.Items.Add(new Heros(160, 140, "Archer"));
        //comboBox1.Items.Add(new Heros(180, 120, "Warrior"));
        //comboBox1.Items.Add(SI.Heroz[0].Name);
        //comboBox2.Items.Add(SI.Heroz[0].Name);



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }



        //Singleton.Instance.Combat.Attack(comboBox1, comboBox2, Singleton.Instance.currentDrogoon);
        //Singleton.Instance.Combat.Defend(comboBox1, comboBox2, Singleton.Instance.currentDrogoon);

        //comboBox2.Items.Add(new Heros(10, 200, "Defender"));
        //comboBox2.Items.Add(new Heros(160, 140, "Archer"));
        //comboBox2.Items.Add(new Heros(180, 120, "Warrior"));

        private void button4_Click_1(object sender, EventArgs e)
        {
            SI.currentHero = AssessmentSerialization<Heros>.Deserialize("CurrentPlayer");
            SI.currentDrogoon = AssessmentSerialization<Enemy>.Deserialize("CurrentEnemy");


            textBox6.AppendText("Save Loaded     \n \n");
            textBox6.SelectionStart = textBox6.Text.Length;
            textBox6.ScrollToCaret();
            comboBox1.SelectionStart = comboBox1.SelectedIndex;
            comboBox2.SelectionStart = comboBox2.SelectedIndex;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AssessmentSerialization<Heros>.Serialize("CurrentPlayer", SI.currentHero);
            AssessmentSerialization<Enemy>.Serialize("CurrentEnemy", SI.currentDrogoon);
            AssessmentSerialization<string>.Serialize("TextLog", textBox6.Text);
            textBox6.SelectionStart = textBox6.Text.Length;
            textBox6.ScrollToCaret();
            comboBox1.SelectionStart = comboBox1.SelectedIndex;
            comboBox2.SelectionStart = comboBox2.SelectedIndex;
        }
    }
}

