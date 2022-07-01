using System;

namespace C35
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double Price = 0;

            if(budjet <= 100)
            {
                switch (season)
                {
                    case "summer":
                        Price = budjet * 0.3;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Camp – {Price:f2}");
                        break;
                    case "winter":
                        Price = budjet * 0.7;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel – {Price:f2}");
                        break;
                }              
            }
            else if((budjet <= 1000) && (budjet > 100))
            {
                switch (season)
                {
                    case "summer":
                        Price = budjet * 0.4;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Camp – {Price:f2}");
                        break;
                    case "winter":
                        Price = budjet * 0.8;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Hotel – {Price:f2}");
                        break;
                }
            }           
            else
            {
                Price = budjet * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {Price:f2}");
            }
        }
    }
}
