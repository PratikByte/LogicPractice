class ReverseString
{
    public static void PrintReverse()
    {
        //Take input from the user
        Console.WriteLine("Enter a string:");
        string inputString =Console.ReadLine();
        //reverse the string 
        for(int i=inputString.Length-1;i>=0;i--)
        {
            Console.Write(inputString[i]);
        }
        //print result
        Console.WriteLine();
    }
}