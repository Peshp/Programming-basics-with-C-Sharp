using System;

namespace C80
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());            
            double avpresentation = 0;
            double allgrades = 0;
            double grades = 0;
            double grade = 0;
            while (true)
            {
                string presentation = Console.ReadLine();
                if(presentation == "Finish")
                {
                    break;
                }
                
                double avgrades = 0;              
                for (int i = 0; i < jury; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                    grades += 1;
                    
                }
                avgrades = grade / jury;
                allgrades += grade;
                Console.WriteLine($"{presentation} - {avgrades:f2}.");
                grade = 0;
            }
            avpresentation = allgrades / grades;
            Console.WriteLine($"Student's final assessment is {avpresentation:f2}.");
        }
    }
}
