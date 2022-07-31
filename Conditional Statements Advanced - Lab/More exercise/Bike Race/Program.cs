using System;

namespace MoreC20
{
    class Program
    {
        static void Main(string[] args)
        {
            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string road = Console.ReadLine();

            double juniorPrice = 0;
            double seniorPrice = 0;

            switch(road)
            {
                case "trail":
                    juniorPrice = junior * 5.5;
                    seniorPrice = senior * 7;
                    break;
                case "cross-country":
                    juniorPrice = junior * 8;
                    seniorPrice = senior * 9.5;
                    if(junior + senior >= 50)
                    {
                        juniorPrice -= juniorPrice * 0.25;
                        seniorPrice -= seniorPrice * 0.25;
                    }
                    break;
                case "downhill":
                    juniorPrice = junior * 12.25;
                    seniorPrice = senior * 13.75;
                    break;
                case "road":
                    juniorPrice = junior * 20;
                    seniorPrice = senior * 21.5;
                    break;
            }
            double AllPrices = juniorPrice + seniorPrice;
            double FinalPrice = AllPrices - (AllPrices * 0.05);
            Console.WriteLine($"{FinalPrice:f2}");
        }
    }
}
