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
    bool[] used = new bool[nums2.Length];

    for (int i = 0; i < nums1.Length; i++)
    {
        for (int j = 0; j < nums2.Length; j++)
        {
            if (!used[j] && nums1[i] == nums2[j])
            {
                result.Add(nums1[i]);
                used[j] = true;  // mark as used
                break;
            }
        }
    }

    return result.ToArray();




}