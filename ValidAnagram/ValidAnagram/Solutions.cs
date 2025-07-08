public class Solutions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsAnagram(string s, string t)
    {
        //check the length 
        if (s.Length != t.Length)
        {
            return false;
        }

        //
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            //the string s 
            if (dict.ContainsKey(s[i]))
            {
                dict[s[i]]++;
            }
            else
            {
                dict[s[i]] = 1;
            }
        }


        //check 
        


        return false;
    }

}