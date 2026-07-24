using System;

namespace Arrays
{
    // Multi-Dimensional Array
    // Stores data in rows and columns.

    public class MultiDimensionalArray
    {
        public static void Run()
        {
            int[,] numbers =
            {
                {1,2},
                {3,4}
            };

            Console.WriteLine("Array Elements:");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}