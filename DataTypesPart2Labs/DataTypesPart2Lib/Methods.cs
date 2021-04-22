using System;
using System.Diagnostics;

namespace DataTypesPt2Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class Methods
    {
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (birthDate > date)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            else
            {
                var age = date - birthDate;
                int ageSeconds = (int)age.TotalSeconds;
                int ageYears = ageSeconds / 31557600;
                return ageYears;
            }
            
        }

        public static string FormatDate(DateTime date)
        {
            var dayAndYear = date.ToString("yy/dd");
            var monthToString = date.ToString("MM");
            int month = Int32.Parse(monthToString);
            string monthString = "";
            switch (month)
            {
                case 01:
                    monthString = "Jan";
                    break;
                case 02:
                    monthString = "Feb";
                    break;
                case 03:
                    monthString = "Mar";
                    break;
                case 04:
                    monthString = "Apr";
                    break;
                case 05:
                    monthString = "May";
                    break;
                case 06:
                    monthString = "Jun";
                    break;
                case 07:
                    monthString = "Jul";
                    break;
                case 08:
                    monthString = "Aug";
                    break;
                case 09:
                    monthString = "Sep";
                    break;
                case 10:
                    monthString = "Oct";
                    break;
                case 11:
                    monthString = "Nov";
                    break;
                case 12:
                    monthString = "Dec";
                    break;
                default:
                    monthString = "Not valid";
                    break;
            }
            string formattedDate = dayAndYear + "/" + monthString;
            return formattedDate;
        }
        public static string GetMonthString(DateTime date)
        {
            var indexMonth = date.Month;
            string monthString = "";
            switch (indexMonth)
            {
                case 1:
                    monthString = "January";
                    break;
                case 2:
                    monthString = "February";
                    break;
                case 3:
                    monthString = "March";
                    break;
                case 4:
                    monthString = "April";
                    break;
                case 5:
                    monthString = "May";
                    break;
                case 6:
                    monthString = "June";
                    break;
                case 7:
                    monthString = "July";
                    break;
                case 8:
                    monthString = "August";
                    break;
                case 9:
                    monthString = "September";
                    break;
                case 10:
                    monthString = "October";
                    break;
                case 11:
                    monthString = "November";
                    break;
                case 12:
                    monthString = "December";
                    break;
                default:
                    monthString = "Not valid";
                    break;
            }
            return monthString;
        }

        public static string Fortune(Suit suit)
        {
            string finalString = "";
            switch (suit)
            {
                case Suit.HEARTS:
                    finalString = "You've broken my heart";
                    break;
                case Suit.CLUBS:
                    finalString = "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case Suit.DIAMONDS:
                    finalString = "Diamonds are a girls best friend";
                    break;
                case Suit.SPADES:
                    finalString = "Bucket and spade";
                    break;
                default:
                    finalString = "Not a valid selection";
                    break;
            }
            return finalString;
        }
    }
}
    