using System;

namespace C74
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int b = 0;
            int result = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 25; i++)
            {              
                for (int j = 0; j <= n; j ++)
                {                                      
                    for (int h = 0; h <= n; h++)
                    {
                        result = i + j + h;                       
                        if(result == n)
                        {
                            b += 1;                            
                        }
                    }                                  
                }                           
            }
            Console.WriteLine(b);
        }
    }
}
