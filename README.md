Blackjack или уште позната како дваесет и еден, е најиграна игра со карти ширум светот. Претставува игра на споредба на карти помеѓу играч и дилер (противник), каде играчите се натпреваруваат со противникот, но не и помеѓу себе. Се игра со еден, или повеќе, шпила на карти.
Целта е да се победи противникот, на еден од повеќето начини:
-	Со добивање на 21 поен од доделените две карти (уште наречено и blackjack), без, притоа, противникот да има blackjack;
-	Со постигнување на финален резултат кој е повисок од оној на противникот без да надмине 21, или;
-	Да се дозволи на противникот да влече дополнителни карти и притоа да надмине 21 поен.

На играчот му се дели иницијална рака со две карти чии вредности се додаваат. Кралот, Дамата и Џандарот имаат вредност 10 поени. Играчот или противникот можат да одлучат во броењето на кецот и тоа како 1 поен или 11 поени. Сите останати карти се бројат во зависност од нивната бројка. По добивањето на иницијалните карти, играчот може да одлучи дали ќе повика “hit” односно да добие уште една карта. Во секоја рунда, играчот или непријателот победува со 21 поен или со поседување на рака со најголема вредност, помала од 21. Поседување на рака со повеќе од 21 поен се нарекува “busting” и предизвикува губење на партијата. Играчот може да победи со поседување на финална вредност на рака до 21 и помалку доколку непријателот не го задоволува тој услов. Ако играчот поседува кец со вредност 11, таквата рака се нарекува “мека”, што значи дека играчот нема да надмине 21 со извлекување на било каква дополнителна карта. Поинаку, раката се нарекува “крута”. Играчот во секој момент може да ја предаде предноста на непријателот со одлука за чекање, “stand”.
Непријателот може да извлекува карти се додека вредноста на неговара рака нема 17 или повеќе поени. Непријателот губи доколку има рака со вредност помала од играчот или не го задоволува условот (вредност на рака поголема од 21). Доколку и играчот и непријателот имаат рака со иста вредност, играчот губи.


#Решавање на проблемот:
За имплементација на изгледот на апликација користиме 3 форми. Почетната е менито и изгледа вака:

<img src="http://i.imgur.com/BCYos3L.png" />

Со притискање на копчето Exit, излегувате од апликацијата, со копчето Help добивате кратка документација околу правилата на играта, додека со притискање на копчето play now влегувате во глафната форма каде што можете да ја играте.

<b>Help форма</b>
По притиснувањето на копчето ''HELP" го добивате правилникот за играње на оваа игра каде е објаснето што значат копчињата ''HIT'' и ''STAND'', како да направите влог со кој ќе почнете да играте и притоа ќе дознаете како се игра оваа игра. Можете да дознаете како да добиете "Blackjack"и како можете да изгубите. Добро е секој пред да игра да го види овој дел поготово тие кој прв пат се среќаваат со "Black Jack" и не се добро запознаени со правилата.
 



Главна форма:
Ова е изгледот на главната форма каде што ја играте играта. Во горниот лев агол е прикажан вашиот кредит, додека под него се прикажани раката на противникот (дилерот) и вашата рака. Во горниот десен агол се наоѓаат две копчиња од кои првото е за регулирање на позадинската музика (вклучена/исклучена) а второто за враќање назад во менито. Под нив се наоѓа слика од девојка која не не интересира и нема никаква функционалност. Во долниот дел од формата се поставени 3 чипови, и со притискање на некој од нив регулираме вредност за влог, десно од него е копчето deal со кое ја вложуваме вредноста а над нив се наоѓаат копчињата hit и stand кои се објаснати во правилниктот на играта.
 

За имплементација на логиката употребивме 3 помошни класи. Најпрво класа Card која се однесува на картата за играње и чува информации за:
-	Форма (лист, баклава, детелина, срце) (enum)
-	Вредност (int)
-	Слика (Image)
-	Превртена слика (Image)
и изгледа вака:


```c#
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
```





Класата Deck претставува шпил од карти и чува листа објекти од класата Card. Во оваа класа дефинираме 52 карти секоја со уникатна форма, вредност и слика. Тука чуваме и метод shuffle() кој ги меша картите, и изгледа вака: 

```c#
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
}
```

Класата Hand се користи за претставување на рака од карти. За таа цел, во себе чува податочен тип листа од карти. Методите декларирани за работа со оваа класа се со цел манипулација на листата од карти како добивање на карта,  додавање на карта, отстраување на карта, добивање на вредност на рака, и уништување на раката.

```c#
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
```

Главната логика на играта е имплементирана според горенаведените правила и се наоѓа во позадинскиот код на формата за играње.


Изработено од: 

Томи Томоски 1120951
Младен Коруноски 141032
Стефан Стевановски 112086
