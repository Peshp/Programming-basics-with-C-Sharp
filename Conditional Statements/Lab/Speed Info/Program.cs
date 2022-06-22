using System;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            if(V <= 10)
            {
                Console.WriteLine("slow");
            }
            else if((V > 10) && (V <= 50))
            {
                Console.WriteLine("average");
            }
            else if((V > 50) && (V <= 150))
            {
                Console.WriteLine("fast");
            }
            else if ((V > 150) && (V <= 1000))
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
