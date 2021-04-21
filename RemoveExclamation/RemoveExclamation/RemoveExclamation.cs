using System;
using System.Text;

namespace RemoveExclamation
{
    public class Remove
    {
        public static string RemoveLastExclamationMark(string input)
        {
            string finalString = input;
            for (int i = input.Length -1; i >= 0; i--)
            {
                if (!(input[i].Equals('!')))
                {
                    break;
                }
                else
                {
                    finalString = input.Substring(0, input.Length-1);
                }
            }
            return finalString;
        }
    }
}
