using System;

public class Armstrong
{
    public static void CheckArmstrong()
    {
        // Take input from the user
        Console.WriteLine("Enter a Number:");
        int originalNumber = Convert.ToInt32(Console.ReadLine());

        // Create a copy of the original number for processing
        int number = originalNumber;

        // Store the sum of cubes of digits
        int sumOfCubes = 0;

        // Extract each digit and calculate its cube
        while (number > 0)
        {
            int digit = number % 10; // Get last digit

            sumOfCubes = sumOfCubes + (digit * digit * digit);

            number = number / 10; // Remove last digit
        }

        // Check if the number is an Armstrong number
        if (sumOfCubes == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong Number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong Number.");
        }
    }
}