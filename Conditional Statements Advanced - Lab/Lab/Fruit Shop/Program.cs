using System;

namespace C30
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if((day == "Monday") || (day == "Tuesday") || (day == "Wednesday") ||
                    (day == "Thursday") || (day == "Friday"))
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.5 * count);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.2 * count);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.85 * count);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.45 * count);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 2.7 * count);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.5 * count);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 3.85 * count);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if ((day == "Saturday") || (day == "Sunday"))
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.7 * count);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.25 * count);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.9 * count);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.6 * count);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 3 * count);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.6 * count);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 4.2 * count);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
