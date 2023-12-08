using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_War
{
    internal class Class1
    {
        public class Card
        {
            public String suit { get; set; }
            public String rank { get; set; }
            public int value { get; set; }


            public Card(String suit, String rank, int value)
            {
                this.suit = suit;
                this.rank = rank;
                this.value = value;
            }
        }
        public class Player
        {
            public String name { get; set; }
            public int hand { get; set; }
            public int score { get; set; }

            Player(String name, int hand, int score)
            {
                this.name = name;
                this.hand = hand;
                this.score = score;
            }
        }
        public class Deck
        {

            private List<Card> cards;
            private List<Card> GenerateDeck { get; set; }


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
            }

            public Deck()
            {
                cards = GenerateDeck = new List<Card>();
                Shuffle();

                List<Card> newDeck = new List<Card>();


                String[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
                String[] ranks = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
                int[] value = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
                for (int i = 0; i < suits.Length; i++)
                {
                    for (int j = 0; j < ranks.Length; j++)
                    {
                        newDeck.Add(new Card(suits[i], ranks[j], value[j]));
                    }
                }




            }
        }
    }
}