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
    public partial class Form6 : Form
    {
        public string result;
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            result = textBox1.Text;
            if (checkBox1.Checked)
            {
                int rand = RandomNumberGenerator.GetInt32(100, 1000);
                result += rand.ToString();
            }
            if (checkBox2.Checked)
            {
                bool lef = false;
                for (int i = 0; i < result.Length; i++)
                {
                    if (char.IsLetter(result[i]))
                    {
                        char up = char.ToUpper(result[i]);
                        result = result.Remove(i, 1).Insert(i, up.ToString());
                        lef = true;
                        break;
                    }
                }
                if (!lef)
                {
                    char rand = (char)RandomNumberGenerator.GetInt32('A', 'Z' + 1);
                    result += rand;
                }
            }
            if (checkBox3.Checked)
            {
                string spec = "!@#$%^&*?_-+=()[]{};:,.|/\\~";
                int id = RandomNumberGenerator.GetInt32(0, spec.Length);
                char spec_c = spec[id];
                result += spec_c;
            }
            label1.Text = $"Password: {result}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) { }
    }
}
