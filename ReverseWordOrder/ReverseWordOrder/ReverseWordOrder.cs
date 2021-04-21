using System;
using System.Text;

namespace ReverseWordOrder
{
    public class WordReverser
    {

        public static string ReverseWords(string input)
        {
            string[] words = input.Split(" ");
            int wordsLength = 0;
            var finalString = new StringBuilder();
            foreach (string word in words)
            {
                wordsLength++;
            }
            string[] backwardsWords = new string[wordsLength];
            for (int i = 0; i < wordsLength; i++)
            {
                backwardsWords[i] = words[(wordsLength - 1) - i];
            }
            for (int j = 0; j < wordsLength; j++)
            {
                finalString.Append(backwardsWords[j] + " ");
            }
            string reallyFinalString = finalString.ToString();
            return reallyFinalString.Trim();

        }

    }
}
