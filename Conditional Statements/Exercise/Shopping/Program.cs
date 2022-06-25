using System;

namespace C18
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int card = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int memory = int.Parse(Console.ReadLine());

            double Pricecard = card * 250;
            double Priceprocessor = processor * (Pricecard * 0.35);
            double Pricememory = memory * (Pricecard * 0.1);
            double Finalprice = Pricecard + Pricememory + Priceprocessor;

            if(card > processor)
            {
                double FinalPrice = Finalprice - (Finalprice * 0.15);
                if(budjet > FinalPrice)
                {
                    double money = budjet - FinalPrice;
                    Console.WriteLine($"You have {money:F2} leva left!");
                }
                else
                {
                    double money = FinalPrice - budjet;
                    Console.WriteLine($"Not enough money! You need {money:F2} leva more!");
                }
            }
            else
            {
                if (budjet >= Finalprice)
                {
                    double money = budjet - Finalprice;
                    Console.WriteLine($"You have {money:F2} leva left!");
                }
                else
                {
                    double money = Finalprice - budjet;
                    Console.WriteLine($"Not enough money! You need {money:F2} leva more!");
                }
            }
        }
    }
}
