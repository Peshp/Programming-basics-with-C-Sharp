using System;

namespace MoreC15
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int Foodkg = int.Parse(Console.ReadLine());
            double FoodDog = double.Parse(Console.ReadLine());
            double FoodCat = double.Parse(Console.ReadLine());
            double FoodTurt = double.Parse(Console.ReadLine());

            double turt = FoodTurt / 1000;

            double Dog = FoodDog * days;
            double Cat = FoodCat * days;
            double Turtle = turt * days;
            double AllFood = Dog + Cat + Turtle;         
            double left = 0;

            if(AllFood < Foodkg)
            {
                left = Math.Floor(Foodkg - AllFood);
                Console.WriteLine($"{Math.Abs(left):f0} kilos of food left.");
            }
            else
            {
                left = Math.Ceiling(AllFood - Foodkg);
                Console.WriteLine($"{Math.Abs(left):f0} more kilos of food are needed.");
            }
        }
    }
}
