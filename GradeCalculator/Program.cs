using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter a numerical grade (0-100): ");
        string input = Console.ReadLine();
        int grade;

        // Check if the input is a valid integer
        if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
        {
            string letterGrade;

            // Determine the letter grade based on the numerical grade
            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Display the corresponding letter grade
            Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
        }
        else
        {
            // Display an error message for invalid input
            Console.WriteLine("Please enter a valid numerical grade between 0 and 100.");
        }
    }
}
