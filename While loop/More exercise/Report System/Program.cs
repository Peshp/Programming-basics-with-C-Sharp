using System;

namespace More36
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            double money = 0.00;
            string end = "";
            double card = 0.00;
            double transwithcard = 0.00;
            double transwithcash = 0.00;
            double cash = 0.00;
            double position = 0.00;
            double averageCS = 0.00;
            double averageCC = 0.00;
            while(sum >= money)
            {
                end = Console.ReadLine();
                if(end == "End")
                {
                    break;
                }
                int products = int.Parse(end);
                position++;
                if(position % 2 == 0)
                {
                    if(products > 100)
                    {
                        Console.WriteLine("Product sold!");
                        money += products;
                        card += products;
                        transwithcard++;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if(products <= 100)
                    {
                        Console.WriteLine("Product sold!");
                        money += products;
                        cash += products;
                        transwithcash++;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }              
            }
            averageCS = cash / transwithcash;
            averageCC = card / transwithcard;
            if (sum > money)
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {averageCS:f2}");
                Console.WriteLine($"Average CC: {averageCC:f2}");
            }
        }
    }
}
