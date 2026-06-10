using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) { ch(); }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) { ch(); }
        private void ch() { pictureBox1.Location = new Point(hScrollBar1.Value, vScrollBar1.Value); }
    }
}
