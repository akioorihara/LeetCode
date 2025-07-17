
/// <summary>
/// Converts a string to a 32-integer assigned integer  
/// </summary>
public class Solutions
{

    /// <summary>
    /// Convert a string to a int  
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MyAtoi(string s)
    {
        
        if (string.IsNullOrEmpty(s)) return 0;

        int i = 0;
        int n = s.Length;
        // Skip leading whitespaces
        while (i < n && s[i] == ' ') i++;

        // Check if we've reached the end
        if (i == n) return 0;

        // Check sign
        int sign = 1;
        if (s[i] == '+' || s[i] == '-') {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        long result = 0;
        while (i < n && char.IsDigit(s[i])) {
            result = result * 10 + (s[i] - '0');

            // Clamp to 32-bit range
            if (sign * result <= int.MinValue) return int.MinValue;
            if (sign * result >= int.MaxValue) return int.MaxValue;

            i++;
        }

        return (int)(sign * result);        

    }



}