using System;
using Day = System.DayOfWeek;

namespace GitHub.com1
{
    class DayOfWeekCollection
    {
        Day[] days =
        {
        Day.Sunday, Day.Monday, Day.Tuesday, Day.Wednesday,
        Day.Thursday, Day.Friday, Day.Saturday
        };

        public int this[Day day] => FindDayIndex(day);

        private int FindDayIndex(Day day)
        {
            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == day)
                {
                    return j;
                }
            }
            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is not supported.\nDay input must be a defined System.DayOfWeek value.");
        }
    }
    class Program
    {
        static void Main()
        {
            var week = new DayOfWeekCollection();
            Console.WriteLine(week[DayOfWeek.Saturday]);

            try
            {
                Console.WriteLine(week[(DayOfWeek)12]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Not supported input: {e.Message}");
            }
        }
    }
}
