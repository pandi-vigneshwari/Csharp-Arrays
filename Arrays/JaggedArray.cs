using System;

namespace Arrays
{
    // Jagged Array
    // An array that contains other arrays.

    public class JaggedArray
    {
        public static void Run()
        {
            int[][] numbers =
            {
                new int[] {1,2},
                new int[] {3,4,5}
            };

            foreach (int[] row in numbers)
            {
                foreach (int number in row)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}