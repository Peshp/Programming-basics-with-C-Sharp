using System;

namespace C14
{
    class Program
    {
        static void Main(string[] args)
        {
            double holiday = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int puppet = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double FinaltoyPrice = (puzzles * 2.60) + (puppet * 3) + (bear * 4.1)
                + (minion * 8.2) + (truck * 2);
            int Toys = puzzles + puppet + bear + minion + truck;
            if(Toys >= 50)
            {
                double FinalPrice = FinaltoyPrice - (FinaltoyPrice * 0.25);
                double PriceForHoliday = FinalPrice - (FinalPrice * 0.10);
                if(PriceForHoliday < holiday)
                {
                    double money = holiday - PriceForHoliday;
                    Console.WriteLine($"Not enough money! {money:F2}lv needed");
                }
                else
                {
                    double money = PriceForHoliday - holiday;
                    Console.WriteLine($"Yes! {money:F2}lv left");

                }
            }
            else
            {
                double FinalPrice = FinaltoyPrice;
                double PriceForHoliday = FinalPrice - (FinalPrice * 0.10);
                if (PriceForHoliday < holiday)
                {
                    double money = holiday - PriceForHoliday;
                    Console.WriteLine($"Not enough money! {money:F2}lv needed");
                }
                else
                {
                    double money = PriceForHoliday - holiday;
                    Console.WriteLine($"Yes! {money:F2}lv left");

                }
            }           
        }
    }
}
