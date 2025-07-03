using System.Data;
using System.Diagnostics.Contracts;

public class Solutions
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[] Intersect(int[] nums1, int[] nums2)
    {

        if (nums1.Length < nums2.Length)
            return Intersect(nums2, nums1);

        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (var num in nums1)
        {
            if (count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;
        }

        List<int> result = new List<int>();

        foreach (var num in nums2)
        {
            if (count.ContainsKey(num) && count[num] > 0)
            {
                result.Add(num);
                count[num]--;
            }
        }

        return result.ToArray();

    }




}