using System;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet hs = new HashSet();
            //Console.WriteLine(hs.RepeatedWord("Hey there should be no repeats RAWR"));
            //Console.WriteLine(hs.RepeatedWord("Dog House cat dog ribbit please dont break"));
            string string3 = "Again lets find no duplicates please";

            Console.WriteLine(hs.RepeatedWord(string3));
            Console.ReadKey();
        }
    }
}
