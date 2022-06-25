using System;

namespace C20
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameSeries = Console.ReadLine();
            int TimeEpisode = int.Parse(Console.ReadLine());
            int TimeBreak = int.Parse(Console.ReadLine());

            double lunch = TimeBreak * 0.125;
            double series = TimeBreak * 0.25;
            double Time = TimeBreak - (lunch + series);       

            if(Time >= TimeEpisode)
            {            
                Console.WriteLine($"You have enough time to watch {NameSeries} and left with " +
                    $"{Math.Ceiling(Time - TimeEpisode)} minutes free time.");
            }
            else
            {               
                Console.WriteLine($"You don't have enough time to watch {NameSeries}, you need " +
                    $"{Math.Ceiling(TimeEpisode - Time)} more minutes.");
            }
        }
    }
}
