using System;

namespace MoreC12
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapes = X * Y;
            double wine = 0.4 * grapes / 2.5;
            double NotEnough = Z - wine;
            double MoreWine = wine - Z;
            if(wine < Z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(NotEnough)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Floor(MoreWine)} liters left -> {Math.Floor(MoreWine / workers)} liters per person.");
            }
        }
    }
}
