// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first num:");
        int first_num = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the secound num:");
        int secound_num = int.Parse(Console.ReadLine());

        Console.WriteLine("The prime numbers between {0} and {1} are:", first_num, secound_num);
        for (int s = first_num; s <= secound_num; s++)
        {
            if (IsPrime(s))
            {
                Console.Write(s + " ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int s = 2; s <= Math.Sqrt(number); s++)
        {
            if (number % s == 0)
            {
                return false;
            }
        }

        return true;
    }
}























