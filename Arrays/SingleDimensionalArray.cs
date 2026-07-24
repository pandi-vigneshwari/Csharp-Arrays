using System;

namespace Arrays
{
    // Single Dimensional Array
    // Stores multiple values of the same data type.

    public class SingleDimensionalArray
    {
        public static void Run()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array Elements:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}