using System;

namespace ConsoleApp1
{
    class Program
    { 
        /// <summary>
        /// I call Insertion Sort in main and write out the results
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test1 = new int[8]{ 51, 2, 28, 22, 1, 22, 19, 101};
            InsertionSort(test1);
            foreach(int k in test1)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }


        /// <summary>
        /// Insertion sorts a int array from lowest to highest
        /// </summary>
        /// <param name="arr">an int array of nay size</param>
        /// <returns>the sorted version of that array</returns>
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
