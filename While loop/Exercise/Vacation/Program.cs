using System;

namespace C66
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidaymoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int days = 0;
            int spenddays = 0;
            while (true)
            {
                string doing = Console.ReadLine();
                double doingmoney = double.Parse(Console.ReadLine());
                if (doing == "spend")
                {
                    money -= doingmoney;
                    if(money <= 0)
                    {
                        money = 0;
                    }
                    spenddays++;
                }                
                else if(doing == "save")
                {
                    money += doingmoney;
                }
                days++;
                if (spenddays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
                else if (money >= holidaymoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }          
        }
    }
}
