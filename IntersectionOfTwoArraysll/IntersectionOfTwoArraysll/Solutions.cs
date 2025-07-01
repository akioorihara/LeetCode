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

        int size = nums1.Length <= nums2.Length ? nums1.Length : nums2.Length;
        // int[] matched = new int[size];
        List<int> mt = new List<int>();

        int counter = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {

                if (nums1[i] == nums2[j])
                {
                    // matched[counter] = nums1[i];
                    mt.Add(nums1[i]);
                    counter++;
                    break; 
                }
            }
        }

        return mt.ToArray();
    }




}