using System;

namespace C70
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grades = 0.00;
            int clase = 0;
            double average = 0;           
            while (true)
            {
                double grade = double.Parse(Console.ReadLine());
                grades += grade;
                clase += 1;
                if(grade < 4)
                {
                    Console.WriteLine($"{name} has been excluded at {clase} grade");
                    break;
                }
                if(clase == 12)
                {
                    average = grades / clase;
                    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
                    break;
                }
            }
        }
    }
}
