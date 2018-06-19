using System;
using Xunit;
using _12_AnimalShelter;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnQueue()
        {
            AnimalShelter Shelter = new AnimalShelter(new Animal("dog"));

            Assert.Equal("cat", Shelter.EnQueue(new Animal("cat")));
            // capital DOG will be "dog"
            Assert.Equal("dog", Shelter.EnQueue(new Animal("DOG")));
            Assert.Equal("Please pick dog or cat", Shelter.EnQueue(new Animal("snake")));
        }
        [Fact]
        public void CanDeQueue()
        {
            AnimalShelter Shelter = new AnimalShelter(new Animal("dog"));
            Shelter.EnQueue(new Animal("dog"));
            Shelter.EnQueue(new Animal("cat"));
            Shelter.EnQueue(new Animal("dog"));
            // if the user input != cat || dog
            Assert.Equal("dog", Shelter.DeQueue("Ninja").Value);
            // if the user puts in a correct input
            Assert.Equal("cat", Shelter.DeQueue("cat").Value);
            // if there is no cat, return the front
            Assert.Equal("dog", Shelter.DeQueue("cat").Value);
        }
    }
}
