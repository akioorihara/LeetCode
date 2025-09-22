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

        int isMatched = 0;
        int firstMatchedValue = 0;
        //bool isFirstValueMatched = false;

        // nested loop thorugh to check and return the index
        // e.g. -- haystack = "sadbutsad", needle = "sad"
        for (int i = 0; i < haystack.Length; i++)
        {
            for(int j = 0; j < haystack.Length; j++)
            {
                if (haystack[i] == needle[j])
                {
                    isMatched++;
                    continue; 
                }


            }
        }
        if(isMatched == needle.Length)
        {
            return firstMatchedValue;
        }

        return -1;
    }
}