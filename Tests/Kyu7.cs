using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using static CodeWars.Kyu7.BoiledEggs;
using static CodeWars.Kyu7.ListFiltering;
using static CodeWars.Kyu7.Isograms;
using static CodeWars.Kyu7.ExesAndOhs;
using static CodeWars.Kyu7.JadenCaseStrings;
using static CodeWars.Kyu7.SumOfTwoLowestPositiveIntegers;
using static CodeWars.Kyu7.FriendOrFoe_;
using static CodeWars.Kyu7.PrinterErrors;
using static CodeWars.Kyu7.ReverseLetters;
using static CodeWars.Kyu7.DistinctDigitYear_;
using static CodeWars.Kyu7.OnesAndZeros;
using static CodeWars.Kyu7.CompareStringsToSumOfChars;
using static CodeWars.Kyu7.CommonSubstrings;
using static CodeWars.Kyu7.FirstReverseTry_;
using static CodeWars.Kyu7.SillyCase_;
using System.Reflection;

namespace Tests
{
    [TestFixture]
    public class Kyu7
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void BoiledEggsTest()
        {
            Assert.AreEqual(0, CookingTime(0), "0 eggs");
            Assert.AreEqual(5, CookingTime(5), "5 eggs");
            Assert.AreEqual(10, CookingTime(10), "10 eggs");
        }

        [Test]
        public void ListFilteringTest()
        {
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            var actual = GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));

            list = new List<object>() { 1, "a", "b", 0, 15 };
            expected = new List<int>() { 1, 0, 15 };
            actual = GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));

            list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            expected = new List<int>() { 1, 2, 123 };
            actual = GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));

            list = new List<object>() { "a", "b", "1" };
            expected = new List<int>();
            actual = GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));

            list = new List<object>() { 1, 2, "a", "b" };
            expected = new List<int>() { 1, 2 };
            actual = GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [Test]
        public void IsogramTests()
        {
            Assert.Multiple(() =>
            {
                Assert.That(IsIsogram("Dermatoglyphics"), Is.True);
                Assert.That(IsIsogram("isogram"), Is.True);
                Assert.That(IsIsogram("moose"), Is.False);
                Assert.That(IsIsogram("moOse"), Is.False);
                Assert.That(IsIsogram("aba"), Is.False);
                Assert.That(IsIsogram("isIsogram"), Is.False);
                Assert.That(IsIsogram("thumbscrewjapingly"), Is.True);
                Assert.That(IsIsogram(""), Is.True);
            });
        }

        [Test]
        public void ExesAndOhsTests()
        {
            Assert.AreEqual(true, XO("xo"));
            Assert.AreEqual(true, XO("XO"));
            Assert.AreEqual(true, XO("xo0"));
            Assert.AreEqual(false, XO("xxxoo"));
            Assert.AreEqual(true, XO("xxOo"));
            Assert.AreEqual(true, XO(""), "Empty string contains equal amount of x and o");
            Assert.AreEqual(true, XO("xxxxxoooxooo"));
            Assert.AreEqual(false, XO("xxxm"));
            Assert.AreEqual(false, XO("ooom"));
            Assert.AreEqual(false, XO("Oo"));
            Assert.AreEqual(true, XO("abcdefghijklmnopqrstuvwxyz"), "Alphabet contains equal amount of x and o");
        }

        [Test]
        public void JadenCaseTests()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real", "How can mirrors be real if our eyes aren't real".ToJadenCase(), "Strings didn't match.");
            Assert.AreEqual("Most Trees Are Blue", "most trees are blue".ToJadenCase());
            Assert.AreEqual("", "".ToJadenCase());
            Assert.AreEqual("All The Rules In This World Were Made By Someone No Smarter Than You. So Make Your Own.", "All the rules in this world were made by someone no smarter than you. So make your own.".ToJadenCase());
            Assert.AreEqual("School Is The Tool To Brainwash The Youth.", "School is the tool to brainwash the youth.".ToJadenCase());
            Assert.AreEqual("If Newborn Babies Could Speak They Would Be The Most Intelligent Beings On Planet Earth.", "If newborn babies could speak they would be the most intelligent beings on planet Earth.".ToJadenCase());
            Assert.AreEqual("If Everybody In The World Dropped Out Of School We Would Have A Much More Intelligent Society.", "If everybody in the world dropped out of school we would have a much more intelligent society.".ToJadenCase());
        }

        [Test]
        public void SumOfTwoLowestPositiveIntegersTests()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, SumTwoSmallestNumbers(numbers));

            numbers = new int[] { 19, 5, 42, 2, 77 };
            Assert.AreEqual(7, SumTwoSmallestNumbers(numbers));

            numbers = new int[] { 10, 343445353, 3453445, 2147483647};
            Assert.AreEqual(3453455, SumTwoSmallestNumbers(numbers));

            for (int run = 0; run < 100; ++run)
            {
                Random rnd = new(BitConverter.ToInt32(Guid.NewGuid().ToByteArray()));

                numbers = new int[rnd.Next(4, 100)];
                int min1 = Int32.MaxValue;
                int min2 = Int32.MaxValue;
                for (int i = 0; i < numbers.Length; ++i)
                {
                    int n = rnd.Next(1, 1000000);
                    if (n < min1) { min2 = min1; min1 = n; }
                    else if (n < min2) min2 = n;
                    numbers[i] = n;
                }
                uint expected = (uint)min1 + (uint)min2;
                int actual = SumTwoSmallestNumbers(numbers);
                Assert.AreEqual(expected, actual, "Lowest numbers are " + min1 + " and " + min2);
            }
        }

        [Test]
        public void FriendOrFoeTests()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, FriendOrFoe(names));
        }

        [Test]
        public void PrinterErrorTests()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", PrinterError(s));
            s = "kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("6/60", PrinterError(s));
            s = "kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyzuuuuu";
            Assert.AreEqual("11/65", PrinterError(s));
        }

        [Test]
        public void BasicReverseLetterTests()
        {
            Assert.AreEqual("nahsirk", ReverseLetter("krishan"));
            Assert.AreEqual("nortlu", ReverseLetter("ultr53o?n"));
            Assert.AreEqual("cba", ReverseLetter("ab23c"));
            Assert.AreEqual("nahsirk", ReverseLetter("krish21an"));
            Assert.AreEqual("oOfraBooF", ReverseLetter("FooBar64453fOo"));
        }

        [Test]
        public void BasicDistinctDigitYearTests()
        {
            Assert.AreEqual(2013, DistinctDigitYear(1987));
            Assert.AreEqual(2014, DistinctDigitYear(2013));
        }

        [Test]
        public void BasicOnesAndZerosTesting()
        {
            Assert.AreEqual(0, BinaryArrayToNumber(new int[] { 0, 0, 0, 0 }));
            Assert.AreEqual(15, BinaryArrayToNumber(new int[] { 1, 1, 1, 1 }));
            Assert.AreEqual(6, BinaryArrayToNumber(new int[] { 0, 1, 1, 0 }));
            Assert.AreEqual(5, BinaryArrayToNumber(new int[] { 0, 1, 0, 1 }));
        }

        [Test]
        public void CompareStringsToSumOfCharsTests()
        {
            Assert.AreEqual(true, Compare("AD", "BC"));
            Assert.AreEqual(false, Compare("AD", "DD"));
            Assert.AreEqual(true, Compare("zz1", ""));
        }

        [Test]
        public void SubstringTests()
        {
            Assert.AreEqual(true, SubstringTest("Something", "Home"));
            Assert.AreEqual(false, SubstringTest("Something", "Fun"));
            Assert.AreEqual(true, SubstringTest("pflfUOCUbyqbSGcgDSBpFHgVsSNpFePIydUpesKnPc", "HVEzcOdFMiHWpCtGZLCJXRfZmzxmHAHQJCQOLXNQYK"));
            Assert.AreEqual(true, SubstringTest("fGFCwpCoAicZBslvpGJBshB", "NdPGekLZVgtaXWluNxXsOEy"));
            Assert.AreEqual(true, SubstringTest("rfWLuKnxMHXAcozdcJyMVWwOZRvLbIHqvu", "kgfSfjauOnqJYuneouCrCIrBDTSGEdUJKJ"));
        }

        [Test]
        public void FirstReverseTryTests()
        {
            Assert.AreEqual(new int[] { 5, 2, 3, 4, 1 }, FirstReverseTry(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { }, FirstReverseTry(new int[] { }));
            Assert.AreEqual(new int[] { 111 }, FirstReverseTry(new int[] { 111 }));
            Assert.AreEqual(new int[] { 324, 54, 12, 3, 4, 56, 23, 12, 5, 23 }, FirstReverseTry(new int[] { 23, 54, 12, 3, 4, 56, 23, 12, 5, 324 }));
        }

        [Test]
        public void SillyCaseTests()
        {
            Assert.That(SillyCase("foobar"), Is.EqualTo("fooBAR"));
            Assert.That(SillyCase("codewars"), Is.EqualTo("codeWARS"));
            Assert.That(SillyCase("brian"), Is.EqualTo("briAN"));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
