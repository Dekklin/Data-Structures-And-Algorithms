using System;
using System.Collections.Generic;

namespace ImplementHashTables
{
    public static class Program
    {
        static void Main(string[] args)
        {
            HashTable ht = new HashTable();
            ht.Add("Cat", 333);
            ht.Add("Doe", 444);
            ht.Add("Hey", 25);
            ht.Add("PleaseFindMe", 201);
            ht.Add("123123", 111);
            ht.Find("Cat");
            ht.Find("Doe");
            ht.Contains("Hey");
            Console.WriteLine(ht.Contains("Hey"));
            Console.WriteLine(ht.Find("Cat"));
            Console.WriteLine(ht.Find("Doe"));
            Console.ReadKey();
            ht.Add("Hey", 599);
            
        }
    }
}
