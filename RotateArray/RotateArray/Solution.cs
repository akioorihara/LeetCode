


using System.Diagnostics.Contracts;

public class Solution
{
    /// <summary>
    /// Rotate array 
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate(int[] nums, int k)
    {
        
        Console.WriteLine("Input  Array: " + string.Join(",", nums));
        // error out if the input k is smaller than 0
        if (k <= 0)
            Console.WriteLine("The input K cannot be negative");


        // rotate 
        int[] rotatedArray = new int[nums.Length];

        //                             [1,2,3,4,5,6,7] - original 
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == nums.Length - 1)
            {
                rotatedArray[0] = nums[i];
            }
            else
            {
                rotatedArray[i + 1] = nums[i];
            }


        }

        Console.WriteLine("Output Array: " + string.Join(",",rotatedArray));


    }
}