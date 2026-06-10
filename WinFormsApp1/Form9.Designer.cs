namespace WinFormsApp1
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            pictureBox1 = new PictureBox();
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(299, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 219);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hScrollBar1.Location = new Point(9, 424);
            hScrollBar1.Maximum = 1000;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(765, 17);
            hScrollBar1.TabIndex = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            vScrollBar1.Location = new Point(774, 9);
            vScrollBar1.Maximum = 1000;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 415);
            vScrollBar1.TabIndex = 2;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(pictureBox1);
            Name = "Form9";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
    }
}