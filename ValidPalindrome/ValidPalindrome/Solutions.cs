using System.Text.RegularExpressions;

public class Solutions
{

    /// <summary>
    /// A phrase is a palidrome if, after converting all uppercase leeters into lowercase letters and removing all non-alphanumeric chars
    /// if reads the same forward and backwards 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool IsPalindrome(string s)
    {

        //Remove the non-alphanumeric values 
        string cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

        if (string.IsNullOrEmpty(cleaned))
        {
            return false;
        }

        Dictionary<char, int> dict = new Dictionary<char, int>();
        int size = s.Length;

        var arr = s.ToList();

        if (size % 2 == 0)
        {
            //TODO - check if we have the same amount 

        }
        else
        {
            //the middle letter should be removed and then iterate through
            int middleIndex = (int)Math.Round((decimal)size / 2);

            //Remove the middle index char or create a new memory to recreate without the middle value so that we can loop 
            // s[middleIndex] = "";
            char middleChar = s[middleIndex];
            arr.RemoveAt(middleIndex);


        }



        //The first half should be added and then second half should be removed or substracted 
        foreach (var each in arr)
        {
            if (dict.ContainsKey(each))
            {
                dict[each] += 1;
            }
            else
            {
                dict[each] = 1;
            }

        }

        










        return false;
    } 

}