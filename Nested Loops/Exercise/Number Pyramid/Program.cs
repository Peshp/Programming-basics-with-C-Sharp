using System;

namespace C78
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool bigger = false;
            int current = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(current > n)
                    {
                        bigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (bigger)
                    break;
                Console.WriteLine();
            }
        }
    }
}
