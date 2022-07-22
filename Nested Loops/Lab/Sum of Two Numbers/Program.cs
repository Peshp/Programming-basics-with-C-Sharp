using System;

namespace C75
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());
            int result = 0;
            int magicnum = 0;
            int d = 0;
            int c = 0;
            bool found = false;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    result = j + i;
                    magicnum++;
                    if (result == magical)
                    {                      
                        d = i;
                        c = j;
                        Console.WriteLine($"Combination N:{magicnum} ({d} + {c} = {result})");
                        found = true;
                        break;
                    }                                    
                }
                if (found)
                    break;
            } 
            if(found == false)
            {
                Console.WriteLine($"{magicnum} combinations - neither equals {magical}");
            }
        }
    }
}
