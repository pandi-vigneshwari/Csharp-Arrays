using System;

namespace Arrays
{
    // Array Declaration
    // Stores multiple values of the same data type.

    public class ArrayDeclaration
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