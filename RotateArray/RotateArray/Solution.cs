


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


        k = k % nums.Length; // normalize the itration 

        // rotate 
        int[] rotatedArray = new int[nums.Length];

        //                             [1,2,3,4,5,6,7] - original 
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]

        for (int i = 0; i < nums.Length; i++)
        {
            int newIndex = (i + k) % nums.Length;
            rotatedArray[newIndex] = nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rotatedArray[i];
        }


        Console.WriteLine("Rotated Array: " + string.Join(",", rotatedArray));

        Console.WriteLine("Nums Array:    " + string.Join(",", nums));

    }
}