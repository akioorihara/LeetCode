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

        //Ensure the bigger array comes first 
        if (nums1.Length < nums2.Length)
        {
            Intersect(nums2, nums1);
        }

        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (var num in nums1)
        {
            if (count.ContainsKey(num))
            {
                
            }
        }


        return new int[] { 0, 0 };

    }




}