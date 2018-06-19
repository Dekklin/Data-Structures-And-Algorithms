using System;

namespace _12_AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FIFOAnimalShelter("cat");
            Console.ReadKey();
        }
        static void FIFOAnimalShelter(string pref)
        {
            AnimalShelter Shelter = new AnimalShelter(new Animal("dog"));
            Shelter.EnQueue(new Animal("dog"));
            Shelter.EnQueue(new Animal("cat"));
            Shelter.EnQueue(new Animal("dog"));
            Shelter.EnQueue(new Animal("cat"));
            Shelter.EnQueue(new Animal("cat"));
            Shelter.DeQueue(pref);
            Shelter.Print();
        }
    }
}
