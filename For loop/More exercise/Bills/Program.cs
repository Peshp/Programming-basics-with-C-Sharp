using System;

namespace MoreC32
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double elPrice = 0.00;
            double waterPrice = 0.00;
            double netPrice = 0.00;
            double otherPrice = 0.00;
            double average = 0.00;

            for (int i = 0; i < months; i++)
            {
                double el = double.Parse(Console.ReadLine());

                elPrice += el;
                waterPrice = months * 20;
                netPrice = months * 15;
                otherPrice = (elPrice + waterPrice + netPrice) * 0.2 + (elPrice + waterPrice + netPrice);
                average = (elPrice + waterPrice + netPrice + otherPrice) / months;
            }
            Console.WriteLine($"Electricity: {elPrice:f2} lv");
            Console.WriteLine($"Water: {waterPrice:f2} lv");
            Console.WriteLine($"Internet: {netPrice:f2} lv");
            Console.WriteLine($"Other: {otherPrice:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
