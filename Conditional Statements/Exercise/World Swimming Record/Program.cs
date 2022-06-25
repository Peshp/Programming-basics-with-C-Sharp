using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sec = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double water = Math.Floor(m / 15);
            double Delay = water * 12.5;
            double timeToSwim = (m * time) + Delay;           
            if(sec <= timeToSwim)
            {
                double seconds = timeToSwim - sec;
                Console.WriteLine($"No, he failed! He was {seconds:F2} seconds slower.");
            }
            else
            {               
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeToSwim:F2} seconds.");
            }
        }
    }
}
