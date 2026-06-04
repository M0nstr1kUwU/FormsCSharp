using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2() { InitializeComponent(); }

        private void Form2_Load(object sender, EventArgs e){}

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)
                && !listBox1.Items.Contains(textBox1.Text)
                && !banlist.Items.Contains(textBox1.Text)
                )
                listBox1.Items.Add(textBox1.Text);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                banlist.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem); 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}

        private void banlist_SelectedIndexChanged(object sender, EventArgs e){}
    }
}
