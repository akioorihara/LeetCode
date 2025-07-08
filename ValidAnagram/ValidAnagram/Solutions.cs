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
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> count = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (!count.ContainsKey(s[i])) count[s[i]] = 0;
            if (!count.ContainsKey(t[i])) count[t[i]] = 0;

            count[s[i]]++;
            count[t[i]]--;
        }

        foreach (var kvp in count) {
            if (kvp.Value != 0)
                return false;
        }

        return true;
    }

}