using System;

namespace C26
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if(city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(count * 0.5);
                        break;
                    case "water":
                        Console.WriteLine(count * 0.8);
                        break;
                    case "beer":
                        Console.WriteLine(count * 1.2);
                        break;
                    case "sweets":
                        Console.WriteLine(count * 1.45);
                        break;
                    case "peanuts":
                        Console.WriteLine(count * 1.6);
                        break;
                }
            }
            else if(city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(count * 0.4);
                        break;
                    case "water":
                        Console.WriteLine(count * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(count * 1.15);
                        break;
                    case "sweets":
                        Console.WriteLine(count * 1.3);
                        break;
                    case "peanuts":
                        Console.WriteLine(count * 1.5);
                        break;
                }
            }
            else if(city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(count * 0.45);
                        break;
                    case "water":
                        Console.WriteLine(count * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(count * 1.1);
                        break;
                    case "sweets":
                        Console.WriteLine(count * 1.35);
                        break;
                    case "peanuts":
                        Console.WriteLine(count * 1.55);
                        break;
                }
            }
        }
    }
}
