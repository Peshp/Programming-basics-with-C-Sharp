using System;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            double naylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            var PriceNaylon = (naylon + 2) * 1.50;
            var PricePaint = ((paint + (paint * 0.10)) * 14.50);
            var PriceThinner = thinner * 5.00;
            var PriceProducts = PriceNaylon + PricePaint + PriceThinner + 0.40;
            var PriceHours = (PriceProducts * 0.30) * hours;
            var FinalPrice = PriceProducts + PriceHours;
            Console.WriteLine(FinalPrice);
        }
    }
}
