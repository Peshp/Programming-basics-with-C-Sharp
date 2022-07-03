using System;

namespace C37
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double PriceStudio = 0;
            double PriceAp = 0;
            double discount = 0;
            double discountAp = 0;
            double FinalPriceSt = 0;
            double FinalPriceAp = 0;

            switch (month)
            {
                case "May":
                case "October":
                    PriceStudio = nights * 50;
                    PriceAp = 65 * nights;
                    if ((nights > 7) && (nights <= 14))
                    {                      
                        discount = PriceStudio * 0.05;
                        FinalPriceSt = PriceStudio - discount;
                     
                        FinalPriceAp = PriceAp;
                    }
                    else if (nights > 14)
                    {                      
                        discount = PriceStudio * 0.3;
                        FinalPriceSt = PriceStudio - discount;
                      
                        discountAp = PriceAp * 0.1;
                        FinalPriceAp = PriceAp - discountAp;
                    }
                    break;
                case "June":
                case "September":
                    PriceStudio = nights * 75.2;
                    PriceAp = 68.7 * nights;                  
                    if (nights > 14)
                    {                       
                        discount = PriceStudio * 0.2;
                        FinalPriceSt = PriceStudio - discount;
                       
                        discountAp = PriceAp * 0.1;
                        FinalPriceAp = PriceAp - discountAp;
                    }
                    break;
                case "July":
                case "August":
                    PriceStudio = nights * 76;
                    PriceAp = 77 * nights;                   
                    if (nights > 14)
                    {                       
                        FinalPriceSt = PriceStudio;
                      
                        discountAp = PriceAp * 0.1;
                        FinalPriceAp = PriceAp - discountAp;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {FinalPriceAp:f2}");
            Console.WriteLine($"Studio: {FinalPriceSt:f2}");
        }
    }
}
