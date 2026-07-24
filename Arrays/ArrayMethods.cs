using System;

namespace Arrays
{
    // Array Methods
    // Demonstrates common array methods.

    public class ArrayMethods
    {
        public static void Run()
        {
            int[] numbers = { 40, 20, 10, 30, 50 };

            Console.WriteLine("Length : " + numbers.Length);

            Array.Sort(numbers);

            Console.WriteLine("Sorted Array:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Array.Reverse(numbers);

            Console.WriteLine("Reversed Array:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}