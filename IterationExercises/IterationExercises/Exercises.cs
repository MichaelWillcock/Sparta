using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            if (nums.Length == 0)
            {
                return int.MaxValue;
            }
            else
            {
                int x = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < x)
                    {
                        x = nums[i];
                    }
                }

                return x;
            }
            
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int x = 0;
            for(int i = 0; i <= max; i++)
                if (i % 2 == 0 || i % 5 == 0)
                {
                    x += i;
                }
            return x;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            foreach(char letter in input)
            {
                if (letter.Equals('A'))
                {
                    aCount++;
                }
                else if (letter.Equals('B'))
                {
                    bCount++;
                }
                else if (letter.Equals('C'))
                {
                    cCount++;
                }
                else if (letter.Equals('D'))
                {
                    dCount++;
                }
                else
                {
                    continue;
                }

            }
            return $"A:{aCount} B:{bCount} C:{cCount} D:{dCount}";
        }
    }
}