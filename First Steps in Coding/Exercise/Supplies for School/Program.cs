using System;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int deskCleaner = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            var MoneyForPencils = pencils * 5.80;
            var MoneyForMarkers = markers * 7.20;
            var MoneyForDesk = deskCleaner * 1.20;
            var discountPrice = (MoneyForPencils + MoneyForMarkers + MoneyForDesk) * (discount / 100);
            var Finalprice = (MoneyForPencils + MoneyForMarkers + MoneyForDesk) - discountPrice;
            Console.WriteLine(Finalprice);
        }
    }
}
