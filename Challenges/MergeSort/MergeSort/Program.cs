using System;

namespace MergeSort
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 52, -215, 125, 16, 1, 0, -1512, 10682 };


            Console.WriteLine("MergeSort By Recursive Method");
            MergeSortRecursive(numbers, 0, numbers.Length - 1);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadKey();


        }
        /// <summary>
        /// MergeSortRecursive cuts the array up by a mid point, then sends the split array into recursion 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void MergeSortRecursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortRecursive(numbers, left, mid);
                MergeSortRecursive(numbers, (mid + 1), right);
                DoMerge(numbers, left, (mid + 1), right);
            }
        }
        /// <summary>
        /// DoMerge takes the two arrays from MergeSortRecursive, and individually sorts the two
        /// </summary>
        /// <param name="numbers">The Array of integers that will be sorted</param>
        /// <param name="left">The Left most index of the array</param>
        /// <param name="mid">The mid point of the original array</param>
        /// <param name="right">The Right most index in the array</param>
        public static void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, leftEnd, numLength, tempNum;

            leftEnd = (mid - 1);
            tempNum = left;
            numLength = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tempNum++] = numbers[left++];
                else
                    temp[tempNum++] = numbers[mid++];
            }

            while (left <= leftEnd)
                temp[tempNum++] = numbers[left++];

            while (mid <= right)
                temp[tempNum++] = numbers[mid++];

            for (i = 0; i < numLength; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
