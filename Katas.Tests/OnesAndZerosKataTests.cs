using NUnit.Framework;

namespace Katas.Tests
{   
    [TestFixture]
    public class OnesAndZerosKataTests
    {
        int[] array1 = new int[] { 0, 0, 0, 0 };
        int[] array2 = new int[] { 1, 1, 1, 1 };
        int[] array3 = new int[] { 0, 1, 1, 0 };
        int[] array4 = new int[] { 0, 1, 0, 1 };

        [Test]
        public void Test1() 
        {
            Assert.AreEqual(0, OnesAndZerosKata.BinaryArrayToNumber(array1));
            Assert.AreEqual(15, OnesAndZerosKata.BinaryArrayToNumber(array2));
            Assert.AreEqual(6, OnesAndZerosKata.BinaryArrayToNumber(array3));
            Assert.AreEqual(5, OnesAndZerosKata.BinaryArrayToNumber(array4));
        }
    }
}
