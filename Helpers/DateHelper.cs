using System;
namespace BizClient.Helpers
{
    public static class DateHelper
    {
        public static string GetStringPeriod(DateTime date)
        {
            int years = DateTime.Today.Year - date.Year;
            int monthes = DateTime.Today.Month - date.Month;
            int days = DateTime.Today.Day - date.Day;

            string yearsString = years > 0 ? $"{years} years" : "";
            string monthesString = monthes > 0 ? $"{monthes} month" : "";
            string daysString = days > 0 ? $"{days} days" : "";

            if (yearsString != String.Empty)
            {
                return yearsString + monthesString != String.Empty ? $", ${monthesString}" : "";
            }
            if (monthesString != String.Empty)
            {
                return monthesString;
            }

            return daysString;
        }

        public static int GetAge(DateTime date)
        {
            return DateTime.Today.Year - date.Year;
        }

        public static int GetDaysUntil(DateTime date)
        {
            return (int)(DateTime.Today - date).TotalDays;
        }
    }
}

