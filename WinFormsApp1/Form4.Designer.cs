namespace WinFormsApp1
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            label1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(28, 112);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSlateGray;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.Location = new Point(157, 112);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSlateGray;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button3.Location = new Point(279, 112);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Silver;
            progressBar1.Location = new Point(17, 87);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 19);
            progressBar1.TabIndex = 3;
            progressBar1.Value = 100;
            progressBar1.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressBar2.BackColor = Color.Silver;
            progressBar2.Location = new Point(143, 87);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(100, 19);
            progressBar2.TabIndex = 4;
            progressBar2.Value = 100;
            progressBar2.Click += progressBar2_Click;
            // 
            // progressBar3
            // 
            progressBar3.BackColor = Color.Silver;
            progressBar3.Location = new Point(267, 87);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(100, 19);
            progressBar3.TabIndex = 5;
            progressBar3.Value = 100;
            progressBar3.Click += progressBar3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatAppearance.BorderSize = 0;
            button4.Location = new Point(157, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Restart";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 54);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // button5
            // 
            button5.Location = new Point(311, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(386, 218);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
        private Label label1;
        private System.Windows.Forms.Timer timer2;
        private Button button5;
    }
}