
using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int standardPrice = 10;
            const int discountedPrice = 7;

            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age <= 12 || age >= 65)
                {
                    Console.WriteLine($"Ticket Price: GHC{discountedPrice}");
                }
                else
                {
                    Console.WriteLine($"Ticket Price: GHC{standardPrice}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
