using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            int detergent = bottles * 750;
            string income = string.Empty;
            int dishes = 0;
            int pots = 0;
            int count = 0;


            while (0 <= detergent)
            {
                income = Console.ReadLine();
                if (income == "End")
                {
                    break;
                }

                count++;

                if (count % 3 == 0)
                {
                    pots += int.Parse(income);
                    detergent -= int.Parse(income) * 15;
                }
                else
                {
                    dishes += int.Parse(income);
                    detergent -= int.Parse(income) * 5;
                }              
            }

            if (detergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
            }
        }
    }
}
