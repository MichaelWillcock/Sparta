using System;

namespace Selection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var number = 15;
            //var result = "";
            //if (number % 5 == 0)
            //{
            //    result += "Nish";
            //}
            //if (number % 3 == 0)
            //{
            //    result += "Nash";
            //}
            //Console.WriteLine(result);

            //var number = 10;
            //var result = "";
            //if (number % 5 == 0)
            //{
            //    result += "Nish";
            //    if (number % 3 == 0)
            //    {
            //        result += "Nash";
            //    }
            //    else
            //    {
            //        result += "Nosh";
            //    }
            //}
            //Console.WriteLine(result);

            //Console.WriteLine(Grade(75));
            //DayOfWeek(8);
            PassFailTernary(22);

        }

        public static string PassFailTernary(int mark)
        {
            return mark >= 40 ? "Pass" : "Fail";
        }

        public static string PassFail(int mark)
        {
            var grade = "Fail";
            if (mark >= 40)
            {
                grade = "Pass";
            }
            return grade;
        }
        public static void DayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Weekend");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not Valid");
                    break;
            }
        }
        public static string Grade(int mark)
        {
            var grade = "Fail";
            if (mark < 0 || mark > 100)
            {
                throw new Exception("Mark out of Range");
            }
            if (mark >= 40)
            {
                grade = "Pass";
                if (mark >= 75)
                {
                    grade += " with Distinction";
                }
                else if (mark >= 60)
                {
                    grade += " with Merit";
                }
            }
            return grade;
        }
    }
}
