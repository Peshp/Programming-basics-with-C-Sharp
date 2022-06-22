using System;

namespace C7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            var V = (a * b * h) / 1000;
            var Vpercent = percent / 100;
            var V2 = V - (V * Vpercent);
            var water = V2 * 1;
            Console.WriteLine(water);
        }
    }
}
