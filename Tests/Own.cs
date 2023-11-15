using NUnit.Framework;
using System.Collections.Generic;
using static Solutions.Own.ReadingsOvertime;

namespace Tests
{
    [TestFixture]
    public class Own
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void ReadingsOvertimeTests()
        {
            List<long> readings = new()
            {
                729,
                1038,
                0,
                236,
                759,
                1042,
                1342,
                314,
                1077
            };

            Assert.That(CalculateReadings(readings), Is.EqualTo(3457));

            readings = new()
            {
                729,
                1038,
                0,
                236,
                0,
                1042,
                745,
                311,
                599
            };

            Assert.That(CalculateReadings(readings), Is.EqualTo(3660));

            readings = new()
            {
                0,
                0,
                4,
                0,
                32,
                64,
                128,
                0,
                754,
                614,
                0,
                0,
                127,
                600
            };

            Assert.That(CalculateReadings(readings), Is.EqualTo(2100));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
