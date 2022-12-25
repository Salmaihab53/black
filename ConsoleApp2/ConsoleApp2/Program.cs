// See https://aka.ms/new-console-template for more information

using System;
using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read y1 and y2 from the user
            Console.WriteLine("Enter y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = int.Parse(Console.ReadLine());

            // Find and print the perfect numbers from y1 to y2
            Console.WriteLine("Perfect numbers from " + y1 + " to " + y2 + ": ");
            for (int z = y1; z <= y2; y++)
            {
                if (IsPerfectNumber(z))
                {
                    Console.WriteLine(z);
                }
            }
        }

        // Returns true if the given number is a perfect number, false otherwise
        static bool IsPerfectNumber(int y)
        {
            int sum = 0;
            for (int z = 1; z < y; z++)
            {
                if (y % z == 0)
                {
                    sum += z;
                }
            }
            return sum == y;
        }
    }
}






















