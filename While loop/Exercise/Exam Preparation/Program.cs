using System;

namespace C65
{
    class Program
    {
        static void Main(string[] args)
        {
            int numgrade = int.Parse(Console.ReadLine());
            bool enough = false;
            double grades = 0;
            double gradesum = 0;
            int exams = 0;
            string lastproblem = "";
            int badgrades = 0;
            double average = 0;
            while (true)
            {
                string examname = Console.ReadLine();
                grades++;              
                if(examname == "Enough")
                {
                    enough = true;
                    break;
                }              
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badgrades++;
                    if(badgrades == numgrade)
                    {
                        break;
                    }
                }
                gradesum += grade;                
                exams++;
                lastproblem = examname;
                average = gradesum / grades;
            }           
            if(enough)
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {exams}");
                Console.WriteLine($"Last problem: {lastproblem}");
            }
            else if(badgrades == numgrade)
            {
                Console.WriteLine($"You need a break, {badgrades} poor grades."); 
            }
        }
    }
}
