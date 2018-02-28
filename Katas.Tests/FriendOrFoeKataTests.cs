using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class KatasTests
    {
        [Test]
        public void Test1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };

            CollectionAssert.AreEqual(expected, FriendOrFoeKata.FriendOrFoe(names));
        }
    }
}
