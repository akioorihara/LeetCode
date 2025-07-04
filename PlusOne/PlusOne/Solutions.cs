using System.Data.Common;

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
        for (int i = digits.Length - 1; i >= 0; i--)
        {

            if (digits[i] == 9)
            {
                
            }



        }




        return digits;

    }




}