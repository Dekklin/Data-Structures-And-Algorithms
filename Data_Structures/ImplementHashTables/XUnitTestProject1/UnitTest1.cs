using ImplementHashTables;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddKeyValue()
        {
            HashTable ht = new HashTable();
            ht.Add("Cat", 333);
            ht.Add("Doe", 444);
            ht.Add("Hey", 25);
            ht.Add("PleaseFindMe", 201);
            ht.Add("123123", 111);
            ht.Find("Cat");
            ht.Find("Doe");
            Assert.Equal(333, ht.Find("Cat"));
        }

        [Fact]
        public void CanReturnContains()
        {
            HashTable ht = new HashTable();
            ht.Add("Cat", 333);
            ht.Add("Doe", 444);
            ht.Add("Hey", 25);
            ht.Add("PleaseFindMe", 201);
            ht.Add("123123", 111);
            ht.Find("Cat");
            ht.Find("Doe");
            Assert.True(ht.Contains("123123"));
        }
        [Fact]
        public void CanHandleCollision()
        {
            HashTable ht = new HashTable();
            ht.Add("Cat", 333);
            ht.Add("Doe", 444);
            ht.Add("Hey", 25);
            ht.Add("PleaseFindMe", 201);
            ht.Add("123123", 111);
            ht.Find("Cat");
            ht.Find("Doe");
            // Cat and Doe have the same Ascii value 280
            Assert.Equal(333, ht.Find("Cat"));
            Assert.Equal(444, ht.Find("Doe"));
        }
    }
}
