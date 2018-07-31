using System;
using Xunit;
using static MergeSort.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] numbers = { 5, 20, -25, 12, 0, 22, 125, -125 };
            MergeSortRecursive(numbers, 0, numbers.Length-1);
            Assert.Equal(-125, numbers[0]);
            Assert.Equal(125, numbers[7]);
        }
        [Fact]
        public void Test2()
        {
            int[] numbers = { 62, 34, 10, -1265, 25, 64, 19 };
            MergeSortRecursive(numbers, 0, numbers.Length - 1);
            Assert.Equal(-1265, numbers[0]);
            Assert.Equal(64, numbers[6]);
        }
        [Fact]
        public void Test3()
        {
            int[] numbers = { 1326, 612613, 7574, 125, 1261, 3764};
            MergeSortRecursive(numbers, 0, numbers.Length - 1);
            Assert.Equal(125, numbers[0]);
            Assert.Equal(612613, numbers[5]);
        }
    }
}
