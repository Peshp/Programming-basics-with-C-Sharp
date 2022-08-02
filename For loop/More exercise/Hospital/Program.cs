using System;

namespace MoreC27
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treated = 0;
            int untreated = 0;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if((i % 3 == 0) && (untreated > treated))
                {
                    doctors += 1;
                }
                if(patients > doctors)
                {
                    treated += doctors;
                    untreated += patients - doctors; 
                }
                else
                {
                    treated += patients;
                }
            }
            Console.WriteLine($"Treated patients: {treated}");
            Console.WriteLine($"Untreated patients: {untreated}");
        }
    }
}
