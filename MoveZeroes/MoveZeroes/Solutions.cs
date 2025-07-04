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
        int lastNonZeroLocation = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[lastNonZeroLocation] = nums[i];
                lastNonZeroLocation++;
            }
        }


        for (int i = lastNonZeroLocation; i < nums.Length; i++)
        {
            nums[i] = 0;
        }


        Console.WriteLine(string.Join("",nums));

    }
}