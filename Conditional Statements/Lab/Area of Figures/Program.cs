using System;

namespace proverki5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a figure? square, rectangle, circle, triangle, trapec, parallelepiped, cube");
                string figure = Console.ReadLine();
                double a = 0;
                double b = 0;
                double h = 0;
                double r = 0;
                double cos = 0;
                double c = 0;
                double area = 0;
                switch (figure)
                {
                    case "square":
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        area = a * a;
                        Console.Write("Square area = ");
                        Console.WriteLine(Math.Round(area, 3));
                        break;
                    case "rectangle":
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = double.Parse(Console.ReadLine());
                        area = a * b;
                        Console.Write("Rectangle area = ");
                        Console.WriteLine(Math.Round(area, 2));
                        break;
                    case "circle":
                        Console.Write("r = ");
                        r = double.Parse(Console.ReadLine());
                        area = Math.PI * r * r;
                        Console.Write("Circle area = ");
                        Console.WriteLine(Math.Round(area, 2));
                        break;
                    case "triangle":
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("h = ");
                        h = double.Parse(Console.ReadLine());
                        area = a * h / 2;
                        Console.Write("Triangle area = ");
                        Console.WriteLine(Math.Round(area, 2));
                        break;
                    case "trapec":
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("h = ");
                        h = double.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = double.Parse(Console.ReadLine());
                        area = a + b / 2 * h;
                        Console.Write("Trapec area = ");
                        Console.WriteLine(Math.Round(area, 2));
                        break;
                    case "parallelepiped":
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("h = ");
                        h = double.Parse(Console.ReadLine());
                        area = a * b * h;
                        Console.Write("parallelepiped area = ");
                        Console.WriteLine(Math.Round(area, 2));
                        break;
                    case "cube":
                        Console.Write("a = ");
                        a = double.Parse(Console.ReadLine());
                        area = a * a * a;
                        Console.Write("cube area = ");
                        Console.WriteLine(Math.Round(area, 2));
                        break;                   
                    case "end":
                        return;           
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }
        }
    }
}
