/// <summary>
/// 
/// </summary>
public class Solution
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="nums"></param>
    public void MoveZeroes(int[] nums)
    {


        int pointer = 0;
        for (int i = 0; i < nums.Length; i++)
        {


            while (nums[pointer] == 0 && pointer != nums.Length)
            {
                int temp = nums[pointer];
                nums[pointer] = nums[i++];
                nums[i] = nums[pointer];


            }
        }

        Console.WriteLine(string.Join("",nums));

    }
}