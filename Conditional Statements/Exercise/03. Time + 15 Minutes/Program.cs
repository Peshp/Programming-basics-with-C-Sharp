using System;

namespace TryAgain1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int next = minutes + 15;

            if (next > 60)
            {
                int nexthours = hours + 1;
                int nextminutes = next - 60;
                
                if(nextminutes < 10)
                {
                    Console.WriteLine($"{nexthours}:0{nextminutes}");
                }
              else if(nexthours > 23)
                {
                    var hour = 0;
                    Console.WriteLine($"{hour}:{nextminutes}");
                }
                else
                {
                    Console.WriteLine($"{nexthours}:{nextminutes}");
                }
            }
            else
            {
                Console.WriteLine($"{hours}:{next}");
            }
        }
    }
}
