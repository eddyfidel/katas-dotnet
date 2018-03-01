using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class HumanReadableTimeKataTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(HumanReadableTimeKata.GetReadableTime(0), "00:00:00");
            Assert.AreEqual(HumanReadableTimeKata.GetReadableTime(5), "00:00:05");
            Assert.AreEqual(HumanReadableTimeKata.GetReadableTime(60), "00:01:00");
            Assert.AreEqual(HumanReadableTimeKata.GetReadableTime(86399), "23:59:59");
            Assert.AreEqual(HumanReadableTimeKata.GetReadableTime(359999), "99:59:59");
        }
    }
}
