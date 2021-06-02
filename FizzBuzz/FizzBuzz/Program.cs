using System;

namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 50;
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine($"{Fizzbuzz(i)}");
            }
            
        }

        public static string Fizzbuzz(int i)
        {
            if (i%15 == 0)
            {
                return "FizzBuzz";
            }
            else if (i%3 == 0)
            {
                return "Fizz";
            }
            else if (i%5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return i.ToString();
            }
        }
    }
}
