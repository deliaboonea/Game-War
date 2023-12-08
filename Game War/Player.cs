using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_War
{
    public class Player
    {
        public String name { get; set; }
        
        public int Score {  get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();

        public Card CurrentCard { get; set; }

        //Returneaza cate o carte la rand din pachet (ca si cum ai lua din pachet urmatoarea)
        public CardEnumerator GetEnumerator()
        {
            return new CardEnumerator(this);
        }


        public Player(String name)
        {
            this.name = name;
            Score = 0;
        }
    }
}
