using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class EqualSidesOfAnArrayKataTests
    {
        [Test]
        public void Test1() 
        {
            Assert.AreEqual(3, EqualSidesOfAnArrayKata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, EqualSidesOfAnArrayKata.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, EqualSidesOfAnArrayKata.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, EqualSidesOfAnArrayKata.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}
