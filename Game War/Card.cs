using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_War
{
    public class Card
    {
        public String suit { get; set; }
        public String rank { get; set; }
        public int value { get; set; }

        public String CardName
        {
            get
            {
                return rank + " of " + suit;
            }
            set { suit = value; }
        }


        public Card(String suit, String rank, int value)
        {
            this.suit = suit;
            this.rank = rank;
            this.value = value;
        }
    }
}
