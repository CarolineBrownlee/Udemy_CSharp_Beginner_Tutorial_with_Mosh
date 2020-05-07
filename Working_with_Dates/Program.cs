using System;

namespace Working_with_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== DATETIME =====
            var dateTime = new DateTime(2015, 1, 1);
            var dateNow = DateTime.Now;
            var today = DateTime.Today;

            System.Console.WriteLine("dateTime: " + dateTime);
            System.Console.WriteLine("dateNow: " + dateNow);
            System.Console.WriteLine("Hour: " + dateNow.Hour);
            System.Console.WriteLine("Minute: " + dateNow.Minute);
            System.Console.WriteLine("Date Today: " + today);

            var tomorrow = dateNow.AddDays(1);
            System.Console.WriteLine("Tomorrow: " + tomorrow);
            var yesterday = dateNow.AddDays(-1);
            System.Console.WriteLine("Yesterday: " + yesterday);

            System.Console.WriteLine("------------------------");
            // C# datetime specifiers 
            System.Console.WriteLine(dateNow);
            System.Console.WriteLine(dateNow.ToLongDateString());
            System.Console.WriteLine(dateNow.ToShortDateString());
            System.Console.WriteLine(dateNow.ToLongTimeString());
            System.Console.WriteLine(dateNow.ToShortTimeString());
            System.Console.WriteLine(dateNow.ToString("MM/dd/yy"));

            // ===== TIMESPAN =====
            // creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = new TimeSpan(2, 53, 0);

            System.Console.WriteLine(timeSpan);
            System.Console.WriteLine(timeSpan1);
            System.Console.WriteLine(timeSpan2);

            var timeSpan3 = TimeSpan.FromHours(1);
            System.Console.WriteLine(timeSpan3);
            
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine(duration);

            // properties
            System.Console.WriteLine("Properties of TimeSpan: ");
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add and Subtract
            System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            System.Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}