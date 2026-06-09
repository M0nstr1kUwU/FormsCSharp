using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        public List<String> f = ["", "", ""];
        public Form8()
        {
            InitializeComponent();
            listView1.Columns.Add("Имя", 120);
            listView1.Columns.Add("Возраст", 80);
            listView1.Columns.Add("Город", 150);
            comboBox1.Items.AddRange("Имя", "Возраст", "Город");
            comboBox2.Items.AddRange("Москва", "Санкт-Петербург", "Казань", "Владивосток", "Новоросийск", "Екатеринбург", "Самара");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
                comboBox2.Visible = true;
            else
                comboBox2.Visible = false;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string name = textBox1.Text.Trim();
                if (name.Length > 0 && !char.IsUpper(name[0]))
                {
                    label1.Text = "Слово должно начинаться с заглавной буквы!";
                    timer1.Start();
                    return;
                }
                f[0] = name;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (!int.TryParse(textBox1.Text.Trim(), out _))
                {
                    label1.Text = "Возраст только числами!";
                    timer1.Start();
                    return;
                }
                f[1] = textBox1.Text;
            }
            else if (comboBox1.SelectedIndex == 2)
                f[2] = $"{comboBox2.SelectedItem}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new[] { $"{f[0]}", $"{f[1]}", $"{f[2]}" }));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "";
            timer1.Stop();
        }
    }
}
