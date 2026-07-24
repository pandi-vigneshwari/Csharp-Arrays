using System;

namespace Arrays
{
    // Array Sorting
    // Sorts an array in ascending order.

    public class ArraySorting
    {
        public static void Run()
        {
            int[] numbers = { 55, 12, 80, 25, 40 };

            Array.Sort(numbers);

            Console.WriteLine("Sorted Array:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}