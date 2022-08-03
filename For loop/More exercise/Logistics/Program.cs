using System;

namespace MoreC28
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double sum = 0;
            double average = 0.00;           
            double microbus = 0.00;
            double truck = 0.00;
            double train = 0.00;
            double Microbusprice = 0.00;
            double Trainprice = 0.00;
            double Truckprice = 0.00;
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            int tons = 0;

            for (int i = 0; i < count; i++)
            {
                tons = int.Parse(Console.ReadLine());
                sum += tons;               

                if(tons <= 3)
                {
                    microbus += tons;
                    Microbusprice = microbus * 200;                  
                }
                else if ((tons > 3 && tons < 12))
                {
                    truck += tons;
                    Truckprice = truck * 175;                
                }
                else
                {
                    train += tons;
                    Trainprice = train * 120;               
                }                
                average = (Microbusprice + Truckprice + Trainprice) / sum;               
            }
            p1 = (microbus / sum) * 100;
            p2 = (truck / sum) * 100;
            p3 = (train / sum) * 100;

            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
