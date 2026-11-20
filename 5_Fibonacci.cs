public class Fibonacci
{
    public static void PrintFibonacci()
    {
        // Take input from the user
        Console.WriteLine("Enter number of terms:");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());
        //first two numbers of the sequence
        int firstNumber = 0;
        int secondNumber = 1;
        //print the sequence up to the nth term
        Console.WriteLine("Fibonacci Sequence:");
        for (int count = 0; count < numberOfTerms; count++)
        {
            Console.Write(firstNumber + " ");
            int nextnumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextnumber;
        }

    }
}