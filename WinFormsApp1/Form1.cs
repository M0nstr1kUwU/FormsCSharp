using System.Drawing.Imaging;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int fa = 0;
        List<Color> colors = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            colors.Add(Color.Aqua);
            colors.Add(Color.Red);
            colors.Add(Color.Violet);
            colors.Add(Color.Gold);
            colors.Add(Color.Firebrick);
            colors.Add(Color.Navy);
            colors.Add(Color.DarkViolet);
            colors.Add(Color.AliceBlue);
            colors.Add(Color.BurlyWood);
            colors.Add(Color.CornflowerBlue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{fa}";
            label1.BackColor = colors[fa % 10];
            fa++;
        }
    }
}
