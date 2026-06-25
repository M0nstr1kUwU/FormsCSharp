namespace WinFormsApp1
{
    partial class Form17
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
            lblPlayerCards = new Label();
            lblDealerCards = new Label();
            lblResult = new Label();
            btnAddCard = new Button();
            btnCheck = new Button();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // lblPlayerCards
            // 
            lblPlayerCards.AutoSize = true;
            lblPlayerCards.Location = new Point(27, 102);
            lblPlayerCards.Name = "lblPlayerCards";
            lblPlayerCards.Size = new Size(0, 15);
            lblPlayerCards.TabIndex = 0;
            // 
            // lblDealerCards
            // 
            lblDealerCards.AutoSize = true;
            lblDealerCards.Location = new Point(27, 177);
            lblDealerCards.Name = "lblDealerCards";
            lblDealerCards.Size = new Size(0, 15);
            lblDealerCards.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 39);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            // 
            // btnAddCard
            // 
            btnAddCard.Location = new Point(50, 258);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.Size = new Size(124, 23);
            btnAddCard.TabIndex = 3;
            btnAddCard.Text = "Добавить карту";
            btnAddCard.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(180, 258);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Проверить";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(517, 1);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(96, 23);
            btnNewGame.TabIndex = 5;
            btnNewGame.Text = "Новая игра";
            btnNewGame.UseVisualStyleBackColor = true;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(616, 307);
            Controls.Add(btnNewGame);
            Controls.Add(btnCheck);
            Controls.Add(btnAddCard);
            Controls.Add(lblResult);
            Controls.Add(lblDealerCards);
            Controls.Add(lblPlayerCards);
            Name = "Form17";
            Text = "Form17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerCards;
        private Label lblDealerCards;
        private Label lblResult;
        private Button btnAddCard;
        private Button btnCheck;
        private Button btnNewGame;
    }
}