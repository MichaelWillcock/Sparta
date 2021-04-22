using System;
using System.IO;

namespace Lab_09_Exceptions
{
    public class Program
    {
        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };
        static void Main(string[] args)
        {
            try
            {
                AddBeatle(4, "Brian");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown: " + e.Message);
            }

            //int x = 10;
            //int y = 1;
            //int output = 0;

            //try
            //{
            //    output = x / y;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An exceptions has occured");
            //}
            //finally
            //{
            //    Console.WriteLine("But life goes on");
            //}
        }

        public static void AddBeatle(int pos, string name)
        {
            if (pos < 0 || pos > _theBeatles.Length)
            {
                throw new ArgumentException($"The beatles do not have the position {pos}");
            }

            //_theBeatles[pos] = name;
        }
    }
}
