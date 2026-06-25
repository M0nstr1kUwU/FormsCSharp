using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer2.Stop();
            timer1.Start();
        }
    }
}
