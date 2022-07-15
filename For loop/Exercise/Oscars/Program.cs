using System;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int rate = int.Parse(Console.ReadLine());

            double Finalpoints = points;

            bool PointsForWin = false;

            for (int i = 0; i < rate; i++)
            {
                string rateName = Console.ReadLine();
                double ratePoints = double.Parse(Console.ReadLine());

                double Jurypoints = rateName.Length * ratePoints / 2;
                Finalpoints += Jurypoints;

                if (Finalpoints > 1250.5)
                {
                    PointsForWin = true;                
                    break;
                }
            }           
            if(PointsForWin)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {Finalpoints:f1}!");
            }
            else
            {
                double LeftPoints = 1250.5 - Finalpoints;
                Console.WriteLine($"Sorry, {actor} you need {LeftPoints} more!");
            }
        }
    }
}
