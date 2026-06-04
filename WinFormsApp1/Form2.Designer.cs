namespace WinFormsApp1
{
    partial class Form2
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
            create_btn = new Button();
            delete_btn = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            banlist = new ListBox();
            SuspendLayout();
            // 
            // create_btn
            // 
            create_btn.BackColor = SystemColors.ScrollBar;
            create_btn.FlatAppearance.BorderColor = Color.Silver;
            create_btn.Location = new Point(192, 11);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(84, 23);
            create_btn.TabIndex = 0;
            create_btn.Text = "Добавить";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = SystemColors.ScrollBar;
            delete_btn.FlatAppearance.BorderColor = Color.Silver;
            delete_btn.Location = new Point(282, 11);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(84, 23);
            delete_btn.TabIndex = 1;
            delete_btn.Text = "Удалить";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ScrollBar;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(354, 184);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(12, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // banlist
            // 
            banlist.BackColor = SystemColors.AppWorkspace;
            banlist.FormattingEnabled = true;
            banlist.Location = new Point(372, 12);
            banlist.Name = "banlist";
            banlist.Size = new Size(155, 214);
            banlist.TabIndex = 4;
            banlist.SelectedIndexChanged += banlist_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(633, 296);
            Controls.Add(banlist);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(delete_btn);
            Controls.Add(create_btn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_btn;
        private Button delete_btn;
        private ListBox listBox1;
        private TextBox textBox1;
        private ListBox banlist;
    }
}