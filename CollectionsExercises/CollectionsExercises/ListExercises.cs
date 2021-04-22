
using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var List = new List<int>();
            if (max == 0)
            {
                List = List;
            }
            else
            {
                for (int i = 1; i <= max; i++)
                {
                    if (i % 5 == 0)
                    {
                        List.Add(i);
                    }
                }
            }
            return List;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            double sum = 0;
            if (argList.Count > 0)
            {
                foreach (double number in argList)
                {
                    sum += number;
                }
                sum = sum / argList.Count;
            }
            else
            {
                sum = 0;
            }
            return sum;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var List = new List<string>();
            if (sourceList.Count > 0)
            {
                foreach (string word in sourceList)
                {
                    if (word.ToUpper().StartsWith('A') == true)
                    {
                        List.Add(word);
                    }
                }
            }
            else
            {
                List = List;
            }
            return List;
        }
    }
}
  