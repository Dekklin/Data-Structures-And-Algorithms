using System;

namespace _01_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[6] { 12, 18, 4, 5, 6, 7 };
            TestDisplay(ReverseArray(myArr));
            Console.WriteLine("Press any Key to Continue");
            Console.ReadKey();
        }
        static int[] ReverseArray(int[] arr)
        {
            int n = arr.Length;
            int[] newArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                newArr[i] = arr[n - (i + 1)];
            }
            return newArr;
        }
        static void TestDisplay(int[] arr)
        {
            for (int num = 0; num < arr.Length; num++)
            {
                if (num == arr.Length-1)
                {
                    Console.Write($"{arr[num]} - ");
                }
                else {
                    Console.Write($"{arr[num]}, ");
                }
            }
        }
    }
}
