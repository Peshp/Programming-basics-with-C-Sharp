using System;

namespace C69
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double cake = a * b;           
            double left = 0;
            double pieces = 0;
            string stop = "";
            while (pieces < cake)
            {
                stop = Console.ReadLine();
                if(stop == "STOP")
                {
                    left = cake - pieces;
                    Console.WriteLine($"{left} pieces are left.");
                    break;
                }
                int get = int.Parse(stop);
                pieces += get;                                                               
            }
            if(pieces > cake)
            {
                left = Math.Abs(cake - pieces);
                Console.WriteLine($"No more cake left! You need {left} pieces more.");
            }          
        }
    }
}
