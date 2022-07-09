using System;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {          
            int biggest = int.MaxValue;
            int smallest = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(smallest < num)               
                    smallest = num;                
                if(biggest > num)                
                    biggest = num;             
            }
            Console.WriteLine($"Max number: {smallest}");
            Console.WriteLine($"Min number: {biggest}");
        }
    }
}
