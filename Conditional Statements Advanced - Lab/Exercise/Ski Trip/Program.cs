using System;

namespace C39
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double Room = nights * 18;
            double apartment = nights * 25;
            double PApartment = nights * 35;
            double Price = 0;
            double discount = 0.00;
            double FinalPrice = 0.00;

            switch (room)
            {
                case "room for one person":
                    Price = Room;
                    break;
                case "apartment":
                    if(days < 10)
                    {
                        discount = apartment * 0.3;
                        Price = apartment - discount;
                    }
                    else if((days >= 10) && (days <= 15))
                    {
                        discount = apartment * 0.35;
                        Price = apartment - discount;
                    }
                    else if(days > 15)
                    {
                        discount = apartment * 0.5;
                        Price = apartment - discount;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        discount = PApartment * 0.1;
                        Price = PApartment - discount;
                    }
                    else if ((days >= 10) && (days <= 15))
                    {
                        discount = PApartment * 0.15;
                        Price = PApartment - discount;
                    }
                    else if (days > 15)
                    {
                        discount = PApartment * 0.2;
                        Price = PApartment - discount;
                    }
                    break;
            }
            switch (grade)
            {
                case "positive":
                    FinalPrice = (Price * 0.25) + Price;
                    Console.WriteLine($"{FinalPrice:f2}");
                    break;
                case "negative":
                    FinalPrice = Price - (Price * 0.1);
                    Console.WriteLine($"{FinalPrice:f2}");
                    break;
            }
        }
    }
}
