using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class DirectionsReductionKataTests
    {
        [Test]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            Assert.AreEqual(b, DirectionsReductionKata.DirReduc(a));
        }

        [Test]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Assert.AreEqual(b, DirectionsReductionKata.DirReduc(a));
        }
    }
}
