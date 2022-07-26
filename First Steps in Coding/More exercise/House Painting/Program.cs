using System;

namespace MoreC6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double walls = (x * x) * 2;
            double door = 1.2 * 2;
            double sidewalls = (x * y) * 2;
            double window = (1.5 * 1.5) * 2;
            double roof = (x * y) * 2;
            double triangles = ((x * h) / 2) * 2;
            double FinalRoof = roof + triangles;
            double FinalWalls = (walls - door) + (sidewalls - window);

            double green = FinalWalls / 3.4;
            double red = FinalRoof / 4.3;
            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");
        }
    }
}
