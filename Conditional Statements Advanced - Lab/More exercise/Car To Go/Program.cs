using System;

namespace MoreC22
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double Price = 0;         
            string car = "kola";

            if(budjet < 101)
            {
                switch(season)
                {
                    case "Summer":
                        Price = budjet * 0.35;
                        car = "Cabrio";
                        break;
                    case "Winter":
                        Price = budjet * 0.65;
                        car = "Jeep";
                        break;
                }
                Console.WriteLine("Economy class");
                Console.WriteLine($"{car} - {Price:f2}");
            }
            else if (budjet > 100 && budjet < 501)
            {
                switch (season)
                {
                    case "Summer":
                        Price = budjet * 0.45;
                        car = "Cabrio";
                        break;
                    case "Winter":
                        Price = budjet * 0.8;
                        car = "Jeep";
                        break;
                }
                Console.WriteLine("Compact class");
                Console.WriteLine($"{car} - {Price:f2}");
            }
            else
            {
                switch (season)
                {
                    case "Summer":                      
                    case "Winter":
                        Price = budjet * 0.9;
                        car = "Jeep";
                        break;
                }
                Console.WriteLine("Luxury class");
                Console.WriteLine($"{car} - {Price:f2}");
            }
        }
    }
}
