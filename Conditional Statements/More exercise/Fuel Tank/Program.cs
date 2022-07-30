using System;

namespace MoreC17
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litres = int.Parse(Console.ReadLine());

            if(litres >= 25)
            {
                switch (fuel)
                {
                    case "Diesel":
                        Console.WriteLine("You have enough diesel.");
                        break;
                    case "Gasoline":
                        Console.WriteLine("You have enough gasoline.");
                        break;
                    case "Gas":
                        Console.WriteLine("You have enough gas.");
                        break;
                    default:
                        Console.WriteLine("Invalid fuel!");
                        break;
                }
                
            }
            else
            {
                switch(fuel)
                {
                    case "Diesel":
                        Console.WriteLine("Fill your tank with diesel!");
                        break;
                    case "Gasoline":
                        Console.WriteLine("Fill your tank with gasoline!");
                        break;
                    case "Gas":
                        Console.WriteLine("Fill your tank with gas!");
                        break;
                    default:
                        Console.WriteLine("Invalid fuel!");
                        break;
                }              
            }
        }
    }
}
