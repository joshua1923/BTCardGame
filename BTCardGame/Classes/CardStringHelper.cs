using System;

namespace BTCardGame.Classes
{
    public class CardStringHelper
    {
        public static string[] SplitCardList(string input)
        {
            string[] listOfCards = input.Split(new char[] { ',' });

            if (!Validator.Containsjokers(listOfCards))
            {
                if (Validator.JokerCount(listOfCards))
                {
                    while (Validator.DuplicateCount(listOfCards))
                    {
                        Console.WriteLine("Duplicate card found, please enter a valid list of cards:");
                        listOfCards = Console.ReadLine().Split(new char[] { ',' });
                    }
                }
                else
                {
                    Console.WriteLine("Too many jokers, please enter a valid list of cards:");
                    listOfCards = Console.ReadLine().Split(new char[] { ',' });
                }
            }

            return listOfCards;
        }
    }
}
