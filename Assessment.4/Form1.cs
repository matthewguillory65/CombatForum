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
        Singleton.Instance.Heroz.ForEach(x=>
            {
                comboBox1.Items.Add(x.Name);
                comboBox2.Items.Add(x.Name);
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    });
            textBox2.Text = SI.currentDrogoon.Attack.ToString();
            textBox3.Text = SI.currentDrogoon.Alive.ToString();
            textBox1.Text = SI.currentDrogoon.Name;
            if (!Singleton.Instance.currentDrogoon.Alive)
                Singleton.Instance.Combat.IfDead().ToString();
    
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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

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



    //Singleton.Instance.Combat.Attack(comboBox1, comboBox2, Singleton.Instance.currentDrogoon);
    //Singleton.Instance.Combat.Defend(comboBox1, comboBox2, Singleton.Instance.currentDrogoon);

    //comboBox2.Items.Add(new Heros(10, 200, "Defender"));
    //comboBox2.Items.Add(new Heros(160, 140, "Archer"));
    //comboBox2.Items.Add(new Heros(180, 120, "Warrior"));
}
}