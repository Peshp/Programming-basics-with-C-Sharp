using System;

namespace _6April2019
{
    class Program
    {
        static void Main(string[] args)
        {

            double students = 0;
            double studentsTickets = 0;
            double standards = 0;
            double standartTickets = 0;
            double kids = 0;
            double kidsTickets = 0;
            double totaltickets = 0;           
            double percentplaces = 0;           
            string end = "";
            string movie = "";
            double Allkids = 0;
            double Allstudents = 0;
            double Allstandarts = 0;
            double places = 0;
            double freeplaces = 0;
            while (true)
            {
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                freeplaces = double.Parse(Console.ReadLine());                           

                while (freeplaces != places)
                {
                    end = Console.ReadLine();
                    if (end == "End")
                    {
                        break;                      
                    }
                    totaltickets++;
                    switch (end)
                    {
                        case "student":
                            students++;
                            Allstudents += 1;
                            break;
                        case "standard":
                            standards++;
                            Allstandarts += 1;
                            break;
                        case "kid":
                            kids++;
                            Allkids += 1;
                            break;
                    }
                    places = students + standards + kids;
                    percentplaces = places / freeplaces * 100;                                                        
                }              
                Console.WriteLine($"{movie} - {percentplaces:f2}% full.");               
                places = 0;
                students = 0;
                standards = 0;
                kids = 0;
            }         
            studentsTickets = Allstudents / totaltickets * 100;
            standartTickets = Allstandarts / totaltickets * 100;
            kidsTickets = Allkids / totaltickets * 100;
                      
            

            if (movie == "Finish")
            {
                Console.WriteLine($"Total tickets: {totaltickets}");
                Console.WriteLine($"{studentsTickets:f2}% student tickets.");
                Console.WriteLine($"{standartTickets:f2}% standart tickets.");
                Console.WriteLine($"{kidsTickets:f2}% kids tickets.");
            }            
        }
    }
}
