using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_War
{
    public class CardEnumerator
    {
        private readonly Player _player;
        private int _currentIndex;

        public CardEnumerator(Player player)
        {
            _player = player;
            _currentIndex = -1;
        }

        public Card Next()
        {
            _currentIndex++;
            if (_currentIndex < _player.Cards.Count)
            {
                return _player.CurrentCard = _player.Cards[_currentIndex];
            }
            else
            {
                return null; // Or however you want to handle the end of the collection
            }
        }

        public bool HasNext()
        {
            if( _currentIndex + 1 < _player.Cards.Count)
            {
                return true;
            }
            return false;
        }
    }
}
