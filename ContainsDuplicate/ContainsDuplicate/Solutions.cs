using System.Reflection.Metadata.Ecma335;

public class Solutions
{

    public bool ContainsDuplicate(int[] nums)
    {

        Array.Sort(nums);
        // Console.WriteLine(string.Join("",nums));

        int nextIndex = 1;
        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] == nums[nextIndex])
            {
                return true;
            }
            nextIndex++;
        }       
        return false;
    }
}