using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Game
{
    private List<int> deck;
    private List<int> playerCards;
    private List<int> dealerCards;
    private Random rand = new Random();
    public bool GameOver { get; private set; }

    public Game()
    {
        NewGame();
    }
    public void NewGame()
    {
        deck = new List<int>();
        for (int suit = 0; suit < 4; suit++)
        {
            for (int val = 2; val <= 10; val++) deck.Add(val);
            deck.Add(10); // J
            deck.Add(10); // Q
            deck.Add(10); // K
            deck.Add(11); // A
        }
        Shuffle();

        playerCards = new List<int>();
        dealerCards = new List<int>();

        playerCards.Add(DrawCard());
        dealerCards.Add(DrawCard());
        playerCards.Add(DrawCard());
        dealerCards.Add(DrawCard());

        GameOver = false;
    }

    private void Shuffle()
    {
        for (int i = deck.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            int temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }
    }

    private int DrawCard()
    {
        if (deck.Count == 0)
        {
            deck = new List<int>();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 2; val <= 10; val++) deck.Add(val);
                deck.Add(10); deck.Add(10); deck.Add(10); deck.Add(11);
            }
            Shuffle();
        }
        int card = deck[0];
        deck.RemoveAt(0);
        return card;
    }
    public int CalculateHand(List<int> cards)
    {
        int sum = cards.Sum();
        int aces = cards.Count(c => c == 11);
        while (sum > 21 && aces > 0)
        {
            sum -= 10;
            aces--;
        }
        return sum;
    }

    public int PlayerSum => CalculateHand(playerCards);
    public int DealerSum => CalculateHand(dealerCards);

    public bool IsPlayerBust => PlayerSum > 21;
    public bool IsDealerBust => DealerSum > 21;
    public void PlayerHit()
    {
        if (GameOver) return;
        playerCards.Add(DrawCard());
        if (IsPlayerBust)
        {
            GameOver = true;
        }
    }
    public void DealerTurn()
    {
        if (GameOver) return;
        while (DealerSum < 17)
        {
            dealerCards.Add(DrawCard());
        }
        GameOver = true;
    }

    public string GetWinner()
    {
        if (!GameOver)
        {
            DealerTurn();
        }

        int playerScore = PlayerSum;
        int dealerScore = DealerSum;

        if (playerScore > 21) return "Дилер выиграл (перебор у игрока)";
        if (dealerScore > 21) return "Игрок выиграл (перебор у дилера)";
        if (playerScore > dealerScore) return "Игрок выиграл";
        if (dealerScore > playerScore) return "Дилер выиграл";
        return "Ничья";
    }

    public List<int> PlayerCards => playerCards;
    public List<int> DealerCards => dealerCards;
}
