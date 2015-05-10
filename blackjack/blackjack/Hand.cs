using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class Hand
    {
        private List<Card> hand = new List<Card>();

        public Hand()
        {

        }

        public void Clear()
        {
            hand.Clear();
        }

        public Card getCard(int position)
        {
            if (position >= 0 && position < hand.Count)
            {
                return (Card)hand.ElementAt(position);
            }
            return null;
        }

        public void addCard(Card card)
        {
            if (card != null)
            {
                hand.Add(card);
            }
        }

        public void removeCard(Card card)
        {
            hand.Remove(card);
        }

        public void removeCard(int position)
        {
            if (position >= 0 && position < hand.Count)
            {
                hand.RemoveAt(position);
            }
        }

        public int getCardCount()
        {
            return hand.Count;
        }

        public int getValue()
        {
            int value;
            bool ace;
            int cards;

            value = 0;
            ace = false;
            cards = getCardCount();

            for (int i = 0; i < cards; i++)
            {
                Card card = getCard(i);
                int cardVal = Math.Min(card.value, 10);

                if (cardVal == 1)
                {
                    ace = true;
                }

                value = value + cardVal;
            }

            if (ace == true && value + 10 <= 21)
            {
                value = value + 10;
            }

            return value;
        }

        public String toString()
        {
            return "Hand is " + hand + ", value is " + getValue();
        }
    }
}
