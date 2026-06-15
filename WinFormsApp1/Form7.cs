using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        public int choice = 1, f = 0, heal = 5, damage = 10, block = 0;
        private Form12 _owner;
        public Form7(Form12 owner)
        {
            InitializeComponent();
            progressBar1.Value = progressBar1.Maximum;
            progressBar2.Value = progressBar2.Maximum;
            _owner = owner;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void progressBar1_Click(object sender, EventArgs e) { }
        private void progressBar2_Click(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { choice = 1; }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { choice = 2; }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { choice = 3; }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Text = $"Ход: {f}";
            label2.Text = "";
            if (progressBar1.Value <= progressBar1.Minimum ||
                progressBar2.Value <= progressBar1.Minimum)
                return;
            if (block == 0)
            {
                switch (choice)
                {
                    case 1:
                        if (progressBar2.Value - damage > progressBar2.Minimum)
                        {
                            progressBar2.Value -= damage;
                            label2.Text += $"Игрок ударил врага на -{damage}HP!\n";
                        }

                        else
                        {
                            progressBar2.Value = progressBar2.Minimum;
                            label1.Text = $"Игрок выиграл за {f} ходов!";
                            label2.Text = "";
                            button1.Visible = false;
                            button2.Visible = true;
                            _owner.up_score(25);
                        }
                        f++;
                        break;
                    case 2:
                        if (progressBar1.Value + heal <= progressBar1.Maximum)
                            progressBar1.Value += heal;
                        else
                            progressBar1.Value = progressBar1.Maximum;
                        label2.Text += $"Игрок похилился на +{heal}HP!\n";
                        f++;
                        break;
                    case 3:
                        if (progressBar2.Value - (damage * 2) > progressBar2.Minimum)
                        {
                            progressBar2.Value -= damage * 2;
                            label2.Text += $"Игрок использовал ультимейт и ударил врага на -{damage * 2}HP!\n";
                        }
                        else
                        {
                            progressBar2.Value = progressBar2.Minimum;
                            label1.Text = $"Игрок выиграл за {f} ходов!";
                            label2.Text = "";
                            button1.Visible = false;
                            button2.Visible = true;
                            _owner.up_score(25);
                        }
                        if (progressBar1.Value + heal * 2 <= progressBar1.Maximum)
                            progressBar1.Value += heal * 2;
                        else
                            progressBar1.Value = progressBar1.Maximum;
                        label2.Text += $"Игрок похилился на {heal * 2}!\n";
                        f++;
                        break;
                    default:
                        break;
                }
            }
            else
                block--;

            if (progressBar1.Value <= progressBar1.Minimum ||
                progressBar2.Value <= progressBar1.Minimum)
                return;

            int choice_entity = RandomNumberGenerator.GetInt32(1, 4);

            switch (choice_entity)
            {
                case 1:
                    if (progressBar1.Value - damage > progressBar1.Minimum)
                    {
                        progressBar1.Value -= damage;
                        label2.Text += $"Враг ударил врага на -{damage}HP!\n";
                    }

                    else
                    {
                        progressBar1.Value = progressBar1.Minimum;
                        label1.Text = $"Враг выиграл за {f} ходов!";
                        label2.Text = "";
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    break;
                case 2:
                    if (progressBar2.Value + heal <= progressBar2.Maximum)
                        progressBar2.Value += heal;
                    else
                        progressBar2.Value = progressBar2.Maximum;
                    label2.Text += $"Враг похилился на +{heal}HP!\n";
                    break;
                case 3:
                    if (progressBar1.Value - (damage * 2) > progressBar1.Minimum)
                    {
                        progressBar1.Value -= damage * 2;
                        label2.Text += $"Враг использовал ультимейт и ударил игрока на -{damage}HP!\n";
                    }
                    else
                    {
                        progressBar1.Value = progressBar1.Minimum;
                        label1.Text = $"Враг выиграл за {f} ходов!";
                        label2.Text = "";
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    if (progressBar2.Value + heal * 2 <= progressBar2.Maximum)
                        progressBar2.Value += heal * 2;
                    else
                        progressBar2.Value = progressBar2.Maximum;
                    label2.Text += $"Враг похилился на +{heal * 2}HP!\n";
                    block++;
                    break;
                default:
                    break;
            }
            if (progressBar1.Value >= progressBar1.Minimum ||
                progressBar2.Value >= progressBar1.Minimum)
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Visible = true;
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
            progressBar2.Value = progressBar2.Maximum;
            f = 0;
            block = 0;
            choice = 1;
            button1.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e) { Close(); }
    }
}
