public class Solutions
{

    /// <summary>
    /// Given the strings needle and haystack 
    /// return the index of the first occurance of the needle in haystack 
    /// if not found, return -1 
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public int StrStr(string haystack, string needle)
    {

        //check if haystack contains needle 
        if (!haystack.Contains(needle))
            return -1;

        int counter = 0;

        // Loop thorugh to check 
        foreach (var each in haystack)
        {
            // do the logic here 

        }


        return 0;
    }


}