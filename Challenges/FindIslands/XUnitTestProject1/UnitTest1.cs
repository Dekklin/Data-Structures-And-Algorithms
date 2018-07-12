using FindIslands;
using System;
using Xunit;
using static FindIslands.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[,] arr = new int[6, 6]
            { // 1  2  3  4  5  6 
                {0, 1, 0, 0, 0, 0 },
                {1, 0, 1, 0, 0, 0 },
                {0, 1, 0, 0, 0, 0 },
                {0, 0, 0, 0, 1, 1 },
                {0, 0, 0, 1, 0, 1 },
                {0, 0, 0, 1, 1, 0 },
            };
            Assert.Equal(2, Program.FindIslands(arr));
        }
        [Fact]
        public void Test2()
        {
            int[,] arr = new int[6, 6]
            { // 1  2  3  4  5  6 
                {0, 1, 1, 1, 0, 0 },
                {1, 0, 0, 0, 0, 0 },
                {1, 0, 0, 0, 0, 0 },
                {1, 0, 0, 0, 1, 1 },
                {0, 0, 0, 1, 0, 0 },
                {0, 0, 0, 1, 0, 0 },
            };
            Assert.Equal(1, Program.FindIslands(arr));
        }

    }
}
