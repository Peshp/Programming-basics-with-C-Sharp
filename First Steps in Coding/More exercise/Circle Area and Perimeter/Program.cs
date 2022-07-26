using System;

namespace MoreC7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double P = Math.PI * r * 2;
            double S = Math.PI * r * r;
            Console.WriteLine($"{S:f2}");
            Console.WriteLine($"{P:f2}");
        }
    }
}
