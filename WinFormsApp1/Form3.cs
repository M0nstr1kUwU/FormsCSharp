using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public int p1, p2, p3, p4, p5, w1 = 0, w2 = 0, w3 = 0, w4 = 0, w5 = 0, res = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = $"1:{w1} | 2:{w2} | 3:{w3} | 4:{w4} | 5:{w5} | r:{res}";
            p1 = RandomNumberGenerator.GetInt32(1, 11);
            p2 = RandomNumberGenerator.GetInt32(1, 11);
            p3 = RandomNumberGenerator.GetInt32(1, 11);
            p4 = RandomNumberGenerator.GetInt32(1, 11);
            p5 = RandomNumberGenerator.GetInt32(1, 11);

            if (progressBar1.Value + p1 < progressBar1.Maximum)
                progressBar1.Value += p1;
            else
            {
                timer1.Enabled = false;
                progressBar1.Value = 100;
                label1.Text = "Win 1 ProgressBar";
                w1++;
            }
            if (progressBar2.Value + p2 < progressBar2.Maximum)
                progressBar2.Value += p2;
            else
            {
                timer1.Enabled = false;
                progressBar2.Value = 100;
                label1.Text = "Win 2 ProgressBar";
                w2++;
            }
            if (progressBar3.Value + p3 < progressBar3.Maximum)
                progressBar3.Value += p3;
            else
            {
                timer1.Enabled = false;
                progressBar3.Value = 100;
                label1.Text = "Win 3 ProgressBar";
                w3++;
            }
            if (progressBar4.Value + p4 < progressBar4.Maximum)
                progressBar4.Value += p4;
            else
            {
                timer1.Enabled = false;
                progressBar4.Value = 100;
                label1.Text = "Win 4 ProgressBar";
                w4++;
            }
            if (progressBar5.Value + p5 < progressBar5.Maximum)
                progressBar5.Value += p5;
            else
            {
                timer1.Enabled = false;
                progressBar5.Value = 100;
                label1.Text = "Win 5 ProgressBar";
                w5++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                res++;
                label1.Text = "";
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                progressBar4.Value = 0;
                progressBar5.Value = 0;
                timer1.Start();
        }
    }
}
