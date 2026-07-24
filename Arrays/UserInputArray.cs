using System;

namespace Arrays
{
    // User Input Array
    // Reads array values from the user.

    public class UserInputArray
    {
        public static void Run()
        {
            int[] numbers = new int[3];

            Console.WriteLine("Enter 3 Numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered Numbers:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}