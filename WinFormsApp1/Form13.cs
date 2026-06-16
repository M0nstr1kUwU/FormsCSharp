using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form13 : Form
    {
        private struct DrawItem
        {
            public Point Location;
            public MouseButtons Button;
        }
        private List<DrawItem> _drawingHistory = new List<DrawItem>();
        private bool _isDrawing = false;

        public Form13()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.Paint += Form1_Paint;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                _isDrawing = true;
                AddPoint(e.Location, e.Button);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing && (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right))
            {
                AddPoint(e.Location, e.Button);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        private void AddPoint(Point location, MouseButtons button)
        {
            _drawingHistory.Add(new DrawItem { Location = location, Button = button });
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int size = 10;

            foreach (var item in _drawingHistory)
            {
                int x = item.Location.X - (size / 2);
                int y = item.Location.Y - (size / 2);

                if (item.Button == MouseButtons.Left)
                {
                    using (Pen pen = new Pen(Color.Wheat, 2))
                    {
                        g.DrawEllipse(pen, x, y, size, size);
                    }
                }
                else if (item.Button == MouseButtons.Right)
                {
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        g.FillEllipse(brush, x, y, size, size);
                    }
                }
            }
        }
    }
}
