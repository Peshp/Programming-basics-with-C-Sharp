using System;

namespace C33
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());
            double Price = 0;
            double discount = 0;
            double FinalPrice = 0;
            double left = 0;

            switch(flower)
            {
                case "Roses":
                    if(count > 80)
                    {
                        Price = count * 5;
                        discount = Price * 0.1;
                        FinalPrice = Price - discount;
                        if(FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:F2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    else
                    {
                        Price = count * 5;
                        FinalPrice = Price;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                break;
                case "Dahlias":
                    if (count > 90)
                    {
                        Price = count * 3.8;
                        discount = Price * 0.15;
                        FinalPrice = Price - discount;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    else
                    {
                        Price = count * 3.8;
                        FinalPrice = Price;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    break;
                case "Tulips":
                    if (count > 80)
                    {
                        Price = count * 2.8;
                        discount = Price * 0.15;
                        FinalPrice = Price - discount;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    else
                    {
                        Price = count * 2.8;
                        FinalPrice = Price;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    break;
                case "Narcissus":
                    if (count < 120)
                    {
                        Price = count * 3;
                        discount = Price * 0.15;
                        FinalPrice = Price + discount;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    else
                    {
                        Price = count * 3;
                        FinalPrice = Price;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    break;
                case "Gladiolus":
                    if (count < 80)
                    {
                        Price = count * 2.50;
                        discount = Price * 0.2;
                        FinalPrice = Price + discount;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    else
                    {
                        Price = count * 2.50;
                        FinalPrice = Price;
                        if (FinalPrice > budjet)
                        {
                            left = FinalPrice - budjet;
                            Console.WriteLine($"Not enough money, you need {left:f2} leva more.");
                        }
                        else
                        {
                            left = budjet - FinalPrice;
                            Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {left:f2} leva left.");
                        }
                    }
                    break;
            }
        }
    }
}
