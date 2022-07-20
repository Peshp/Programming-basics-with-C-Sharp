using System;

namespace C71
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int space = a * b * h;
            int package = 0;
            int morespace = 0;
            string command = "";
            while (package < space)
            {
                command = Console.ReadLine();
                if(command == "Done")
                {
                    int leftspace = space - package;
                    Console.WriteLine($"{leftspace} Cubic meters left.");
                    break;
                }
                int packagespace = int.Parse(command);
                package += packagespace;
            }
            if(package >= space)
            {
                morespace = Math.Abs(space - package);
                Console.WriteLine($"No more free space! You need {morespace} Cubic meters more.");
            }           
        }
    }
}
