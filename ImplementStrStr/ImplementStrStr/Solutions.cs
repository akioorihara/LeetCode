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
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        int hayStackLength = haystack.Length;
        int needleLength = needle.Length;

        // Return -1 if Needle's Length is shorter than Haystack 
        if(hayStackLength < needleLength)
        {
            return -1;
        }

        // nested loop thorugh to check and return the index
        // e.g. -- haystack = "sadbutsad", needle = "sad"
        for(int i = 0; i <= hayStackLength - needleLength; i++)
        {
            if (haystack.Substring(i, needleLength) == needle)
            {
                return i;
            }
        }

        return -1;
    }
}