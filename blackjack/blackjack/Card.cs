using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public enum Suit { 
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    public class Card
    {
        
        public Suit suit { get; set; }
        public int value { get; set; }
        public Image image { get; set; }
        public Image flippedImage { get; set; }

        public Card(Suit suit, int value, Image image) {
            this.suit = suit;
            this.value = value;
            this.image = image;
        }
        
        public string getValueAsString() {
            switch (value) { 
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return this.value.ToString();
            }
        }


        public override string ToString()
        {
            return String.Format("{0} of {1}", getValueAsString(), suit);
        }
    }
}
