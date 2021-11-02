using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing_logical_prog
{
    class DayOfWeek
    {
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        public static void Days(int month, int day, int year)
        {
            string[] days = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
            int dayIndex = Utility.Days(month, day, year);
            Console.WriteLine("day= " + days[dayIndex]);
        }
    }
}
