using System;

namespace MoreC4
{
    class Program
    {
        static void Main(string[] args)
        {
            double VegPrice = double.Parse(Console.ReadLine());
            double FruPrice = double.Parse(Console.ReadLine());
            double VegFullPrice = double.Parse(Console.ReadLine());
            double FruFullPrice = double.Parse(Console.ReadLine());

            var FinalPriceVeg = VegPrice * VegFullPrice;
            var FinalPriceFru = FruPrice * FruFullPrice;
            Console.WriteLine($"{((FinalPriceVeg + FinalPriceFru) / 1.94):f2}");
        }
    }
}
