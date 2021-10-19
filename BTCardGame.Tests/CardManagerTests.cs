using BTCardGame.Classes;
using NUnit.Framework;

namespace BTCardGame.Tests
{
    [TestFixture]
    public class CardManagerTests
    {
        [TestCase(new string[] { "AC" }, 14)]
        [TestCase(new string[] { "JC" }, 11)]
        [TestCase(new string[] { "QC" }, 12)]
        [TestCase(new string[] { "KC" }, 13)]
        [TestCase(new string[] { "3C", "4C" }, 7)]
        [TestCase(new string[] { "JR", "2C", "JR" }, 8)]
        [TestCase(new string[] { "2C", "JR" }, 4)]
        [TestCase(new string[] { "TC", "TD", "TH", "TS" }, 100)]
        [Test]
        public static void Calculate_WithValidList_Returns100(string[] listOfCards, int expected)
        {
            var result = CardManager.CardCalculator(listOfCards);
            
            Assert.AreEqual(result, expected);
        }
    }
}