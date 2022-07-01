using System;

namespace C36
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double all = 0;

            switch (symbol)
            {
                case "+":
                    all = N1 + N2;
                    if(all % 2 == 0)
                    {
                        Console.WriteLine($"{N1} + {N2} = {all} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} + {N2} = {all} - odd");
                    }
                    break;
                case "-":
                    all = N1 - N2;
                    if (all % 2 == 0)
                    {
                        Console.WriteLine($"{N1} - {N2} = {all} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} - {N2} = {all} - odd");
                    }
                    break;
                case "*":
                    all = N1 * N2;
                    if (all % 2 == 0)
                    {
                        Console.WriteLine($"{N1} * {N2} = {all} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} * {N2} = {all} - odd");
                    }
                    break;
                case "/":
                    all = N1 / N2;
                    if(N2 != 0)
                    {
                        Console.WriteLine($"{N1} / {N2} = {all:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case "%":
                    all = N1 % N2;
                    if (N2 != 0)
                    {
                        Console.WriteLine($"{N1} % {N2} = {all}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
            }
        }
    }
}
