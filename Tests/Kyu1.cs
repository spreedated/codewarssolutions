using NUnit.Framework;
using static Solutions.Kyu1.BecomeImmortal;

namespace Tests
{
    [TestFixture]
    public class Kyu1
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void ElderAgeTests()
        {
            //Assert.AreEqual((long)5, ElderAge(8, 5, 1, 100));
            //Assert.AreEqual((long)224, ElderAge(8, 8, 0, 100007));
            //Assert.AreEqual((long)11925, ElderAge(25, 31, 0, 100007));
            //Assert.AreEqual((long)4323, ElderAge(5, 45, 3, 1000007));
            //Assert.AreEqual((long)1586, ElderAge(31, 39, 7, 2345));
            //Assert.AreEqual((long)808451, ElderAge(545, 435, 342, 1000007));
            Assert.AreEqual((long)5456283, ElderAge(28827050410L, 35165045587L, 7109602, 13719506));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
