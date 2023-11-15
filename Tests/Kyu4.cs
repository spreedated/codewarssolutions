using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Collections;
using static Solutions.Kyu4.StripComments_;
using static Solutions.Kyu4.SumOfIntervals;
using static Solutions.Kyu4.BreadcrumbGenerator;
using Solutions.Kyu4;
using System;

namespace Tests
{
    [TestFixture]
    public class Kyu4
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void StripCommentsTests()
        {
            Assert.AreEqual("apples, pears\ngrapes\nbananas", StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
            Assert.AreEqual("a\nc\nd", StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));
        }

        [Test]
        public void SumOfIntervalsTests()
        {
            Assert.AreEqual(0, SumIntervals(new SumOfIntervals.Interval[] { }));
            Assert.AreEqual(0, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(4, 4),new SumOfIntervals.Interval(6, 6),new SumOfIntervals.Interval(8, 8) }));

            Assert.AreEqual(9, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(1, 2),new SumOfIntervals.Interval(6, 10),new SumOfIntervals.Interval(11, 15) }));
            Assert.AreEqual(11, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(4, 8),new SumOfIntervals.Interval(9, 10),new SumOfIntervals.Interval(15, 21) }));
            Assert.AreEqual(7, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(-1, 4),new SumOfIntervals.Interval(-5, -3) }));
            Assert.AreEqual(78, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(-245, -218),new SumOfIntervals.Interval(-194, -179),new SumOfIntervals.Interval(-155, -119) }));

            Assert.AreEqual(54, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(1, 2),new SumOfIntervals.Interval(2, 6),new SumOfIntervals.Interval(6, 55) }));
            Assert.AreEqual(23, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(-2, -1),new SumOfIntervals.Interval(-1, 0),new SumOfIntervals.Interval(0, 21) }));

            Assert.AreEqual(7, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(1, 4),new SumOfIntervals.Interval(7, 10),new SumOfIntervals.Interval(3, 5) }));
            Assert.AreEqual(6, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(5, 8),new SumOfIntervals.Interval(3, 6),new SumOfIntervals.Interval(1, 2) }));
            Assert.AreEqual(19, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(1, 5),new SumOfIntervals.Interval(10, 20),new SumOfIntervals.Interval(1, 6),new SumOfIntervals.Interval(16, 19),new SumOfIntervals.Interval(5, 11) }));

            Assert.AreEqual(13, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(2, 5),new SumOfIntervals.Interval(-1, 2),new SumOfIntervals.Interval(-40, -35),new SumOfIntervals.Interval(6, 8) }));
            Assert.AreEqual(1234, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(-7, 8),new SumOfIntervals.Interval(-2, 10),new SumOfIntervals.Interval(5, 15),new SumOfIntervals.Interval(2000, 3150),new SumOfIntervals.Interval(-5400, -5338) }));
            Assert.AreEqual(158, SumIntervals(new SumOfIntervals.Interval[] {new SumOfIntervals.Interval(-101, 24),new SumOfIntervals.Interval(-35, 27),new SumOfIntervals.Interval(27, 53),new SumOfIntervals.Interval(-105, 20),new SumOfIntervals.Interval(-36, 26) }));

            Assert.AreEqual(2_000_000_000, SumIntervals(new SumOfIntervals.Interval[] { new SumOfIntervals.Interval(-1_000_000_000, 1_000_000_000) }));
            Assert.AreEqual(100_000_030, SumIntervals(new SumOfIntervals.Interval[] { new SumOfIntervals.Interval(0, 20), new SumOfIntervals.Interval(-100_000_000, 10), new SumOfIntervals.Interval(30, 40) }));
        }

        private readonly string[] urls = new string[] {"mysite.com/pictures/holidays.html",
                                          "www.codewars.com/users/GiacomoSorbi?ref=CodeWars",
                                          "www.microsoft.com/docs/index.htm#top",
                                          "mysite.com/very-long-url-to-make-a-silly-yet-meaningful-example/example.asp",
                                          "www.very-long-site_name-to-make-a-silly-yet-meaningful-example.com/users/giacomo-sorbi",
                                          "https://www.linkedin.com/in/giacomosorbi",
                                          "www.agcpartners.co.uk/",
                                          "www.agcpartners.co.uk",
                                          "https://www.agcpartners.co.uk/index.html",
                                          "http://www.agcpartners.co.uk"};

        private readonly string[] seps = new string[] { " : ", " / ", " * ", " > ", " + ", " * ", " * ", " # ", " >>> ", " % " };

        private readonly string[] anss = new string[] {"<a href=\"/\">HOME</a> : <a href=\"/pictures/\">PICTURES</a> : <span class=\"active\">HOLIDAYS</span>",
                                          "<a href=\"/\">HOME</a> / <a href=\"/users/\">USERS</a> / <span class=\"active\">GIACOMOSORBI</span>",
                                          "<a href=\"/\">HOME</a> * <span class=\"active\">DOCS</span>",
                                          "<a href=\"/\">HOME</a> > <a href=\"/very-long-url-to-make-a-silly-yet-meaningful-example/\">VLUMSYME</a> > <span class=\"active\">EXAMPLE</span>",
                                          "<a href=\"/\">HOME</a> + <a href=\"/users/\">USERS</a> + <span class=\"active\">GIACOMO SORBI</span>",
                                          "<a href=\"/\">HOME</a> * <a href=\"/in/\">IN</a> * <span class=\"active\">GIACOMOSORBI</span>",
                                          "<span class=\"active\">HOME</span>",
                                          "<span class=\"active\">HOME</span>",
                                          "<span class=\"active\">HOME</span>",
                                          "<span class=\"active\">HOME</span>"};
        [Test]
        public void BreadcrumbGeneratorTests()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nTest With: {urls[i]}");
                if (i == 5) Console.WriteLine("\nThe one used in the above test was my LinkedIn Profile; if you solved the kata this far and manage to get it, feel free to add me as a contact, message me about the language that you used and I will be glad to endorse you in that skill and possibly many others :)\n\n ");

                Assert.AreEqual(anss[i], GenerateBC(urls[i], seps[i]));
            }

            GenerateBC("google.ca/most-downloaded/or-by-surfer-eurasian/index.html", " - ");
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
