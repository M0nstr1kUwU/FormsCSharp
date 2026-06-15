using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public int cost = 7, fill = 15, time = 0;
        private Form12 _owner;
        public Form4(Form12 owner)
        {
            InitializeComponent();
            button4.Visible = false;
            _owner = owner;
        }

        private void progressBar1_Click(object sender, EventArgs e) { }
        private void progressBar2_Click(object sender, EventArgs e) { }
        private void progressBar3_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value + fill <= progressBar1.Maximum)
                progressBar1.Value += fill;
            else progressBar1.Value = progressBar1.Maximum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value + fill <= progressBar2.Maximum)
                progressBar2.Value += fill;
            else progressBar2.Value = progressBar2.Maximum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value + fill <= progressBar3.Maximum)
                progressBar3.Value += fill;
            else progressBar3.Value = progressBar3.Maximum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value - cost >= progressBar1.Minimum)
                progressBar1.Value -= cost;
            else
            {
                lose();
                progressBar1.Value = progressBar1.Minimum;
            }

            if (progressBar2.Value - cost >= progressBar2.Minimum)
                progressBar2.Value -= cost;
            else
            {
                lose();
                progressBar2.Value = progressBar2.Minimum;
            }

            if (progressBar3.Value - cost >= progressBar3.Minimum)
                progressBar3.Value -= cost;
            else
            {
                lose();
                progressBar3.Value = progressBar3.Minimum;
            }
        }

        private void v_di()
        {
            button4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }
        private void v_en()
        {
            button4.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void lose()
        {
            v_di();
            timer1.Stop();
            timer2.Stop();
            label1.Text = "You Lose!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
            progressBar2.Value = progressBar2.Maximum;
            progressBar3.Value = progressBar3.Maximum;
            v_en();
            label1.Text = "";
            time = 0;
            cost = 7;
            timer1.Start();
            timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time < 120)
            {
                label1.Text = $"{time}/{120}";
                time++;
                if (time == 60)
                    cost *= 2;
            }
            else
            {
                v_di();
                timer1.Stop();
                timer2.Stop();
                label1.Text = "You win!";
                _owner.up_score(50);
            }
        }

        private void button5_Click(object sender, EventArgs e) { Close(); }
    }
}
