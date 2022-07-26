using System;

namespace MoreC5
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceFish1 = double.Parse(Console.ReadLine());
            double PriceFish2 = double.Parse(Console.ReadLine());
            double KgFish3 = double.Parse(Console.ReadLine());
            double KgFish4 = double.Parse(Console.ReadLine());
            double KgFish5 = double.Parse(Console.ReadLine());

            var Palamud = (PriceFish1 * 0.6) + PriceFish1;
            var PalamudPrice = Palamud * KgFish3;
            var Safrid = (PriceFish2 * 0.8) + PriceFish2;
            var SafridPrice = Safrid * KgFish4;
            var Midi = 7.50 * KgFish5;
            Console.WriteLine($"{(PalamudPrice + SafridPrice + Midi):f2}");
        }
    }
}
