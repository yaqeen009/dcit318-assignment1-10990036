using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the lengths of the three sides
        Console.Write("Enter the length of side 1: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the length of side 2: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter the length of side 3: ");
        string input3 = Console.ReadLine();

        // Check if the inputs are valid numbers
        if (double.TryParse(input1, out double side1) && double.TryParse(input2, out double side2) && double.TryParse(input3, out double side3) && side1 > 0 && side2 > 0 && side3 > 0)
        {
            // Determine the type of triangle
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
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
            // Display an error message for invalid input
            Console.WriteLine("Please enter valid positive numbers for the sides of the triangle.");
        }
    }
}

