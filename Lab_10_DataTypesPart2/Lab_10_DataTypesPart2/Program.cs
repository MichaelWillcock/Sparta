using System;
using System.Diagnostics;

namespace Lab_10_DataTypesPart2
{
    class Program
    {
        //private readonly string fName;
        //private readonly string lName = "Nish";
        //private const int age = 32;

        //public Program(string FirstName)
        //{
        //    fName = FirstName;
        //}
        static void Main(string[] args)
        {
            //var d = new DateTime();
            //var d1 = DateTime.Today;
            //var d3 = new DateTime(2018, 7, 12, 10, 5, 18);
            //d3 = d3.AddDays(1);
            //d3 = d3.AddMonths(2);

            //var date = DateTime.Today;
            //var birthDate = new DateTime(1989, 11, 02);
            //var age = date - birthDate;
            //Console.WriteLine(age/365.25);

            //var output = DateTime.Now.ToString("dd-MM-yyyy");
            //var output2 = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            //var output3 = DateTime.Now.ToString("yy-MM-dd");

            //////TimeSpan and Ticks
            //var timeSpan = new TimeSpan(1, 0, 0);
            ////Add this timespan to time now
            //var date = DateTime.Now + timeSpan;
            ////Add one tick to our date
            //var tick = new TimeSpan(1);
            //date = date + tick;

            ////Stopwatch

            //var s = new Stopwatch();
            //s.Start();
            //int total = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    total += 1;
            //}
            //s.Stop();
            //Console.WriteLine(s.Elapsed);
            //Console.WriteLine(s.ElapsedMilliseconds);
            //Console.WriteLine(s.ElapsedTicks);

            //Suit theSuit = Suit.HEARTS;
            //var heart = (int)theSuit;
            //var club = (Suit)27;
            //Console.WriteLine(heart);
            //Console.WriteLine(club);
            //Console.WriteLine(Suits(theSuit));

            //var c = new DateTime();
            //var monday = (int)DayOfWeek.Monday;
            //Console.WriteLine(monday);

            //var monday2 = (DayOfWeek)1;
            //Console.WriteLine(monday2);

            //int dog;
            //float cat;
            //bool thing;
            //char c;
            //DateTime dt;
            //string aString;
            //int[] myArray;

            //////Nullable Types
            ////bool? hasPassed;
            //int? hasPassed = 3;
            //if (hasPassed.HasValue)
            //{
            //    Console.WriteLine("Congrats");
            //}
            //else
            //{
            //    Console.WriteLine("No value");
            //}

            //int? nullableScore = 3;

            //int score = nullableScore ?? 9999;
            //int score1 = nullableScore.GetValueOrDefault(-1);
            //int score2 = nullableScore.GetValueOrDefault();

            //int score3 = (int)nullableScore;

            //int dozen = 12;
            //dozen = 13;

            //dynamic item = 100;
            //Console.WriteLine($"Adding 10 to {item} gives {item + 10}");
            //item = "hello";
            //Console.WriteLine($"Adding 10 to {item} gives {item + 10}");

            //////Random Class
            //var rng = new Random(); //seed with current time
            //var rngseeded = new Random(42);
            //var between1and10 = rngseeded.Next(1, 11);

            //var rollTheDice = new Random();
            //var dice1 = rollTheDice.Next(6);
            //var dice2 = rollTheDice.Next(6);
            //var dice3 = rollTheDice.Next(6);

            //var result = dice1 + dice2 + dice3;
            //Console.WriteLine(result);

        }

        public enum Suit
        {
            HEARTS, CLUBS, DIAMONDS, SPADES
        }
        //public static void Suits(Suit suit)
        //{
        //    switch(suit)
        //    {
        //        case Suit.HEARTS:
        //            return { "You have stolen it" };
        //        case Suit.CLUBS:
        //            return { "The best one in town" };
        //        case Suit.DIAMONDS:
        //            return { "My best mate" };
        //        case Suit.SPADES:
        //            return { "Another hole in the ground" };

        //    }
        //}
    }
}
