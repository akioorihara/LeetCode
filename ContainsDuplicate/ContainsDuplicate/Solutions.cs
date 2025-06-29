using System.Reflection.Metadata.Ecma335;

public class Solutions
{

    public bool ContainsDuplicate(int[] nums)
    {

        Array.Sort(nums);
        // Console.WriteLine(string.Join("",nums));

        for (int i = 1; i < nums.Length-1; i++)
        {
            if (nums[i] == nums[i-1])
            {
                return true;
            }
        }       
        return false;
    }
}