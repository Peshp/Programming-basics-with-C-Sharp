using System;

namespace C50
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumNum = 0;
            double sumNum2 = 0;
            double sumNum3 = 0;
            double sumNum4 = 0;
            double sumNum5 = 0;
 
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;  
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num < 200)
                {
                    num = 1;
                    sumNum += num;                   
                    p1 = sumNum / n * 100;                 
                }
                else if((num >= 200) && (num <= 399))
                {
                    num = 1;
                    sumNum2 += num;
                    p2 = sumNum2 / n * 100;
                }
                else if ((num >= 400) && (num <= 599))
                {
                    num = 1;
                    sumNum3 += num;
                    p3 = sumNum3 / n * 100;
                }
                else if ((num >= 600) && (num <= 799))
                {
                    num = 1;
                    sumNum4 += num;
                    p4 = sumNum4 / n * 100;
                }
                else
                {
                    num = 1;
                    sumNum5 += num;
                    p5 = sumNum5 / n * 100;
                }
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
