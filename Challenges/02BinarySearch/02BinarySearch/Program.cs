using System;

namespace _02BinarySearch
{
    class Program
    {
        //method that defines a test array and a test search key
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, 3, 4, 5, 6, 8};
            int SK = 3;
            Console.WriteLine(BinarySearch(testArray, SK, testArray.Length - 1, 0));
            Print(testArray);
            Console.WriteLine($"Your Search Key was {SK}");
            Console.Read();
        }
        //Method that cuts an array in half, if the search key is less than that middle point, it makes that mid point the new max, and runs the method again.
        //if the mid point was less than the SK, it makes the mid point the new min point and runs the method again with the new arguements
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
        //This method simply prints out our array for testing and visibility reasons. 
        static void Print(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i}, ");
             
            }
        }
    }
}
