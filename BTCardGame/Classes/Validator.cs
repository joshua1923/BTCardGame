using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCardGame.Classes
{
    public class Validator
    {
        public static bool Containsjokers(string[] listOfCards)
        {
            return Array.Exists(listOfCards, index => index == "JR");
            
        }

        public static bool JokerCount(string[] listOfCards)
        {
            int jokerCount = 0;

            foreach (var card in listOfCards)
            {
                if (card == "JR") jokerCount++;
            }

            if (jokerCount > 2) return false;

            return true;
        }

        public static bool DuplicateCount(string[] listOfCards)
        {
            return listOfCards.Distinct().Count() != listOfCards.Length;
        }
    }
}
