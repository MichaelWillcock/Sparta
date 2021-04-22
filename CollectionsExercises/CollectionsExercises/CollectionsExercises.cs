using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            if (num > queue.Count)
            {
                num = queue.Count;
            }
            string y = "";
            for (int i = 0; i < num; i++)
            {
                if (i < num -1)
                {
                    string x = queue.Dequeue();
                    y = y + x + ", ";
                }
                else
                {
                    string x = queue.Dequeue();
                    y += x;
                }
            }
            return y;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var originalStack = new Stack<int>();
            int[] output = new int[original.Length];
            foreach (int number in original)
            {
                originalStack.Push(number);
            }
            for (int i = 0; i < original.Length; i++)
            {
                int x = originalStack.Pop();
                output[i] = x;
            }

            return output;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            input = input.Trim();
            var counter = new Dictionary<char, int>();
            string output = "";
            if (input.Length == 0)
            {
                return"";
            }
            foreach (char Digit in input)
            {
                if (counter.ContainsKey(Digit))
                {
                    counter[Digit]++;
                }
                else
                {
                    counter.Add(Digit, 1);
                }
            }
            foreach (KeyValuePair<char, int> pair in counter)
            {
                if (Char.IsDigit(pair.Key) != true)
                {
                    counter.Remove(pair.Key);
                }
            }
            foreach (var item in counter)
            {
                output += item;
            }
            return output;

        }
    }
}