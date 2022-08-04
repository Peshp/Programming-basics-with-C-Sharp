using System;

namespace MoreC33
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            double fans1 = 0;
            double fans2 = 0;
            double fans3 = 0;
            double fans4 = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        fans1 += 1;
                    break;
                    case "B":
                        fans2 += 1;
                    break;
                    case "V":
                        fans3 += 1;
                    break;
                    case "G":
                        fans4 += 1;
                    break;
                }
                p1 = fans1 / fans * 100;
                p2 = fans2 / fans * 100;
                p3 = fans3 / fans * 100;
                p4 = fans4 / fans * 100;
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{(fans / area * 100):f2}%");
        }
    }
}
