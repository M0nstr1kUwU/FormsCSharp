using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form11 : Form
    {
        private Form10 _owner;
        public Form11(Form10 owner)
        {
            InitializeComponent();
            _owner = owner;
            label1.Text = $"Вы уверены? ({_owner.num_pow}^2)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _owner.proc_label(
                $"Результат: {Math.Pow(_owner.num_pow, 2)}"
            );
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _owner.proc_label("Действие отменено");
            Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
