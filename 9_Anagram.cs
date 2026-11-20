public class Anagram
{
   public static void CheckAnagram()
    {
        //Take sting 1 from user in lower case
        Console.WriteLine("Enter first string:");
        string firstString=Console.ReadLine().ToLower();
        //Take string 2 from user in lower case
        Console.WriteLine("Enter second string:");
        string secondString=Console.ReadLine().ToLower();
        //comapare length of both string if not equal then not anagram
        if (firstString.Length != secondString.Length)
        {
            Console.WriteLine("Given strings are not anagrams.");
            return;
        }
        // Convert strings to character arrays
        char [] firstStringCharacters =firstString.ToCharArray();
        char []secondStringCharacters=secondString.ToCharArray();
        // Sort both arrays
        Array.Sort(firstStringCharacters);
        Array.Sort(secondStringCharacters);
        // Convert arrays back to strings
        string sortedFirstString=new string(firstStringCharacters);
        string sortedSecondString=new string(secondStringCharacters);
        // Compare sorted strings
        if (sortedFirstString == sortedSecondString)
        {
            Console.WriteLine("Given strings are anagrams.");
        }
        else
        {
            Console.WriteLine("Given strings are not anagrams.");
        }


    } 
}