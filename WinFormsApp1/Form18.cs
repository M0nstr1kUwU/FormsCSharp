using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            FillListView();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void FillListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

            listView1.Columns.Add("Фамилия", 120);
            listView1.Columns.Add("Имя", 120);
            listView1.Columns.Add("Группа", 100);

            AddRow("Иванов", "Иван", "ИС-21");
            AddRow("Петров", "Пётр", "ИС-22");
            AddRow("Сидорова", "Анна", "ИС-21");
            AddRow("Кузнецов", "Максим", "ИС-23");
        }

        private void AddRow(string surname, string name, string group)
        {
            ListViewItem item = new ListViewItem(surname);

            item.SubItems.Add(name);
            item.SubItems.Add(group);

            listView1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem selectedRow = listView1.SelectedItems[0];
            label1.Text = selectedRow.SubItems[0].Text;
            label2.Text = selectedRow.SubItems[1].Text;
            label3.Text = selectedRow.SubItems[2].Text;
            listView1.Items.Remove(selectedRow);
        }
    }
}
