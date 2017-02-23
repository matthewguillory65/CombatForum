using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
