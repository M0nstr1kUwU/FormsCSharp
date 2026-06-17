using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form16 : Form
    {

        private struct DrawnShape
        {
            public Point Location;
            public Brush Brush;
            public int Size;
            public string Type;
        }
        private enum ShapeType { Circle, Square, Ellipse }
        private ShapeType cShape = ShapeType.Square;

        private List<DrawnShape> shapes = new List<DrawnShape>();
        private Brush cBrush = Brushes.White;

        public Form16()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            comboBox1.Items.AddRange(new string[] { "Круг", "Квадрат", "Эллипс" });
            comboBox2.Items.AddRange(new string[] 
            { 
                "White", 
                "Black",
                "Magenta",
                "Green",
                "Yellow",
                "Blue",
                "Red"
            });
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void AddShape(Point location)
        {
            string shapeStr = "Круг";
            if (cShape == ShapeType.Circle) shapeStr = "Квадрат";
            if (cShape == ShapeType.Ellipse) shapeStr = "Эллипс";

            shapes.Add(new DrawnShape
            {
                Location = location,
                Brush = cBrush,
                Size = trackBar1.Value,
                Type = shapeStr
            });

            this.Refresh();
        }
        private void Form16_Load(object sender, EventArgs e) { }
        private void Form16_MouseClick(object sender, MouseEventArgs e) { }
        private void Form16_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) AddShape(e.Location); }
        private void Form16_MouseDown(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) AddShape(e.Location); }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (DrawnShape s in shapes)
            {
                int fSize = s.Size / 2;
                int x = s.Location.X - fSize;
                int y = s.Location.Y - fSize;

                if (!checkBox1.Checked)
                {
                    if (s.Type == "Квадрат") g.FillRectangle(s.Brush, x, y, s.Size, s.Size);
                    else if (s.Type == "Круг") g.FillEllipse(s.Brush, x, y, s.Size, s.Size);
                    else if (s.Type == "Эллипс") g.FillEllipse(s.Brush, x, y, s.Size * 2, s.Size);
                }
                else
                {
                    using (Pen pen = new Pen(s.Brush, 2))
                    {
                        if (s.Type == "Квадрат") g.DrawRectangle(pen, x, y, s.Size, s.Size);
                        else if (s.Type == "Круг") g.DrawEllipse(pen, x, y, s.Size, s.Size);
                        else if (s.Type == "Эллипс") g.DrawEllipse(pen, x, y, s.Size * 2, s.Size);
                    }
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) cShape = ShapeType.Square;
            if (comboBox1.SelectedIndex == 1) cShape = ShapeType.Circle;
            if (comboBox1.SelectedIndex == 2) cShape = ShapeType.Ellipse;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) cBrush = Brushes.White;
            if (comboBox2.SelectedIndex == 1) cBrush = Brushes.Black;
            if (comboBox2.SelectedIndex == 2) cBrush = Brushes.Magenta;
            if (comboBox2.SelectedIndex == 3) cBrush = Brushes.Green;
            if (comboBox2.SelectedIndex == 4) cBrush = Brushes.Yellow;
            if (comboBox2.SelectedIndex == 5) cBrush = Brushes.Blue;
            if (comboBox2.SelectedIndex == 6) cBrush = Brushes.Red;
        }
        private void button4_Click(object sender, EventArgs e) { shapes.Clear(); Refresh(); }
    }
}
