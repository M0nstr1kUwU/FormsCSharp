using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form10 : Form
    {
        public int num_pow;
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            num_pow = int.Parse(textBox1.Text);

            Form11 form11 = new Form11(this);
            form11.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e) { }

        public void proc_label(string result)
        {
            label1.Text = result;
        }
    }
}
