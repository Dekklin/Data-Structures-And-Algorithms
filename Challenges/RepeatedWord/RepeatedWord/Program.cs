using System;

namespace RepeatedWord
{
    public class Program
    {
        // Gets called on execution of program, calls the RepeatedWord
        static void Main(string[] args)
        {
            HashSet hs = new HashSet();
            string string3 = "Again lets find no duplicates please";
            Console.WriteLine(hs.RepeatedWord(string3));
            Console.ReadKey();
        }
    }
}
