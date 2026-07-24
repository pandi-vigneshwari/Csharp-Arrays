using System;

namespace Arrays
{
    // Arrays in C#
    // This program demonstrates different types of arrays.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ARRAYS IN C# =====");

            Console.WriteLine("\n1. Array Declaration");
            ArrayDeclaration.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n2. Single Dimensional Array");
            SingleDimensionalArray.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n3. Multi-Dimensional Array");
            MultiDimensionalArray.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n4. Jagged Array");
            JaggedArray.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n5. Array Methods");
            ArrayMethods.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n6. User Input Array");
            UserInputArray.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n7. Array Sorting");
            ArraySorting.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n8. Array Traversal");
            ArrayTraversal.Run();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nProgram Completed Successfully.");
            Console.ReadKey();
        }
    }
}