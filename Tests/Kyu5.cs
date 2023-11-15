using Newtonsoft.Json.Bson;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeWars.Kyu5.CountIpAddresses;
using static CodeWars.Kyu5.MovingZerosToTheEnd;
using static CodeWars.Kyu5.AlphabetWarsNuclearStrike;

namespace Tests
{
    [TestFixture]
    public class Kyu5
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void CountIpAddressesTests()
        {
            Assert.AreEqual(50L, IpsBetween("10.0.0.0", "10.0.0.50"));
            Assert.AreEqual(246L, IpsBetween("20.0.0.10", "20.0.1.0"));
            Assert.AreEqual(1L, IpsBetween("150.0.0.0", "150.0.0.1"));
            Assert.AreEqual(50, IpsBetween("10.0.0.0", "10.0.0.50"));
            Assert.AreEqual(246, IpsBetween("20.0.0.10", "20.0.1.0"));
            Assert.AreEqual(243, IpsBetween("10.11.12.13", "10.11.13.0"));
            Assert.AreEqual(256, IpsBetween("160.0.0.0", "160.0.1.0"));
            Assert.AreEqual(65536, IpsBetween("170.0.0.0", "170.1.0.0"));
            Assert.AreEqual(65793, IpsBetween("50.0.0.0", "50.1.1.1"));
            Assert.AreEqual(16777216, IpsBetween("180.0.0.0", "181.0.0.0"));
            Assert.AreEqual(67372036, IpsBetween("1.2.3.4", "5.6.7.8"));
            Assert.AreEqual((1L << 32) - 1L, IpsBetween("0.0.0.0", "255.255.255.255"));

            int numberOfRandomTests = 1000;
            Console.WriteLine($"Random tests ({numberOfRandomTests}):\n\n");

            for (int i = 0; i < numberOfRandomTests; i++)
            {
                Random random = new(BitConverter.ToInt32(Guid.NewGuid().ToByteArray()));

                var a = (long)(random.NextDouble() * (256L * 256L * 256L * 256L - 1));
                var b = (long)(random.NextDouble() * (256L * 256L * 256L)) + 1;
                var c = Math.Min(a + b, 256L * 256L * 256L * 256L - 1);
                var ip1 = IntToIp(a);
                var ip2 = IntToIp(c);
                Console.WriteLine($"IP1: {ip1}, IP2: {ip2}");
                Assert.AreEqual(c - a, IpsBetween(ip1, ip2));
            }
        }

        private static string IntToIp(long ipInt)
        {
            var sb = new StringBuilder();
            sb.Append((ipInt >> 24) & 0xFF).Append('.');
            sb.Append((ipInt >> 16) & 0xFF).Append('.');
            sb.Append((ipInt >> 8) & 0xFF).Append('.');
            sb.Append(ipInt & 0xFF);
            return sb.ToString();
        }

        [Test]
        public void MovingZerosToTheEndTests()
        {
            Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }

        [Test]
        public void AlphabetWarTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(AlphabetWar("abde[fgh]ijk"), Is.EqualTo("abdefghijk"));
                Assert.That(AlphabetWar("ab#de[fgh]ijk"), Is.EqualTo("fgh"));
                Assert.That(AlphabetWar("#[a]#[b]#"), Is.EqualTo(""));
                Assert.That(AlphabetWar("[a]##[b]"), Is.EqualTo(""));
                Assert.That(AlphabetWar("[a]a[b]"), Is.EqualTo("aab"));
                Assert.That(AlphabetWar("ab#de[fgh]ij#k"), Is.EqualTo(""));
                Assert.That(AlphabetWar("##abde[fgh]ijk"), Is.EqualTo(""));
                Assert.That(AlphabetWar("##abde[fgh]"), Is.EqualTo(""));
                Assert.That(AlphabetWar("abde[fgh]"), Is.EqualTo("abdefgh"));
                Assert.That(AlphabetWar("##abde[fgh]ijk[mn]op"), Is.EqualTo("mn"));
                Assert.That(AlphabetWar("#abde[fgh]i#jk[mn]op"), Is.EqualTo("mn"));
                Assert.That(AlphabetWar("[ab]adfd[dd]##[abe]dedf[ijk]d#d[h]#"), Is.EqualTo("abijk"));
            });
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
