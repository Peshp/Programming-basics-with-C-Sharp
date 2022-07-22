using System;

namespace C76
{
    class Program
    {
        static void Main(string[] args)
        {          
            while (true)
            {
                string destination = Console.ReadLine();
                if(destination == "End")
                {
                    break;
                }

                double budjet = double.Parse(Console.ReadLine());
                double money = 0;

                while (true)
                {
                    if(money >= budjet)
                    {
                        break;
                    }
                    money += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
            }          
        }
    }
}
