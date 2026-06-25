using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form19 : Form
    {
        private int oW;
        private int oH;
        public Form19()
        {
            InitializeComponent();

            trackBar1.Scroll += trackBar1_Scroll;
            oW = pictureBox1.Width;
            oH = pictureBox1.Height;
            if (pictureBox1.Width >= trackBar1.Value)
                trackBar1.Value = pictureBox1.Width;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int nW = trackBar1.Value;
            int nH = oH * nW / oW;
            pictureBox1.Width = nW;
            pictureBox1.Height = nH;
        }
    }
}
