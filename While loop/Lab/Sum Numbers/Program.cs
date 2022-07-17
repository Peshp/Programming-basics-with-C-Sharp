using System;

namespace C58
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while(sum < num)
            {
                int othernums = int.Parse(Console.ReadLine());
                sum += othernums;
            }
            Console.WriteLine(sum);
        }
    }
}
