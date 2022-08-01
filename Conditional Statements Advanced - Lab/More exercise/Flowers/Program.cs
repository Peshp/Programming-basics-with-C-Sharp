using System;

namespace MoreC21
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizant = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();

            double Pricehrizant = 0;
            double Priceroses = 0;
            double Pricetulip = 0;
            int Allflowers = hrizant + roses + tulip;
            double AllPrice = 0;

            switch (season)
            {
                case "Summer":                  
                case "Spring":
                    Pricehrizant = hrizant * 2;
                    Priceroses = roses * 4.1;
                    Pricetulip = tulip * 2.5;                 
                    break;               
                case "Autumn":                  
                case "Winter":
                    Pricehrizant = hrizant * 3.75;
                    Priceroses = roses * 4.5;
                    Pricetulip = tulip * 4.15;
                    break;
            }
            AllPrice = Pricehrizant + Priceroses + Pricetulip;

            if(season == "Spring" && tulip > 7)
            {
                AllPrice -= AllPrice * 0.05;
            }
            if(season == "Winter" && roses > 7)
            {
                AllPrice -= AllPrice * 0.1;
            }
            if(Allflowers > 20)
            {
                AllPrice -= AllPrice * 0.2;
            }

            if(day == "Y")
            {
                AllPrice += AllPrice * 0.15;
            }

            double FinalPrice = AllPrice + 2;
            Console.WriteLine($"{FinalPrice:f2}");
        }
    }
}
