using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ManipulateString("Cathy", 10));
        }
        public static string ManipulateString(string input, int num)
        {
            var string1 = new StringBuilder(input.Trim().ToUpper());
            for (int i = 0; i <= num; i++)
            {
                string1.Append(i.ToString());
            }
            return string1.ToString();
        }
    }
}
