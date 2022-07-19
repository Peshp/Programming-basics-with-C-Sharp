using System;

namespace C64
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int counter = 0;
            bool bookfound = false;
            while (true)
            {
                string books = Console.ReadLine();
                counter++;
                if(books == book)
                {
                    counter -= 1;
                    bookfound = true;
                    break;
                }
                if(books == "No More Books")
                {
                    counter -= 1;
                    break;
                }
            }
            if(bookfound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
