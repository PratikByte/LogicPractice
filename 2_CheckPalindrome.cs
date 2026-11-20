using System;

public  class Palindrome
{
public static void CheckPalindrome()
{
    //Take input from user
    Console.WriteLine("Enter a Number:");
    int Number=Convert.ToInt32(Console.ReadLine());

    //store original number
    int OriginalNumber=Number;

    //to store reverse number
    int reverse=0;

        //loop until number is greater than 0
        while (Number > 0)
        {
            int digit=Number%10; //get last digit
            reverse=(reverse*10)+digit; //append digit to reverse
            Number=Number/10; //remove last digit

        }

        //check palindrome
        if (OriginalNumber == reverse)
        {
            Console.WriteLine(OriginalNumber+" is palindrome.");
        }
        else
        {
            Console.WriteLine(OriginalNumber+" is not palindrome.");
        }
    
}
}