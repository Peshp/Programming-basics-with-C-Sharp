using System;

namespace MoreC19
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double transport = 0.00;
            double ticket = 0.00;

            if((people > 0) && (people < 5))
            {
                transport = budjet * 0.75;
            }
            else if((people > 4) && (people < 10))
            {
                transport = budjet * 0.6;
            }
            else if ((people > 9) && (people < 25))
            {
                transport = budjet * 0.5;
            }
            else if ((people > 24) && (people < 50))
            {
                transport = budjet * 0.4;
            }
            else
            {
                transport = budjet * 0.25;
            }         

            switch(category)
            {
                case "VIP":
                    ticket = people * 499.99;
                    break;
                case "Normal":
                    ticket = people * 249.99;
                    break;
            }

            double Allprices = ticket + transport;
            double moneyleft = 0.00;
            
            if(budjet >= Allprices)
            {
                moneyleft = budjet - Allprices;
                Console.WriteLine($"Yes! You have {moneyleft:f2} leva left.");
            }
            else
            {
                moneyleft = Allprices - budjet;
                Console.WriteLine($"Not enough money! You need {moneyleft:f2} leva");
            }
        }
    }
}
