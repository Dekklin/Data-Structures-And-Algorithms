using System;

namespace _02BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, 3, 4, 5, 6, 8};
            int SK = 3;
            Console.WriteLine(BinarySearch(testArray, SK, testArray.Length - 1, 0));
            Print(testArray);
            Console.WriteLine($"Your Search Key was {SK}");
            Console.Read();

        }
        static int BinarySearch(int[] array, int SK,int Max, int Min)
        {
            int results = -1;
            int Mid = (Max - Min) / 2 + Min;
            if (SK < array[Mid])
            {
                Max = Mid;
                return BinarySearch(array, SK, Max, Min);
            }
            if(SK > array[Mid])
            {
                Min = Mid;
                return BinarySearch(array, SK, Max, Min);
            }
            if (array[Mid] == SK)
            {

                results = Mid;
            }

            return results;
        }
        static void Print(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i}, ");
             
            }
        }
    }
}