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

            //var output = DoThat(10);

            //OrderPizza(anchovies: false, false);

            //int number = 10;
            //Add(number);
            //Console.WriteLine(number);
            //Add(ref number);
            //Console.WriteLine(number);

            //DoAgain(10, "Sparta Global", out bool z);
            //Console.WriteLine(z);

            //var myTuple = ("Frazer", "Green", 23);
            //(string, string, int) myTuple2 = ("Michael", "Willcock", 23);
            //(string fName, string lName, int age) myTuple3 = ("Hamse", "Ahmed", 22);

            //Console.WriteLine(myTuple3.lName);

            //var title = "Interstellar";
            //int watched = 3;

            //var myTuple5 = (title, watched);
            //Console.WriteLine(myTuple5);

            //var result = DoThatAgain(10, "Sparta Global");
            //Console.WriteLine(result);
            //Console.WriteLine(result.xsquared);
            //var (square, greaterThan10) = DoThatAgain(5, "Heya");
            //Console.WriteLine(greaterThan10);
            //Console.WriteLine(square);

            //Console.WriteLine(Add(2, 3));
            //Console.WriteLine(Add(4, 5, 6));
            //Method overloading automatically selects the right method based on the number of input parameters.

            Console.WriteLine(TripleCalc(1, 2, 3));
        }

        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }
        public static (int sum, int product) TripleCalc(int a, int b, int c)
        {

            return (a + b + c, a * b * c);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public static (int xsquared, bool y_got_10) DoThatAgain(int x, string y)
        {
            Console.WriteLine(y);
            var z = (x > 10);
            return (x * x, z);
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
        static void OrderPizza(bool anchovies, bool pineapple, bool mushrooms = false)
        {
            if (anchovies = true && pineapple == true && mushrooms == true)
            {
                Console.WriteLine("Delicious");
            }
            else if (anchovies = true && pineapple == false && mushrooms == true)
            {
                Console.WriteLine("Less Delicious");
            }
            else if (anchovies = false && pineapple == false && mushrooms == true)
            {
                Console.WriteLine("Even less delicious");
            }
            else
            {
                Console.WriteLine("This is just bread!!!");
            }
        }
        //static void Add(int x)
        //{
        //    x++;
        //}
        //static void Add(ref int x)
        //{
        //    x++;
        //}
        public static int DoAgain(int x, string y, out bool z)
        {
            Console.WriteLine(y);
            z = (x > 10);
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
