using System;

namespace C60
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;
            while(input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                if(amount < 0)
                {
                    Console.WriteLine("invalid operation!");                  
                    break;
                }
                balance += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
