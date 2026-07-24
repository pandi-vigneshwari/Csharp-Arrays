using System;

namespace Arrays
{
    // Array Traversal
    // Accesses each element using a for loop.

    public class ArrayTraversal
    {
        public static void Run()
        {
            string[] fruits = { "Apple", "Orange", "Banana" };

            Console.WriteLine("Fruits:");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}