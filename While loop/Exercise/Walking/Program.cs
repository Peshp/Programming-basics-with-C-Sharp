using System;

namespace C67
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 10000;
            int totalsteps = 0;
            string command = "";

            while (totalsteps < steps)
            {                               
                command = Console.ReadLine();
                if(command == "Going home")
                {
                    int laststeps = int.Parse(Console.ReadLine());
                    totalsteps += laststeps;
                    break;
                }
                int dailysteps = int.Parse(command);
                totalsteps += dailysteps;
            }
            if(totalsteps >= steps)
            {
                Console.WriteLine("Goal reached! Good job!");
                int stepsleft = totalsteps - steps;
                Console.WriteLine($"{stepsleft} steps over the goal!");
            }
            else
            {
                int moresteps = steps - totalsteps;
                Console.WriteLine($"{moresteps} more steps to reach goal.");
            }
        }
    }
}
