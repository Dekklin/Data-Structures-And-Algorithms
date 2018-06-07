using System;

namespace _03_2D_Arrays
{
    class Program
    {
        //Main method that defines my own array, should be adaptable to any 2d array
        static void Main(string[] args)
        {
            int[,] array = new int[4,3] { { 2, 3, 4 }, { 4, 1, 3 }, { 6, 3, 1 }, { 1, 7, 3 } };
            doMath(array);
        }   
        //Method to calculate product of each adjacent int in any int 2D array
        static void doMath(int[,] array)
        {
            //CurrentProduct is my method of holding each product
            //Product contains my highest product 
            int currentProduct = 0;
            int product = 0;
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write($"{array[x,y]} ");
                    // 4 arrays ----- 3 elements per array
                    // making sure we don't try to multiply the last array, with an array that doesnt exist
                    if(x + 1 < array.GetLength(0))
                    {
                        if (currentProduct < array[x, y] * array[x + 1, y])
                            {
                            currentProduct = array[x, y] * array[x + 1, y];
                        }
                        // makes sure the last element in each array doesnt try to multiply with the next element in it's array
                        if(y > 0)
                        {
                            if(currentProduct < array[x,y] * array[x + 1, y - 1])
                            {
                                currentProduct = array[x, y] * array[x + 1, y - 1];
                            }
                        }
                    }
                    if(y + 1 < array.GetLength(1))
                    {
                        if(currentProduct < array[x,y] * array[x, y + 1])
                        {
                            currentProduct = array[x, y] * array[x, y + 1];
                        }

                    }
                    if(x + 1 < array.GetLength(0) && y + 1 < array.GetLength(1))
                    {
                        if(currentProduct < array[x, y] * array[x + 1, y + 1])
                        {
                            currentProduct = array[x, y] * array[x + 1, y + 1];
                        }
                    }
                    Console.WriteLine(currentProduct);
                    product = currentProduct;
                }
            }
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
