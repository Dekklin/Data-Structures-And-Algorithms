using System;
using Xunit;
using static _07_ll_kth_from_end.Program;
using _07_ll_kth_from_end;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 10)]
        [InlineData(2, 14)]
        [InlineData(4, 18)]
        public void CanReturnValidNode(int k, int expectedValue)
        {
            Assert.Equal(expectedValue, Program.KthElement(k).Value);
        }
    }
}
