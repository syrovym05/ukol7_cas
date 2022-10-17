using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _17._10._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DateTime zacatek = new DateTime();
        DateTime konec = new DateTime();

        private void button1_Click(object sender, EventArgs e)
        {            
            button1.Enabled = false;
            button2.Enabled = true;

            zacatek = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;

            konec = DateTime.Now;

            TimeSpan interval = konec - zacatek;

            label1.Text = "minuty " + interval.TotalMinutes.ToString();
            label2.Text = "sekundy " + interval.TotalSeconds.ToString();

            //label1.Text += minuty.ToString();
            //label2.Text += sekundy.ToString();

        }
    }
}
