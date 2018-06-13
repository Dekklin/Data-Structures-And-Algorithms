using System;

namespace _02BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {// my test array is the array I'm hard coding to run every time someone runs the program
            int[] testArray = new int[] { 1, 3, 4, 5, 6, 8};
            // looking for our hard coded search key, could be set to any number
            int SK = 3;
            //Here we are having the program write out our BinarySearch method, at te same time it is calling itself with the variables we set above
            Console.WriteLine(BinarySearch(testArray, SK, testArray.Length - 1, 0));
            Print(testArray);
            Console.WriteLine($"Your Search Key was {SK}");
            Console.Read();

        }
        // Method that begins (and ends) the math portion of our program
        static int BinarySearch(int[] array, int SK,int Max, int Min)
        {
            //Since we want to return -1 if an element doesn't match our search key
            int results = -1;
            // Everytime we run this function, the mid point changes
            int Mid = (Max - Min) / 2 + Min;
            //grabs the first half of our array if the search key was less than our current mid point.
            if (SK < array[Mid])
            {
                //if we grab the first half of the array, we want to have the min and max adjust accordingly, min is already 0, our max has to be our mid though.
                //Because we never found the search key, we're going to rerun the method with our new dimensions
                Max = Mid;
                return BinarySearch(array, SK, Max, Min);
            }
            // This does the same logic as above, but this is if the Search Key is greater than the mid point
            if(SK > array[Mid])
            {
                // reassigning min now instead of max because we're moving up in the array, not down
                Min = Mid;
                return BinarySearch(array, SK, Max, Min);
            }
            // the if statement we WANT to hit, when we found the search key, we are going to return mid, which is the index of the found element
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