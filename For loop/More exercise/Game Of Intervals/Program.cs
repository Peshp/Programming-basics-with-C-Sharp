using System;

namespace MoreC31
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = int.Parse(Console.ReadLine());

            double points = 0;
            double numbers = 0;
            double numbers1 = 0;
            double numbers2 = 0;
            double numbers3 = 0;
            double numbers4 = 0;
            double numbers5 = 0;

            double p = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 0; i < turn; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num >= 0 && num <= 9)
                {
                    points += num * 0.2;
                    numbers += 1;

                }
                else if (num >= 10 && num <= 19)
                {
                    points += num * 0.3;
                    numbers1 += 1;
                }
                else if (num >= 20 && num <= 29)
                {
                    points += num * 0.4;
                    numbers2 += 1;
                }
                else if (num >= 30 && num <= 39)
                {
                    points += 50;
                    numbers3 += 1;
                }
                else if (num >= 40 && num <= 50)
                {
                    points += 100;
                    numbers4 += 1;
                }
                else
                {
                    points = points / 2;
                    numbers5 += 1;
                }               
                p = numbers / turn * 100;
                p1 = numbers1 / turn * 100;
                p2 = numbers2 / turn * 100;
                p3 = numbers3 / turn * 100;
                p4 = numbers4 / turn * 100;
                p5 = numbers5 / turn * 100;
            }                      
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {p:f2}%");
            Console.WriteLine($"From 10 to 19: {p1:f2}%");
            Console.WriteLine($"From 20 to 29: {p2:f2}%");
            Console.WriteLine($"From 30 to 39: {p3:f2}%");
            Console.WriteLine($"From 40 to 50: {p4:f2}%");
            Console.WriteLine($"Invalid numbers: {p5:f2}%");
        }
    }
}
