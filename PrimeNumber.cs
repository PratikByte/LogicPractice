using System;

public class PrimeNumber
{
    public static void CheckPrime()
    {
        int number = 7;
        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine(number + " is Prime");
        else
            Console.WriteLine(number + " is Not Prime");
    }
}