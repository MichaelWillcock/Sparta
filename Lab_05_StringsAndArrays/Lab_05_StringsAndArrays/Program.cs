using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_05_StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = {1, 2, 3, 4 };

            //char[] charArray2 = new char[] { 'c', 'h', 'a', 'r' };

            //char[] charArray = new char[4];
            //charArray[0] = 'n';
            //charArray[1] = 'i';
            //charArray[2] = 's';
            //charArray[3] = 'h';

            //charArray[1] = 'a';
            //int[,,,] grid4d = new int[4, 3, 20, 30];
            //int[,] grid = new int[2, 4];
            //grid[0, 0] = 1;
            //grid[1, 0] = 2;

            //int[,] grid2d = { { 1, 2, 3, 4, }, { 5, 6, 7, 8 } };
            //Console.WriteLine(grid2d[1, 3]);

            ////Jagged Array's

            //string[][] animalGrid = new string[2][];
            //animalGrid[0] = new string[4];
            //animalGrid[0][0] = "Cat";
            //animalGrid[0][1] = "Elephant";
            //animalGrid[0][2] = "Mouse";
            //animalGrid[1] = new string[] { "Parrot", "Dog" };

            //var beatles = new List<string>();
            //beatles.Add("Lennon");
            //beatles.Add("McCartney");
            //beatles.Add("Harrison");
            //beatles.Add("Ringo");

            //beatles.ForEach(x => Console.WriteLine(x));

            //var myArray = new int[] { 1, 2, 3, 4 };
            //var myList = new List<int>(myArray);
            //var myList2 = new List<int>() { 4, 3, 2, 1 };

            //myList.Remove(1);

            ////Strings
            //string name = "Michael";
            //int length = name.Length;
            //var upperCase = name.ToUpper();
            //var lowerCase = name.ToLower();
            //name = "Michael         ";
            //var trimName = name.Trim();
            //var example = name.Contains('c');

            //string fName = "Michael";
            //string lName = "Willcock";
            //double score = 0.5;
            //string fullName = fName + " " + lName + " Score: " + score;
            //string string2 = $"{fName} {lName} Score: {score}";
            //string string3 = $"{fName} {lName} Score: {score:p1}";
            //string string4 = $"{fName} {lName} Score: {score:f4}";
            //Console.WriteLine(fullName);
            //Console.WriteLine(string2);
            //Console.WriteLine(string3);
            //Console.WriteLine(string4);
            //Console.WriteLine("How many trainees?");
            //string input = Console.ReadLine();

            //int numTrainees = Int32.Parse(input);
            //Console.WriteLine(numTrainees);

            //bool success = Int32.TryParse(input, out int numTrainees);

            //if (success)
            //{
            //    Console.WriteLine($"There are {numTrainees} trainnes in Engineering86");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}

            ////Split
            //string wonderWall = "And after all you're my Wonderwall";
            //string[] lyrics = wonderWall.Split(" ");

            ////StringBuilder
            //var sb1 = new StringBuilder();
            //var sb = new StringBuilder("Hello World");
            //sb.Append(" and Eng-86!");
            //sb.AppendLine("Hope you're enjoying your training");
            //Console.WriteLine(sb);

            //var sb2 = new StringBuilder();
            //sb2.AppendLine("Nish");
            //Console.WriteLine(sb2);
            //sb2.Replace('i', 'a');
            //Console.WriteLine(sb2);
            //sb2.Remove(0, 3);
            //Console.WriteLine(sb2);

            Console.WriteLine(RemoveLastExclamationMark("Hi!"));
            Console.WriteLine(RemoveLastExclamationMark("Hi!"));
            Console.WriteLine(RemoveLastExclamationMark("Hi!"));
            Console.WriteLine(RemoveLastExclamationMark("Hi!"));
            Console.WriteLine(RemoveLastExclamationMark("Hi!"));


        }
        //public static int ArraySum(int[] practiceArray)
        //{
        //    int arraySum = 0;
        //    foreach(var num in practiceArray)
        //    {
        //        arraySum += num;
        //    }
        //    return arraySum;
        //}
        public static string RemoveLastExclamationMark(string input)
        {
            string finalString = input;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (!(input[i].Equals('!')))
                {
                    break;
                }
                else
                {
                    finalString = input.Substring(0, input.Length - 2);
                }
            }
            return finalString;
        }
    }
}
