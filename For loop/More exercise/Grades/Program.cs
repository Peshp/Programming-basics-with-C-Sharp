using System;

namespace MoreC29
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double top = 0;
            double two = 0;
            double three = 0;
            double four = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;

            double sum = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                if(grade >= 5.00)
                {
                    top += 1;                  
                }
                else if(grade >= 2.00 && grade <= 2.99)
                {
                    two += 1;                 
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    three += 1;                  
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    four += 1;                 
                }
                 p1 = (top / students) * 100;
                 p2 = (two / students) * 100;
                 p3 = (three / students) * 100;
                 p4 = (four / students) * 100;
            }
            double average = sum / students;

            Console.WriteLine($"Top students: {1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {p4:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {p3:f2}%");
            Console.WriteLine($"Fail: {p2:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
