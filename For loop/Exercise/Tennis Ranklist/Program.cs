using System;

namespace C55
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            double Morepoints = 0;
            double winnings = 0;        

            for (int i = 0; i < tournaments; i++)
            {
                string grade = Console.ReadLine();

                switch (grade)
                {
                    case "W":
                        points += 2000;
                        Morepoints += 2000;
                        winnings += 1;      
                        break;
                    case "F":
                        points += 1200;
                        Morepoints += 1200;
                        break;
                    case "SF":
                        points += 720;
                        Morepoints += 720;
                        break;
                }
            }
            double AveragePoints = Morepoints / tournaments;
            double PercentWinnings = (winnings / tournaments) * 100;

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(AveragePoints)}");
            Console.WriteLine($"{PercentWinnings:f2}%");
        }
    }
}
