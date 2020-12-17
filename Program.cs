using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather
{
    class Program
    {
        enum DayOfWeek { Sun, Mon, Tues, Wed, Thurs, Fri, Sat };

        class Weather
        {
            public DayOfWeek Day { get; set; }
            public int HighTemp { get; set; }
            public int LowTemp { get; set; }

            public Weather(DayOfWeek day, int high, int low)
            {
                Day = day;
                HighTemp = high;
                LowTemp = low;
            }
        }
        static void Main(string[] args)
        {
            List<Weather> daysForecasted = new List<Weather>();

            daysForecasted.Add(new Weather(DayOfWeek.Sun, 34, 27));
            daysForecasted.Add(new Weather(DayOfWeek.Mon, 42, 35));
            daysForecasted.Add(new Weather(DayOfWeek.Tues, 41, 32));
            daysForecasted.Add(new Weather(DayOfWeek.Wed, 46, 32));
            daysForecasted.Add(new Weather(DayOfWeek.Thurs, 43, 33));
            daysForecasted.Add(new Weather(DayOfWeek.Fri, 50, 33));
            daysForecasted.Add(new Weather(DayOfWeek.Sat, 37, 22));

            var coldDays =
                from forecast in daysForecasted
                where forecast.HighTemp < 40
                select forecast;

            foreach (Weather i in daysForecasted)
            {
                Console.WriteLine("\nCold weather on {0}", i.Day);
            }
        }
    }
}
