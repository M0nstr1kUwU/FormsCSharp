namespace WinFormsApp1
{
    partial class Form16
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            trackBar1 = new TrackBar();
            button4 = new Button();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(213, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(1, 8);
            trackBar1.Maximum = 25;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(206, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.FlatAppearance.BorderColor = Color.Maroon;
            button4.FlatAppearance.BorderSize = 0;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(751, -1);
            button4.Name = "button4";
            button4.Size = new Size(49, 22);
            button4.TabIndex = 5;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(467, 13);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Заливка";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(340, 11);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(trackBar1);
            Controls.Add(comboBox1);
            Name = "Form16";
            Text = "Form16";
            Load += Form16_Load;
            MouseClick += Form16_MouseClick;
            MouseDown += Form16_MouseDown;
            MouseMove += Form16_MouseMove;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TrackBar trackBar1;
        private Button button4;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
    }
}