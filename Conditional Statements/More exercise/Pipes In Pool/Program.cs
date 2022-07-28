using System;

namespace MoreC10
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double Pipe1 = H * P1;
            double Pipe2 = H * P2;           
            double Pool = Pipe1 + Pipe2;
            if(Pool < V)
            {
                double percentsPool = Pool / V * 100;
                double percentP1 = Pipe1 / Pool * 100;
                double percent2 = Pipe2 / Pool * 100;               
                Console.WriteLine($"The pool is {percentsPool:f2}% full. " +
                    $"Pipe 1: {percentP1:f2}%. Pipe 2: {Math.Round(percent2, 2)}%.");
            }
            else
            {
                double liters = Pool - V;
                Console.WriteLine($"For {H:f2} hours the pool overflows with {liters:f2} liters.");
            }
        }
    }
}
