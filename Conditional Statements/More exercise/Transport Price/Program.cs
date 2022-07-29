using System;

namespace MoreC13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxi = 0;
            double bus = 0.09;
            double train = 0.06;
         
            if(n < 20)
            {
                switch (time)
                {
                    case "day":
                        taxi = (0.79 * n) + 0.70;
                        break;
                    case "night":
                        taxi = (0.90 * n) + 0.70;
                        break;                  
                }
                Console.WriteLine($"{taxi:f2}");
            }
            else if((n >= 20) && (n < 100))
            {
                bus *= n;
                Console.WriteLine($"{bus:f2}");
            }
            else
            {
                train *= n;
                Console.WriteLine($"{train:f2}");
            }          
        }
    }
}
