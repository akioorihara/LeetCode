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
        Dictionary<char, int> countIndices = new Dictionary<char, int>();

        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (countUniqueChars.ContainsKey(s[i]))
            {
                countUniqueChars[s[i]]++;
            }
            else
            {
                countUniqueChars[s[i]] = 1;
                countIndices[s[i]] = index;
            }
            index++;

        }

        int smallestIndex = Int32.MaxValue;
        int smallestCandidate = 0;
        // int uniqueSmallestCharIndex = -1;
        foreach (var each in countUniqueChars)
        {
            if (countIndices.ContainsKey(each.Key) && each.Value == 1)
            {
                smallestCandidate = countIndices[each.Key];
            }

            if (smallestCandidate < smallestIndex)
                smallestIndex = smallestCandidate;
        }

        return smallestIndex > 0 ? -1 : smallestIndex;
    }
}