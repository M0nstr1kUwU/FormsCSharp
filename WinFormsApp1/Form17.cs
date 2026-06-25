using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form17 : Form
    {
        private Game game;
        public Form17()
        {
            InitializeComponent();
            game = new Game();
            UpdateUI();
        }

        private void UpdateUI()
        {
            string playerCardsStr = string.Join(", ", game.PlayerCards);
            lblPlayerCards.Text = $"Ваши карты: {playerCardsStr} (сумма: {game.PlayerSum})";

            if (!game.GameOver)
            {
                if (game.DealerCards.Count >= 1)
                {
                    string dealerHidden = $"{game.DealerCards[0]}, ?";
                    lblDealerCards.Text = $"Карты дилера: {dealerHidden}";
                }
            }
            else
            {
                string dealerCardsStr = string.Join(", ", game.DealerCards);
                lblDealerCards.Text = $"Карты дилера: {dealerCardsStr} (сумма: {game.DealerSum})";
            }

            btnAddCard.Enabled = !game.GameOver && game.PlayerSum <= 21;
            btnCheck.Enabled = !game.GameOver;

            if (game.GameOver)
            {
                lblResult.Text = game.GetWinner();
            }
            else
            {
                lblResult.Text = "";
            }
        }

        private void btnAddCard_Click_1(object sender, EventArgs e)
        {
            game.PlayerHit();
            UpdateUI();
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            game.DealerTurn();
            UpdateUI();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            game.NewGame();
            UpdateUI();
        }
    }
}
