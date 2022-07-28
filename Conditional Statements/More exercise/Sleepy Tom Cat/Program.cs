using System;

namespace MoreC11
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());     
            int WorkDays = 365 - holidays;
            double PlayHours = (WorkDays * 63) + (holidays * 127);
            double diff = 30000 - PlayHours;
            double hours = Math.Abs(diff / 60);
            double minutes = Math.Abs(diff % 60);
            if (PlayHours < 30000)
            {               
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours:f0} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours:f0} hours and {minutes:f0} minutes more for play");
            }
        }
    }
}
