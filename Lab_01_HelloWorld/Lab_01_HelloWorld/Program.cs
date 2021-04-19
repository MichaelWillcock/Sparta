using System;

namespace Lab_01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 100;
            x += 10;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                    x += i;
            }
        }
    }
}
