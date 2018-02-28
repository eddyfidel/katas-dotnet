using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class PlayingWithDigitsKataTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, PlayingWithDigitsKata.DigPow(89, 1));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, PlayingWithDigitsKata.DigPow(92, 1));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(51, PlayingWithDigitsKata.DigPow(46288, 3));
        }
    }
}
