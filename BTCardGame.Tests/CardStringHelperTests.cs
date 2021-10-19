using BTCardGame.Classes;
using NUnit.Framework;

namespace BTCardGame.Tests
{
    [TestFixture]
    internal class CardStringHelperTests
    {
        [TestCase("TC,TD,TH,TS", new string[] { "TC", "TD", "TH", "TS" })]
        [Test]
        public static void Split_WithStringOfCards_ReturnsAListOfCards(string input, string[] expected)
        {
            var result = CardStringHelper.SplitCardList(input);

            Assert.AreEqual(result, expected);
        }
    }
}
