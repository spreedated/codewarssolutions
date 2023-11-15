using NUnit.Framework;
using static CodeWars.Kyu6.CreatePhoneNumber_;
using static CodeWars.Kyu6.PersistentBugger;

namespace Tests
{
    [TestFixture]
    public class Kyu6
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void PersistentBuggerTests()
        {
            Assert.AreEqual(3, Persistence(39));
            Assert.AreEqual(0, Persistence(4));
            Assert.AreEqual(2, Persistence(25));
            Assert.AreEqual(4, Persistence(999));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public string CreatePhoneNumberTests(int[] numbers)
        {
            return CreatePhoneNumber(numbers);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
