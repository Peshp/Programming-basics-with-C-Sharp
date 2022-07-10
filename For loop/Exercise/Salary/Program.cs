using System;

namespace C52
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            double moneyleft = 0;
            int fine = 0;

            for (int i = 0; i < tabs; i++)
            {
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook":
                        fine = 150;
                        salary -= fine;
                        moneyleft = salary;
                        if (salary == 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                            return;
                        }
                        else
                        {
                            moneyleft -= fine;
                        }
                        break;
                    case "Instagram":
                        fine = 100;
                        salary -= fine;
                        moneyleft = salary;
                        if (salary == 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                            return;
                        }
                        else
                        {
                            moneyleft -= fine;
                        }
                        break;
                    case "Reddit":
                        fine = 50;
                        salary -= fine;
                        moneyleft = salary;
                        if (salary == 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                            return;
                        }
                        else
                        {
                            moneyleft -= fine;
                        }
                        break;                  
                }
            }
            Console.WriteLine($"{moneyleft:f0}");
        }
    }
}
