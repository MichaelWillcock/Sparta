using System;

namespace Lab_06_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Iterations(Loops)
            //for (int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //var myArray = new int[] { 10, 20, 30 };
            //for (int i = myArray.Length -1; i >= 0; i--)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //foreach (int number in myArray)
            //{
            //    Console.WriteLine(number);
            ////While Loops
            int counter = 0;
            //while(counter <= 10)
            //{
            //    Console.WriteLine(counter * 10);
            //    counter++;
            //}
            //int x = 0;
            //for(int i = 0; i <= 100; i++)
            //{
            //    x = x + i;
            //}
            //Console.WriteLine(x);

            //string sentence = "NISH IS KING";

            //for(int i = 0; i < sentence.Length; i++)
            //{
            //    Console.WriteLine(sentence[i].ToString().ToLower());
            //}
            ////Breaking Out Of Loops!!!

            //for(int i = 0;i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Sill in the loop");
            //}
            //Console.WriteLine("Broke out of loop");

            //while(counter < 10)
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //    //if the counter is less than 4, restart
            //    if (counter < 4) continue;
            //    {
            //        Console.WriteLine(counter * 10);
            //    }
            //}
            for(int i = 1; i < 20; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Broken out of loop");

        }
    }
}
