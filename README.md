# Blackjack
<br>
Решавање на проблемот:
За имплементација на играта употребивме 3 помошни класи. Најпрво класа Card која се однесува на картата за играње и чува информации за:
-	Форма (лист, баклава, детелина, срце) (enum)
-	Вредност (int)
-	Слика (Image)
-	Превртена слика (Image)
и изгледа вака:

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

Класата Deck претставува шпил од карти и чува листа објекти од класата Card. Во оваа класа дефинираме 52 карти секоја со уникатна форма, вредност и слика. Тука чуваме и метод shuffle() кој ги меша картите, и изгледа вака: 


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

  






