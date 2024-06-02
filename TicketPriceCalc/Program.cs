using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        // Check if the input is a valid integer
        if (int.TryParse(input, out age) && age >= 0)
        {
            int ticketPrice;

            // Determine the ticket price based on the age
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7; // Discounted price for children and senior citizens
            }
            else
            {
                ticketPrice = 10; // Regular price for others
            }

            // Display the ticket price
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            // Display an error message for invalid input
            Console.WriteLine("Please enter a valid age.");
        }
    }
}
