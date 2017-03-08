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
            
            comboBox1.Items.Add(new Heros());
            comboBox1.Items.Add(new Heros());
            comboBox1.Items.Add(new Heros());

            comboBox2.Items.Add(new Heros());
            comboBox2.Items.Add(new Heros());
            comboBox2.Items.Add(new Heros());
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


        private void button1_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Combat.Attack(comboBox1_SelectedIndexChanged, comboBox2_SelectedIndexChanged_1, Singleton.Instance.currentDrogoon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Combat.Defend(comboBox1_SelectedIndexChanged, comboBox2_SelectedIndexChanged_1, Singleton.Instance.currentDrogoon);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = ActiveDrogoon.Attack.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3.Text = ActiveDrogoon.Defense.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Loading previous save...");
            SI.currentHero = AssessmentSerialization<Heros>.Deserialize("CurrentPlayer");
            SI.currentDrogoon = AssessmentSerialization<Enemy>.Deserialize("CurrentEnemy");


            TextLog.AppendText("Previous Save Loaded... \n");
            Debug.WriteLine("Previous Save Loaded");
            TextLog.SelectionStart = TextLog.Text.Length;
            TextLog.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Saving current progress...");
            AssessmentSerialization<Heros>.Serialize("CurrentPlayer", SI.currentHero);
            AssessmentSerialization<Enemy>.Serialize("CurrentEnemy", SI.currentDrogoon);
            AssessmentSerialization<string>.Serialize("TextLog", TextLog.Text);
            TextLog.SelectionStart = TextLog.Text.Length;
            TextLog.ScrollToCaret();
        }
    }
}
