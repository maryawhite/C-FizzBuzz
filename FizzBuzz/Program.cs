using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(50);
        }

        static void FizzBuzz(int number) {
            for (int i = 1; i < number; i++) {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
