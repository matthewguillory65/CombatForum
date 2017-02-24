﻿using System;
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

            //comboBox1.Items.Add(new Heros(10, 200, "Defender"));
            //comboBox1.Items.Add(new Heros(160, 140, "Archer"));
            //comboBox1.Items.Add(new Heros(180, 120, "Warrior"));
            //comboBox1.Items.Add(SI.Heroz[0].Name);
            //comboBox2.Items.Add(SI.Heroz[0].Name);
            Singleton.Instance.Heroz.ForEach(x => {
                comboBox1.Items.Add(x.Name);
                comboBox2.Items.Add(x.Name);
            });
            
            //comboBox2.Items.Add(new Heros(10, 200, "Defender"));
            //comboBox2.Items.Add(new Heros(160, 140, "Archer"));
            //comboBox2.Items.Add(new Heros(180, 120, "Warrior"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Singleton.Instance.Combat.Attack(comboBox1_SelectedIndexChanged, comboBox2_SelectedIndexChanged_1, Singleton.Instance.currentDrogoon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Singleton.Instance.Combat.Defend(comboBox1_SelectedIndexChanged, comboBox2_SelectedIndexChanged_1, Singleton.Instance.currentDrogoon);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Singleton.Instance.currentDrogoon.Name;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Singleton.Instance.currentDrogoon.Attack.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Singleton.Instance.currentDrogoon.Alive.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Defender");
            //comboBox1.Items.Add("Archer");
            //comboBox1.Items.Add("Warrior"); 

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Defender");
            //comboBox1.Items.Add("Archer");
            //comboBox1.Items.Add("Warrior");
        }
    }
}
