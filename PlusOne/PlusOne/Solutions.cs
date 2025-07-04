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

        // One way to solve - look at the last element of the array
        // If not 9, increment 
        // otherwise, make it 0 and then increment the value one before 

        // get the last element of array = digits[digits.Length - 1]
        if (digits[^1] != 9)
        {
            digits[^1] += 1;
            return digits;
        }

        //increment 9(s)
        // Loop through from the end of the array 
        // carry over until not 9 
        List<int> ints = new List<int>();
        bool incrementor = false; 

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (incrementor)
            {
                ints.Insert(0, digits[i]);
                // break;
            }
            else if (digits[i] == 9 && i == 0 && !incrementor)
            {
                ints.Insert(0, 0);
                ints.Insert(0, 1);
            }
            else if (digits[i] == 9 && !incrementor)
            {
                ints.Insert(0, 0);
            }
            else
            {
                int incrementedInteger = digits[i] += 1;
                ints.Insert(0, incrementedInteger);
                incrementor = true;
            }
        }

        return ints.ToArray();

    }




}