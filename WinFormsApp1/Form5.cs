using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public int radio, dig = 2;
        public double result;
        public Form5()
        {
            InitializeComponent();
            radioButton1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            switch (radio)
            {
                case 1:
                    result = Math.Round(Math.Pow(a, 2), dig);
                    break;
                case 2:
                    result = Math.Round(Math.Pow(a*Math.PI, 2), dig);
                    break;
                case 3:
                    result = Math.Round(Math.Log2(a), dig);
                    break;
                default:
                    break;
            }

            label1.Text = $"Result: {result}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { radio = 1; }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { radio = 2; }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { radio = 3; }
    }
}
