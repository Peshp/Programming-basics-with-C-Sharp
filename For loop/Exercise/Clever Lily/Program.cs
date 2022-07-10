using System;

namespace C51
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double DressWash = double.Parse(Console.ReadLine());
            int Toy = int.Parse(Console.ReadLine());
            int toy = 0;
            double cash = 0;
            double moneyGift = 10;

            for (int i = 1; i <= age; i++)
            {
                int reminder = i % 2;
                if(reminder == 1)
                {
                    toy++;
                }
                else
                {
                    cash += moneyGift;
                    cash -= 1;
                    moneyGift += 10;
                }
            }
            double ToysPrice = toy * Toy;
            double money = ToysPrice + cash;

            if(money >= DressWash)
            {
                double left = money - DressWash;
                Console.WriteLine($"Yes! {left:f2}");
            }
            else
            {
                double notenough = DressWash - money;
                Console.WriteLine($"No! {notenough:f2}");
            }
        }
    }
}
