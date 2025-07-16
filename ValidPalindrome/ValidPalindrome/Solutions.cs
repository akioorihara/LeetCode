using System.Security.AccessControl;
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
        var cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

        if (string.IsNullOrEmpty(cleaned))
        {
            return true;
        }

        // check the left and right 
        int left = 0, right = cleaned.Length - 1;

        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
            {
                return false;
            }
            right--;
            left++;
        }

        return true;
    } 

    /// <summary>
    /// 
    /// </summary>
    public bool IsPalindromed (string s)
    {
        



        return false;
    }


}