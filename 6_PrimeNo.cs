public class PrimeNumer
{
    public static void checkPrime()
    {
        // Take input from the user
        Console.WriteLine("Enter a number:");
        int inputNumber=Convert.ToInt32(Console.ReadLine());
        //Assume no is prime to set the flag
        bool isPrime=true;
        //check no diviible 
        if (inputNumber < 2)
        {
            isPrime=false;
        }else
        {
            for(int divisor=2;divisor<inputNumber;divisor++)
            {
                if (inputNumber % divisor == 0)
                {
                    isPrime=false;
                    break;
                }
            }
        }
        //print result
        if(isPrime)
        {
            Console.WriteLine(inputNumber+" is a prime number.");
        }else
        {
            Console.WriteLine(inputNumber+" is not a prime number.");
        }
    }
}