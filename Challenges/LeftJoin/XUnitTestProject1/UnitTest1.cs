using LeftJoin;
using System;
using System.Collections.Generic;
using Xunit;
using static LeftJoin.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindPairs()
        {
            HashTable hs = new HashTable();
            hs.Add("fond", "enamored");
            hs.Add("wrath", "anger");
            hs.Add("diligent", "employed");
            hs.Add("outfit", "garb");
            hs.Add("guide", "usher");


            HashTable hs2 = new HashTable();
            hs2.Add("fond", "adverse");
            hs2.Add("wrath", "delight");
            hs2.Add("diligent", "idle");
            hs2.Add("guide", "follow");
            hs2.Add("flow", "jam");

            List<string> result = JoinLeft(hs, hs2);


            Assert.Contains("fond : enamored & adverse", result);
            Assert.Contains("guide : usher & follow", result);
            Assert.Contains("wrath : anger & delight", result);
        }
        [Fact]
        public void CanFindNulls()
        {
            HashTable hs = new HashTable();
            hs.Add("sports", "soccer");
            hs.Add("food", "tacos");
            hs.Add("weather", "sunny");
            hs.Add("boolean", "garb");
            hs.Add("Eric", "TA");


            HashTable hs2 = new HashTable();
            hs2.Add("shoes", "nike");
            hs2.Add("boolean", "true");
            hs2.Add("Eric", "Student");
            hs2.Add("sports", "hockey");
            hs2.Add("dessert", "cake");

            List<string> result = JoinLeft(hs, hs2);
            Assert.Contains("Eric : TA & Student", result);
            Assert.Contains("weather : sunny & Null", result);
            Assert.Contains("food : tacos & Null", result);
        }
    }
}
