using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            Text = "Тамагочи";
            Size = new Size(760, 520);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            InitializeShopItems();
            BuildInterface();
            RestartGame();
        }

        private void progressBar1_Click(object sender, EventArgs e) { }

        private int health;
        private int food;
        private int water;
        private int money;

        private readonly System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();

        private ColoredProgressBar healthBar = null!;
        private ColoredProgressBar foodBar = null!;
        private ColoredProgressBar waterBar = null!;

        private Label lblMoney = null!;
        private Label lblStatus = null!;
        private Label lblSelectedFood = null!;

        private Button btnSleep = null!;
        private Button btnPlay = null!;
        private Button btnWork = null!;
        private Button btnDrink = null!;
        private Button btnRestart = null!;
        private Button btnBuyFood = null!;
        private Button btnEatFood = null!;

        private ComboBox cmbFood = null!;
        private ListBox lstInventory = null!;
        private Panel shopPanel = null!;

        private readonly List<FoodItem> shopItems = new List<FoodItem>();
        private readonly List<FoodItem> inventory = new List<FoodItem>();

        private void InitializeShopItems()
        {
            shopItems.Add(new FoodItem("Яблоко", 5, 15, 0, 2));
            shopItems.Add(new FoodItem("Бутерброд", 10, 30, 0, 3));
            shopItems.Add(new FoodItem("Суп", 14, 25, 15, 6));
            shopItems.Add(new FoodItem("Рыба", 18, 40, 0, 8));
            shopItems.Add(new FoodItem("Пирог", 25, 55, -5, -3));
        }

        private void BuildInterface()
        {
            Font = new Font("Segoe UI", 10);

            Label title = new Label
            {
                Text = "🐾 Тамагочи",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(25, 20),
                AutoSize = true
            };
            Controls.Add(title);

            lblMoney = new Label
            {
                Text = "$: 0",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(610, 25),
                AutoSize = true
            };
            Controls.Add(lblMoney);

            healthBar = CreateProgressBar("Здоровье", Color.IndianRed, 25, 95);
            foodBar = CreateProgressBar("Еда", Color.Orange, 25, 165);
            waterBar = CreateProgressBar("Вода", Color.DeepSkyBlue, 25, 235);

            Controls.Add(healthBar);
            Controls.Add(foodBar);
            Controls.Add(waterBar);

            btnSleep = CreateButton("Спать", 390, 95, BtnSleep_Click);
            btnPlay = CreateButton("Играть", 520, 95, BtnPlay_Click);
            btnWork = CreateButton("Искать $", 390, 150, BtnWork_Click);
            btnDrink = CreateButton("Попить воды", 520, 150, BtnDrink_Click);

            Controls.Add(btnSleep);
            Controls.Add(btnPlay);
            Controls.Add(btnWork);
            Controls.Add(btnDrink);

            lblStatus = new Label
            {
                Text = "",
                Location = new Point(8, 410),
                Size = new Size(690, 40),
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            Controls.Add(lblStatus);

            BuildShopPanel();

            btnRestart = new Button
            {
                Text = "Рестарт",
                Location = new Point(300, 410),
                Size = new Size(150, 45),
                Visible = false,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnRestart.Click += BtnRestart_Click;
            Controls.Add(btnRestart);

            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private ColoredProgressBar CreateProgressBar(string text, Color color, int x, int y)
        {
            Label label = new Label
            {
                Text = text,
                Location = new Point(x, y - 25),
                AutoSize = true,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            Controls.Add(label);

            return new ColoredProgressBar
            {
                Location = new Point(x, y),
                Size = new Size(310, 35),
                Maximum = 100,
                Value = 100,
                BarColor = color
            };
        }

        private Button CreateButton(string text, int x, int y, EventHandler click)
        {
            Button button = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(110, 38),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            button.Click += click;
            return button;
        }

        private void BuildShopPanel()
        {
            shopPanel = new Panel
            {
                Location = new Point(390, 220),
                Size = new Size(320, 175),
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(shopPanel);

            Label shopTitle = new Label
            {
                Text = "Магазин еды",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            shopPanel.Controls.Add(shopTitle);

            cmbFood = new ComboBox
            {
                Location = new Point(10, 42),
                Size = new Size(290, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFood.SelectedIndexChanged += CmbFood_SelectedIndexChanged;
            shopPanel.Controls.Add(cmbFood);

            lblSelectedFood = new Label
            {
                Text = "",
                Location = new Point(10, 75),
                Size = new Size(290, 35)
            };
            shopPanel.Controls.Add(lblSelectedFood);

            btnBuyFood = new Button
            {
                Text = "Купить",
                Location = new Point(10, 115),
                Size = new Size(90, 35)
            };
            btnBuyFood.Click += BtnBuyFood_Click;
            shopPanel.Controls.Add(btnBuyFood);

            btnEatFood = new Button
            {
                Text = "Съесть",
                Location = new Point(110, 115),
                Size = new Size(90, 35)
            };
            btnEatFood.Click += BtnEatFood_Click;
            shopPanel.Controls.Add(btnEatFood);

            lstInventory = new ListBox
            {
                Location = new Point(210, 90),
                Size = new Size(90, 65)
            };
            shopPanel.Controls.Add(lstInventory);

            foreach (FoodItem item in shopItems)
            {
                cmbFood.Items.Add(item);
            }

            cmbFood.SelectedIndex = 0;
        }

        private void RestartGame()
        {
            health = 100;
            food = 80;
            water = 80;
            money = 25;

            inventory.Clear();
            RefreshInventory();

            btnRestart.Visible = false;
            SetGameControlsEnabled(true);

            lblStatus.Text = "Питомец ждёт заботы!";
            UpdateInterface();

            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            food -= 2;
            water -= 3;

            if (food < 30)
            {
                health -= 2;
            }

            if (water < 30)
            {
                health -= 3;
            }

            if (food > 60 && water > 60 && health < 100)
            {
                health += 1;
            }

            ClampStats();
            UpdateInterface();

            if (health <= 0 || food <= 0 || water <= 0)
            {
                GameOver();
            }
        }

        private void BtnSleep_Click(object sender, EventArgs e)
        {
            health += 20;
            food -= 10;
            water -= 8;

            lblStatus.Text = "Питомец поспал. Здоровье выросло, но он проголодался.";

            AfterAction();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            health += 5;
            food -= 12;
            water -= 12;
            money += 4;

            lblStatus.Text = "Вы поиграли с питомцем и нашли немного денег.";

            AfterAction();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            money += 15;
            health -= 5;
            food -= 8;
            water -= 8;

            lblStatus.Text = "Питомец помог найти деньги, но немного устал.";

            AfterAction();
        }

        private void BtnDrink_Click(object sender, EventArgs e)
        {
            water += 25;

            lblStatus.Text = "Питомец попил воды.";

            AfterAction();
        }

        private void BtnBuyFood_Click(object sender, EventArgs e)
        {
            if (cmbFood.SelectedItem == null)
            {
                return;
            }

            FoodItem item = (FoodItem)cmbFood.SelectedItem;

            if (money < item.Price)
            {
                lblStatus.Text = "Недостаточно денег для покупки.";
                return;
            }

            money -= item.Price;
            inventory.Add(item);

            lblStatus.Text = $"Куплено: {item.Name}. Теперь можно съесть из инвентаря.";

            RefreshInventory();
            UpdateInterface();
        }

        private void BtnEatFood_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedItem == null)
            {
                lblStatus.Text = "Сначала выбери еду в инвентаре.";
                return;
            }

            FoodItem item = (FoodItem)lstInventory.SelectedItem;

            food += item.FoodRestore;
            water += item.WaterRestore;
            health += item.HealthRestore;

            inventory.Remove(item);

            lblStatus.Text = $"Питомец съел: {item.Name}.";

            RefreshInventory();
            AfterAction();
        }

        private void CmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFood.SelectedItem == null)
            {
                return;
            }

            FoodItem item = (FoodItem)cmbFood.SelectedItem;

            lblSelectedFood.Text =
                $"Цена: ${item.Price} | Еда: +{item.FoodRestore} | Вода: {FormatValue(item.WaterRestore)} | Здоровье: {FormatValue(item.HealthRestore)}";
        }

        private string FormatValue(int value)
        {
            if (value > 0)
            {
                return "+" + value;
            }

            return value.ToString();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void AfterAction()
        {
            ClampStats();
            UpdateInterface();

            if (health <= 0 || food <= 0 || water <= 0)
            {
                GameOver();
            }
        }

        private void ClampStats()
        {
            health = Clamp(health, 0, 100);
            food = Clamp(food, 0, 100);
            water = Clamp(water, 0, 100);
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
        }

        private void UpdateInterface()
        {
            healthBar.Value = health;
            foodBar.Value = food;
            waterBar.Value = water;

            lblMoney.Text = "$: " + money;

            btnEatFood.Enabled = inventory.Count > 0;

            if (health < 30 || food < 30 || water < 30)
            {
                BackColor = Color.MistyRose;
            }
            else
            {
                BackColor = SystemColors.Control;
            }
        }

        private void RefreshInventory()
        {
            lstInventory.Items.Clear();

            foreach (FoodItem item in inventory)
            {
                lstInventory.Items.Add(item);
            }

            if (lstInventory.Items.Count > 0)
            {
                lstInventory.SelectedIndex = 0;
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();

            health = Clamp(health, 0, 100);
            food = Clamp(food, 0, 100);
            water = Clamp(water, 0, 100);

            UpdateInterface();

            lblStatus.Text = "Игра окончена";
            SetGameControlsEnabled(false);

            btnRestart.Visible = true;
        }

        private void SetGameControlsEnabled(bool enabled)
        {
            btnSleep.Enabled = enabled;
            btnPlay.Enabled = enabled;
            btnWork.Enabled = enabled;
            btnDrink.Enabled = enabled;

            cmbFood.Enabled = enabled;
            btnBuyFood.Enabled = enabled;
            btnEatFood.Enabled = enabled && inventory.Count > 0;
            lstInventory.Enabled = enabled;
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }

    public class FoodItem
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int FoodRestore { get; private set; }
        public int WaterRestore { get; private set; }
        public int HealthRestore { get; private set; }

        public FoodItem(string name, int price, int foodRestore, int waterRestore, int healthRestore)
        {
            Name = name;
            Price = price;
            FoodRestore = foodRestore;
            WaterRestore = waterRestore;
            HealthRestore = healthRestore;
        }

        public override string ToString()
        {
            return $"{Name} ${Price}";
        }
    }

    public class ColoredProgressBar : Control
    {
        private int currentValue = 100;
        private int maximum = 100;
        private Color barColor = Color.Green;

        [DefaultValue(100)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                maximum = Math.Max(1, value);

                if (currentValue > maximum)
                {
                    currentValue = maximum;
                }

                Invalidate();
            }
        }

        [DefaultValue(100)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = Math.Max(0, Math.Min(Maximum, value));
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Green")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BarColor
        {
            get
            {
                return barColor;
            }
            set
            {
                barColor = value;
                Invalidate();
            }
        }

        public ColoredProgressBar()
        {
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle area = ClientRectangle;

            using (SolidBrush backgroundBrush = new SolidBrush(Color.WhiteSmoke))
            {
                e.Graphics.FillRectangle(backgroundBrush, area);
            }

            int fillWidth = 0;

            if (Maximum > 0)
            {
                fillWidth = (int)((Width - 2) * (Value / (double)Maximum));
            }

            Rectangle fillArea = new Rectangle(1, 1, fillWidth, Height - 2);

            using (SolidBrush fillBrush = new SolidBrush(BarColor))
            {
                e.Graphics.FillRectangle(fillBrush, fillArea);
            }

            using (Pen borderPen = new Pen(Color.Gray))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
            }

            string text = $"{Value}%";

            TextRenderer.DrawText(
                e.Graphics,
                text,
                Font,
                area,
                Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
