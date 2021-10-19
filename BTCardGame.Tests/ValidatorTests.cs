using BTCardGame.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCardGame.Tests
{
    [TestFixture]
    internal class ValidatorTests
    {
        [TestCase(new string[] { "2C", "JR" }, true)]
        [Test]
        public static void JokerCount_WithInvalidList_ReturnsTrue(string[] listOfCards, bool expected)
        {
            var result = Validator.JokerCount(listOfCards);

            Assert.AreEqual(result, expected);
        }

        [TestCase(new string[] { "JR", "JR", "JR" }, false)]
        [Test]
        public static void JokerCount_WithValidList_ReturnsFalse(string[] listOfCards, bool expected)
        {
            var result = Validator.JokerCount(listOfCards);

            Assert.AreEqual(result, expected);
        }

        [TestCase(new string[] { "3C", "JR" }, true)]
        [Test]
        public static void ContainsJokers_WithValidList_ReturnsTrue(string[] listOfCards, bool expected)
        {
            var result = Validator.Containsjokers(listOfCards);

            Assert.AreEqual(result, expected);
        }

        [TestCase(new string[] { "3C", "4C" }, false)]
        [Test]
        public static void ContainsJokers_WithValidList_ReturnsFalse(string[] listOfCards, bool expected)
        {
            var result = Validator.Containsjokers(listOfCards);

            Assert.AreEqual(result, expected);
        }

        [TestCase(new string[] { "3C", "3C" }, true)]
        [Test]
        public static void DuplicateCount_WithInvalidList_ReturnsTrue(string[] listOfCards, bool expected)
        {
            var result = Validator.DuplicateCount(listOfCards);

            Assert.AreEqual(result, expected);
        }

        [TestCase(new string[] { "3C", "3H" }, false)]
        [Test]
        public static void DuplicateCount_WithValidList_ReturnsFalse(string[] listOfCards, bool expected)
        {
            var result = Validator.DuplicateCount(listOfCards);

            Assert.AreEqual(result, expected);
        }
    }
}
