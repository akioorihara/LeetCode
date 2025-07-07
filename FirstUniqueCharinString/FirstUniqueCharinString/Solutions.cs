using System.Data.Common;
using System.Runtime.InteropServices;

public class Solutions
{
    /// <summary>
    /// Given a string and return a first unique char 
    /// If not found, return -1
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> countUniqueChars = new Dictionary<char, int>();
        // Dictionary<char, int> countIndices = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (countUniqueChars.ContainsKey(s[i]))
            {
                countUniqueChars[s[i]]++;
            }
            else
            {
                countUniqueChars[s[i]] = 1;
            }

        }

        for (int i = 0; i < s.Length; i++)
        {
            if (countUniqueChars[s[i]] == 1)
                return i;
        }

        return -1;

    }
}