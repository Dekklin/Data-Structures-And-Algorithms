using RepeatedWord;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindDuplicate()
        {
            HashSet hs = new HashSet();

            string str = "Dog House cat dog ribbit please dont break";

            Assert.Equal("dog", hs.RepeatedWord(str));
        }
        [Fact]
        public void CanFindDuplicateAgain()
        {
            HashSet hs = new HashSet();
            string str = "NOW lets MAke Some Duplicates because duplicates ARE AWESOME";


            Assert.Equal("duplicates", hs.RepeatedWord(str));
        }
        [Fact]
        public void CanFindNoDuplicate()
        {
            HashSet hs = new HashSet();
            string str = "Hey there should be no repeats RAWR";
            Assert.Equal("no dups", hs.RepeatedWord(str));
        }
        [Fact]
        public void CanFindNoDuplicateAGain()
        {
            HashSet hs = new HashSet();
            string str = "Again lets find no duplicates please";
            Assert.Equal("no dups", hs.RepeatedWord(str));
        }
    }
}
