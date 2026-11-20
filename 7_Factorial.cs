class Factorial
{
    public static void calculateFactorial()
    {
        //Take inpout from the user
        Console.WriteLine("Enter a number:");
        int n=Convert.ToInt32(Console.ReadLine());
        //calculate factorial 
        int factorial=1;
        for(int i = 1; i <= n; i++)
        {
            factorial=factorial*i;
        }
        //print result
        Console.WriteLine("Factorial of "+n+" is: "+factorial);
    }
}