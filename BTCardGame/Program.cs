using BTCardGame.Classes;
using ConsoleTables;
using System;
using System.Linq;

namespace BTCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter a list of cards or type 'exit' to end the application:");

                string input = Console.ReadLine();

                if (input == "exit")
                {
                    exit = true;
                    continue;
                };

                string[] cards = CardStringHelper.SplitCardList(input);

                int finalSum = CardManager.CardCalculator(cards);

                var table = new ConsoleTable("Cards", "Value");
                table.AddRow(input, finalSum);

                Console.WriteLine(table);
            }  
        }
    }
}
