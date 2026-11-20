public class DuplicateCharacter
{
    public static void findDuplicate()
    {   //take input from user
        Console.WriteLine("Enter a string:");
        string input=Console.ReadLine();
        //create direcory
        Dictionary<char,int>charCount=new Dictionary<char, int>();

        //loop through each character in the string
        foreach(char ch in input)
        {
            //check charachetr already exist
            if (charCount.ContainsKey(ch))
            {
                charCount[ch]++;
            }
            else
            {
                charCount[ch]=1;
            }
            
        }
        //print result
        Console.WriteLine("\n Character frequency:");
        foreach(var item in charCount)
        {
            Console.WriteLine(item.Key+" : "+item.Value);
        }


    }   
}