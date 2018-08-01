using System;

namespace QuickSort
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] a = new int[] { 5, 12, 51, 72, 23, 53, 11, 23, 621,-526, 12, 1, -25};
            QuickSort(a, 0, a.Length - 1);
            foreach(int k in a)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
            Console.Write("stop");
        }
        /// <summary>
        /// QuickSort finds the mid point between the start and finish and continuously adds any numbers greater than the midpoint to the right, and any numbers less than the midpoint, to the left
        /// </summary>
        /// <param name="a">the unsorted array</param>
        /// <param name="start">the left most unsorted number</param>
        /// <param name="end">the right most unsorted number</param>
        public static void QuickSort(int[] a, int start, int end)
        {
            int left = start;
            int right = end;
            int pivot = a[(start + end) / 2];

            while (left <= right)
            {
                while (a[left].CompareTo(pivot) < 0)
                {
                    left++;
                }
                while (a[right].CompareTo(pivot) > 0)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = a[left];
                    a[left] = a[right]; 
                    a[right] = temp;
                    left++;
                    right--;
                }
            }
            if (start < right)
            {
                QuickSort(a, start, right);
            }
            if (left < end)
            {
                QuickSort(a, left, end);
            }

        }

    }
}
