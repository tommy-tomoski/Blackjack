using blackjack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public class Deck
    {
        public Card[] deck { get; set; }
        public int cardsUsed;
        public Deck() {
            deck = new Card[52];
            Image img;
            int count = 0;
            foreach (Suit suit in Enum.GetValues(typeof(Suit))) {
                for (int value = 1; value <= 13; value++) {
                    if (suit == Suit.Clubs)
                    {
                        img = Image.FromFile(@"Images\c" + value + ".png");
                    }
                    else if (suit == Suit.Diamonds) {
                        img = Image.FromFile(@"Images\d" + value + ".png");
                    }
                    else if (suit == Suit.Hearts)
                    {
                        img = Image.FromFile(@"Images\h" + value + ".png");
                    }
                    else 
                    {
                        img = Image.FromFile(@"Images\d" + value + ".png");
                    }

                    deck[count] = new Card(suit, value, img);
                    
                        count++;
                    }

                }
                cardsUsed = 0;
            }
          
        

        public void shuffle() {
            Random rnd = new Random();
            for (int i = 51; i > 0; i--) {
                int random = rnd.Next(0, 52);
                Card tmp = deck[i];
                deck[i] = deck[random];
                deck[random] = tmp;
            }

            cardsUsed = 0;
        }

        public int cardsLeft() {
            return 52 - cardsUsed;
        }

        public Card dealCard() {
            if (cardsUsed == 52) {
                shuffle();
            }

            return deck[cardsUsed++];
        }

    }
}
