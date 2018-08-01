using System;
using Xunit;
using QuickSort;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] a = new int[] { 5, 12, 51, 72, 23, 53, 11, 23, 621, 14, -25, 100, 66, 1, 2, 3,};
            Program.QuickSort(a, 0, a.Length - 1);
            Assert.Equal(-25, a[0]);
            Assert.Equal( 23, a[9]);
            Assert.Equal(621, a[a.Length - 1]);
        }
        [Fact]
        public void Test2()
        {
            int[] a = new int[] { 7, 6, 12, 77, 13};
            Program.QuickSort(a, 0, a.Length - 1);
            Assert.Equal(6, a[0]);
            Assert.Equal(12, a[2]);
            Assert.Equal(77, a[a.Length - 1]);
        }
        [Fact]
        public void Test3()
        {
            int[] a = new int[] { 77, 243, 12, 63, 79};
            Program.QuickSort(a, 0, a.Length - 1);
            Assert.Equal(12, a[0]);
            Assert.Equal(79, a[3]);
            Assert.Equal(243, a[a.Length - 1]);
        }
    }
}
