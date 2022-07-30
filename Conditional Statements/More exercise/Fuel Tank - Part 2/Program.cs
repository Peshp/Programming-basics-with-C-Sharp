using System;

namespace MoreC18
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litres = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double PriceGasoline = 0;
            double PriceDiesel = 0;
            double PriceGas = 0;

            if(card == "Yes")
            {               
                switch(fuel)
                {
                    case "Gasoline":
                        PriceGasoline = (2.22 - 0.18) * litres;
                        break;
                    case "Diesel":
                        PriceDiesel = (2.33 - 0.12) * litres;
                        break;
                    case "Gas":
                        PriceGas = (0.93 - 0.08) * litres;
                        break;
                }
            }
            else
            {
                switch(fuel)
                {
                    case "Gasoline":
                        PriceGasoline = 2.22 * litres;
                        break;
                    case "Diesel":
                        PriceDiesel = 2.33 * litres;
                        break;
                    case "Gas":
                        PriceGas = 0.93 * litres;
                        break;
                }
            }

            if((litres >= 20) && (litres <= 25))
            {
                PriceGasoline = PriceGasoline - (PriceGasoline * 0.08);
                PriceDiesel = PriceDiesel - (PriceDiesel * 0.08);
                PriceGas = PriceGas - (PriceGas * 0.08);
            }
            else if(litres > 25)
            {
                PriceGasoline = PriceGasoline - (PriceGasoline * 0.1);
                PriceDiesel = PriceDiesel - (PriceDiesel * 0.1);
                PriceGas = PriceGas - (PriceGas * 0.1);
            }

            switch(fuel)
            {
                case "Gasoline":
                    Console.WriteLine($"{PriceGasoline:f2} lv.");
                    break;
                case "Diesel":
                    Console.WriteLine($"{PriceDiesel:f2} lv.");
                    break;
                case "Gas":
                    Console.WriteLine($"{PriceGas:f2} lv.");
                    break;
            }
        }
    }
}
