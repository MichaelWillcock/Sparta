using System;

namespace SelectionExercisesLib
{
    public class Exercises
    {
        // implement this method so that it returns true if num is even, otherwise false
        public static bool EvenOdd(int num)
        {
            bool x = false;
            if (num % 2 == 0)
            {
                x = true;
            }
            return x;

        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        // Throw an ArgumentException if age is less than 0
        public static string TicketType(int age)
        {
            if (age >= 60)
            {
                return "OAP";
            }
            else if (age >= 18)
            {
                return "Standard";
            }
            else if (age >= 13)
            {
                return "Student";
            }
            else if (age >= 5)
            {
                return "Child";
            }
            else if (age >= 0)
            {
                return "Free";
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}