﻿using System.Collections.Generic;
using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class RemoveSmallestKataTests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(1, 1);

            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
            Tester(new List<int>(), new List<int>());
        }

        private static void Tester(List<int> argument, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, RemoveSmallestKata.RemoveSmallest(argument));
        }
    }
}
