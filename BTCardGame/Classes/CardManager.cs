using System;

namespace BTCardGame.Classes
{
    public class CardManager
    {
        public static int CardCalculator(string[] listOfCards)
        {
            int finalSum = 0;
            int jokersPresent = 0;

            foreach (string card in listOfCards)
            {
                if (card == "JR")
                {
                    jokersPresent++;
                    continue;
                }
                var cardValue = card[..1];

                int cardNumber = cardValue switch
                {
                    "T" => (int)CardValue.T,
                    "J" => (int)CardValue.J,
                    "Q" => (int)CardValue.Q,
                    "K" => (int)(CardValue.K),
                    "A" => (int)(CardValue.A),
                    _ => int.Parse(cardValue),
                };

                string suit = card[1..];
                var multiply = (int)Enum.Parse(typeof(Suit), suit, true);

                finalSum += cardNumber * multiply;
            }

            switch (jokersPresent)
            {
                case 1: finalSum *= 2;
                    break;
                case 2: finalSum *= 4;
                    break;
                default:
                    break;
            }
            
            return finalSum;
        }
    }
}
