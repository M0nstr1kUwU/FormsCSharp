using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form12 : Form
    {
        public int score = 0;
        public bool changed = true;
        public Form12()
        {
            InitializeComponent();
            menuStrip1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status_change($"{menuStrip1.Items[0].Text}");
            Form7 form7 = new Form7(this);
            form7.ShowDialog();
            status_change("None");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            status_change($"{menuStrip1.Items[1].Text}");
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
            status_change("None");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status_change($"{menuStrip1.Items[2].Text}");
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
            status_change("None");
        }

        public void up_score(int amount)
        {
            label2.Text = $"Score: {score += amount}";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status_change($"{menuStrip1.Items[0].Text}");
            Form7 form7 = new Form7(this);
            form7.ShowDialog();
            status_change("None");

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            status_change($"{menuStrip1.Items[1].Text}");
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
            status_change("None");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            status_change($"{menuStrip1.Items[2].Text}");
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
            status_change("None");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                menuStrip1.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                label1.Visible = false;
                changed = false;
            }
            else
            {
                menuStrip1.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label1.Visible = true;
                changed = true;
            }
        }

        private void status_change(string name) { menuStrip1.Items[3].Text = $"Status: {name}"; }
    }
}
