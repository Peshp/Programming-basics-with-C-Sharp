using System;

namespace Ц32
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string DayTime = Console.ReadLine();

            if ((degree >= 10) && (degree <= 18))
            {
                switch (DayTime)
                {
                    case "Morning":
                        string Outfit = "Sweatshirt";
                        string Shoes = "Sneakers";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit} and {Shoes}");
                        break;
                    case "Afternoon":
                        string Outfit2 = "Shirt";
                        string Shoes2 = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit2} and {Shoes2}");
                        break;
                    case "Evening":
                        string Outfit3 = "Shirt";
                        string Shoes3 = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit3} and {Shoes3}");
                        break;
                }
            }
            else if ((degree > 18) && (degree <= 24))
            {
                switch (DayTime)
                {
                    case "Morning":
                        string Outfit = "Shirt";
                        string Shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit} and {Shoes}");
                        break;
                    case "Afternoon":
                        string Outfit2 = "T-Shirt";
                        string Shoes2 = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit2} and {Shoes2}");
                        break;
                    case "Evening":
                        string Outfit3 = "Shirt";
                        string Shoes3 = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit3} and {Shoes3}");
                        break;
                }
            }
            else
            {
                switch (DayTime)
                {
                    case "Morning":
                        string Outfit = "T-Shirt";
                        string Shoes = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit} and {Shoes}");
                        break;
                    case "Afternoon":
                        string Outfit2 = "Swim Suit";
                        string Shoes2 = "Barefoot";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit2} and {Shoes2}");
                        break;
                    case "Evening":
                        string Outfit3 = "Shirt";
                        string Shoes3 = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {Outfit3} and {Shoes3}");
                        break;
                }
            }
        }
    }
}
