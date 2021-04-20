using System;

namespace Lab_04_MethodsAndUnitTesting
{
    public class Methods
    {
        static void Main()
        {
            //DoThis1();

            //var output = DoThis2();

            //var output = DoThis3(10, "Sparta Global");

            var output = DoThat(10);
        }
        public static void DoThis1()
        {
            Console.WriteLine("I am doing something");
        }
        public static int DoThis2()
        {
            Console.WriteLine("I am returning 100");
            return 100;
        }
        public static int DoThis3(int x, string y)
        {
            Console.WriteLine(y);
            return x * x;
        }
        public static int DoThat(int x, string y = "Default")
        {
            Console.WriteLine(y);
            return x * x;
        }
        //static int Add(int number1, int number2)
        //{
        //    return number1 + number2;
        //}
        //static int Subtract(int number1, int number2)
        //{
        //    return number1 - number2;
        //}
        //static int Multiply(int number1, int number2)
        //{
        //    return number1 * number2;
        //}
        //static double Add(double number1, double number2)
        //{
        //    return number1 / number2;
        //}
    }
}
