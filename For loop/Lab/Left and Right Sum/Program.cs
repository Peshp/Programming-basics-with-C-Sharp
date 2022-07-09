using System;

namespace C47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());         
            var sum = 0;
            var sum2 = 0;                   
            for (int i = 0; i < n; i++)
            {                                             
                 sum += int.Parse(Console.ReadLine());                                            
            }
            for (int i = 0; i < n; i++)
            {
                sum2 += int.Parse(Console.ReadLine());
            }
            if (sum == sum2)
                Console.WriteLine("Yes, sum = " + sum);
            else
            {
                int diff = Math.Abs(sum2 - sum);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
