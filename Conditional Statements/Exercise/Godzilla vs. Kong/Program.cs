using System;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double Price = double.Parse(Console.ReadLine());

            double decor = budjet * 0.10;
            double costums = Price * people;
            double EvrPrice = decor + costums;          
            if(people > 150)
            {
                double Pricecostums = costums - (costums * 0.10);
                double FinalPrice = Pricecostums + decor;
                if(FinalPrice > budjet)
                {
                    double left = FinalPrice - budjet;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {left:F2}leva more");
                }
                else
                {
                    double money = budjet - FinalPrice;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {money:F2} leva left");
                }
            }
            else
            {
                if (EvrPrice > budjet)
                {
                    double left = EvrPrice - budjet;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {left:F2}leva more");
                }
                else
                {
                    double money = budjet - EvrPrice;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {money:F2} leva left");
                }
            }
        }
    }
}
