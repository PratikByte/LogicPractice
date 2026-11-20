public class Palindrom
{
    public static void checkPalindromString()
    {
    //tale input
    Console.WriteLine("Enter a string:");
    String input=Console.ReadLine();

    //store orginal string
    String originalString=input;
    //reverse string
    String reverseString="";

    //check original string and reverse string
    for (int i = input.Length - 1; i >= 0; i--)
        {
            reverseString=reverseString+input[i];
        }

    //print result
    if (originalString.Equals(reverseString))
        {
            Console.WriteLine("This is a palindrom string");
        }
        else
        {
            Console.WriteLine("This is not a palindrom string");
        }
    }
}