using System;

namespace MoreC3
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            var F = (C * 1.8) + 32;
            Console.WriteLine($"{F:f2}");
        }
    }
}
