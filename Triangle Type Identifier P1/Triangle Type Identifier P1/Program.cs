using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side 1: ");
            if (double.TryParse(Console.ReadLine(), out double side1) && side1 > 0)
            {
                Console.Write("Enter the length of side 2: ");
                if (double.TryParse(Console.ReadLine(), out double side2) && side2 > 0)
                {
                    Console.Write("Enter the length of side 3: ");
                    if (double.TryParse(Console.ReadLine(), out double side3) && side3 > 0)
                    {
                        if (side1 == side2 && side2 == side3)
                        {
                            Console.WriteLine("The triangle is Equilateral.");
                        }
                        else if (side1 == side2 || side2 == side3 || side1 == side3)
                        {
                            Console.WriteLine("The triangle is Isosceles.");
                        }
                        else
                        {
                            Console.WriteLine("The triangle is Scalene.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for side 3. Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for side 2. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for side 1. Please enter a positive number.");
            }
        }
    }
}
