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
        Dictionary<char, int> s_dict = new Dictionary<char, int>();
        Dictionary<char, int> t_dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            //the string s 
            if (s_dict.ContainsKey(s[i]))
            {
                s_dict[s[i]]++;
            }
            else
            {
                s_dict[s[i]] = 1;
            }

            //string t 
            if (t_dict.ContainsKey(t[i]))
            {
                t_dict[t[i]]++;
            }
            else
            {
                t_dict[t[i]] = 1;
            }
        }


        //check 
        foreach (var kvp in s_dict)
        {
            char key = kvp.Key;
            int s_val = kvp.Value;

            int t_val = -1;

            if (t_dict.ContainsKey(key))
            {
                t_val = t_dict[key];
            }

            if (t_val != s_val || t_val == -1)
            {
                return false;
            }
        }

        return true;
    }

}