using System;

namespace MoreC25
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0.00;
            string sport = "zed";

            switch (season)
            {
                case "Winter":                    
                    if(group == "boys")
                    {
                        sport = "Judo";
                        price = 9.6 * nights * students;
                    }
                    else if(group == "girls")
                    {
                        sport = "Gymnastic";
                        price = 9.6 * nights * students;
                    }
                    else if (group == "mixed")
                    {
                        sport = "Ski";
                        price = 10 * nights * students;
                    }
                    break;
                case "Spring":
                    if (group == "boys")
                    {
                        sport = "Tennis";
                        price = 7.2 * nights * students;
                    }
                    else if (group == "girls")
                    {
                        sport = "Athletics";
                        price = 7.2 * nights * students;
                    }
                    else if (group == "mixed")
                    {
                        sport = "Cycling";
                        price = 9.5 * nights * students;
                    }
                    break;
                case "Summer":
                    if(group == "boys")
                    {
                        sport = "Football";
                        price = 15 * nights * students;                                                                           
                    }
                    else if (group == "girls")
                    {
                        sport = "Volleyball";
                        price = 15 * nights * students;
                    }
                    else if(group == "mixed")
                    {
                        sport = "Swimming";
                        price = 20 * nights * students;
                    }
                    break;
            }

            if(students >= 50)
            {
                price -= price * 0.5;
            }
            else if(students >= 20 && students < 50)
            {
                price -= price * 0.15;
            }
            else if (students >= 10 && students < 20)
            {
                price -= price * 0.05;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
