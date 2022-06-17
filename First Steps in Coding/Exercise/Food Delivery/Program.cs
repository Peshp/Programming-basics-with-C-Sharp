using System;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());
            var Price = (chicken * 10.35) + (fish * 12.40) + (vegan * 8.15);
            var desert = Price * 0.20;
            var takeaway = Price + desert + 2.50;
            Console.WriteLine(takeaway);
        }
    }
}
