using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form14 : Form
    {
        List<Point> points = new List<Point>();
        Brush brush = Brushes.White;
        public Form14()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form14_Load(object sender, EventArgs e) { }

        private void Form14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Add(e.Location);
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            foreach (Point p in points)
            {
                g.FillRectangle(brush, p.X - 10, p.Y - 10, trackBar1.Value, trackBar1.Value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //brush = comboBox1.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brush = Brushes.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brush = Brushes.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brush = Brushes.Blue;
        }
    }
}
