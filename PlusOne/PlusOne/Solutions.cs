using System.Data.Common;
using System.Formats.Asn1;

public class Solutions
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int[] PlusOne(int[] digits)
    {

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            else
                digits[i] = 0;
        }

        int[] ints = new int[digits.Length + 1];
        ints[0] = 1;
        return ints;


    }




}