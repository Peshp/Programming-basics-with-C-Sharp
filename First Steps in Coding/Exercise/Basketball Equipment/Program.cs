using System;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFor1year = double.Parse(Console.ReadLine());
            var boots = priceFor1year - (priceFor1year * 0.40);
            var gear = boots - (boots * 0.20);
            var ball = gear / 4;
            var accessories = ball / 5;
            var FinalPrice = priceFor1year + boots + gear + ball + accessories;
            Console.WriteLine(FinalPrice);
        }
    }
}
