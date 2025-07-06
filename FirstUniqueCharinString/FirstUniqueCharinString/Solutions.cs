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
        Dictionary<char, int> dict = new Dictionary<char, int>();

        int counter = 0;
        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }

        }

        dict.Where(x => x.Value == 1);


        return 1;
    }
}