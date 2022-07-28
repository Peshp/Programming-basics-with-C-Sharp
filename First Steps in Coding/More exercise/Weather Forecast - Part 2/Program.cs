using System;

namespace MoreC9
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = double.Parse(Console.ReadLine());
            if((grades >= 5) && (grades <= 11.9))
            {
                Console.WriteLine("Cold");
            }
            else if ((grades >= 12) && (grades <= 14.9))
            {
                Console.WriteLine("Cool");
            }
            else if ((grades >= 15) && (grades <= 20))
            {
                Console.WriteLine("Mild");
            }
            else if ((grades >= 20.1) && (grades <= 25.9))
            {
                Console.WriteLine("Warm");
            }
            else if ((grades >= 26) && (grades <= 35))
            {
                Console.WriteLine("Hot");
            }
            else 
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
