using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_War
{
    public class Deck
    {

        public List<Card> cards;
        public List<Card> GeneratedDeck { get; set; }


        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            GeneratedDeck = cards;
        }

        public Deck()
        {
            cards = GeneratedDeck = new List<Card>();
            

            List<Card> newDeck = new List<Card>();


            String[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            String[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] value = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    newDeck.Add(new Card(suits[i], ranks[j], value[j]));
                }
            }
            GeneratedDeck = newDeck;
            cards = GeneratedDeck;
            Shuffle();
        }
    }
}
