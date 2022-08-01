using System;

namespace MoreC24
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());

            double price = 0.00;          

            if(km < 5001)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        price = 0.75 * km * 4;
                        break;
                    case "Summer":
                        price = 0.9 * km * 4;
                        break;
                    case "Winter":
                        price = 1.05 * km * 4;
                        break;
                }
            }
            else if (km < 10001 && km > 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        price = 0.95 * km * 4;
                        break;
                    case "Summer":
                        price = 1.1 * km * 4;
                        break;
                    case "Winter":
                        price = 1.25 * km * 4;
                        break;
                }
            }
            else if (km < 20001 && km > 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":                      
                    case "Summer":                    
                    case "Winter":
                        price = 1.45 * km * 4;
                        break;
                }
            }
            price -= price * 0.1;
            Console.WriteLine($"{price:f2}");
        }
    }
}
