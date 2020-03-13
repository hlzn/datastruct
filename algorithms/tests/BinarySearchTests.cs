using NUnit.Framework;
using linearSearch;

namespace tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearch_SortedInput_ReturnsCorrectIndex()
        {
            int[] input = { 0, 3, 4, 7, 8, 12, 15, 22 };

            Assert.AreEqual(2, BinarySearch.IterativeBinarySearch(input,4));
            Assert.AreEqual(4, BinarySearch.IterativeBinarySearch(input,8));
            Assert.AreEqual(6, BinarySearch.IterativeBinarySearch(input,15));
            Assert.AreEqual(7, BinarySearch.IterativeBinarySearch(input,22));

            Assert.AreEqual(2, BinarySearch.RecursiveBinarySearch(input,4));
            Assert.AreEqual(4, BinarySearch.RecursiveBinarySearch(input,8));
            Assert.AreEqual(6, BinarySearch.RecursiveBinarySearch(input,15));
            Assert.AreEqual(7, BinarySearch.RecursiveBinarySearch(input,22));
        }
        
    }
}