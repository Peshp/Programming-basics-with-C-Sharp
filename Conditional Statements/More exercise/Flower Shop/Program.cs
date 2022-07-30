using System;

namespace MoreC16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Magns = int.Parse(Console.ReadLine());
            int zumbs = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double GiftPrice = double.Parse(Console.ReadLine());

            double Price = Magns * 3.25 + zumbs * 4 + roses * 3.5 + cactus * 8;
            double danuk = Price * 0.05;
            double Money = Price - danuk;
            double left;

            if(Money >= GiftPrice)
            {
                left = Math.Floor(Money - GiftPrice);
                Console.WriteLine($"She is left with {left} leva.");
            }
            else
            {
                left = Math.Ceiling(GiftPrice - Money);
                Console.WriteLine($"She will have to borrow {left} leva.");
            }
        }
    }
}
