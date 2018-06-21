using Xunit;
using MultiBracket;
using System;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturn()
        {
            Assert.True(Program.MultiBracketValidation("(Hey){}no[]"));
            Assert.False(Program.MultiBracketValidation("No{]Way(Will}this}}Pass("));
            Assert.True(Program.MultiBracketValidation("({[[no]]})"));
        }
    }
}
