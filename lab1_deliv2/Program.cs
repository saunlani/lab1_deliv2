using System;
using System.Globalization;

namespace lab1_deliv2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        Start:
            //initial instructions delivered to user
            Console.WriteLine("Enter two dates to determine the duration between the two dates in Years, Months and Days.");

            Console.WriteLine("\nEnter the first date (MM/DD/YYYY):");

            DateTime firstdate;
            if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy",
                                      CultureInfo.InvariantCulture,
                                       DateTimeStyles.None, out firstdate))
            { }
            else
            {
                Console.Write("Not a valid date format\n\n");
                goto Start;
            }
            Console.WriteLine("\nEnter the second date (MM/DD/YYYY):");

            DateTime seconddate;
            if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy",
                                      CultureInfo.InvariantCulture,
                                       DateTimeStyles.None, out seconddate))
            { }
            else
            {
                Console.Write("Not a valid date format\n\n");
                goto Start;
            }
            TimeSpan datediff = seconddate.Subtract(firstdate);
            Console.WriteLine("\nDuration between the two dates");
            Console.WriteLine("{0} Days", datediff.TotalDays.ToString());
            Console.WriteLine("{0} Hours", datediff.TotalHours.ToString());
            Console.WriteLine("{0} Minutes", datediff.TotalMinutes.ToString());

            Console.WriteLine("\nPress any key to close.");
            Console.ReadKey();
        }
    }
}

