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
  
            List<int> result = new List<int>();
            bool[] used = new bool[nums2.Length];  // tracker for nums2

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j] && !used[j])
                    {
                        result.Add(nums1[i]);
                        used[j] = true;  // mark as used
                        break;
                    }
                }
            }

            return result.ToArray();

    }




}