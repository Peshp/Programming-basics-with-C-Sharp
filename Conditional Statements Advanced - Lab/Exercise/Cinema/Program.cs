using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cinema = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int coloumn = int.Parse(Console.ReadLine());

            double income = 0;
            
            if(cinema == "Premiere")
            {
                income = rows * coloumn * 12.00;
            }
            else if(cinema == "Normal")
            {
                income = rows * coloumn * 7.50;
            }
            else if (cinema == "Discount")
            {
                income = rows * coloumn * 5.00;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
