using System;
namespace Problem1
{
	public class Solution
	{
		public Solution()
		{
        
        }

        /// <summary>
        /// Input: nums = [2, 7, 11, 15], target = 9
        /// Output: [0,1]
        /// Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
        ///
        /// Time complexity = O(n^2)
        /// Space complexity = O(1) 
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {

            //Check constrains
            int length = nums.Length;

            //Length must be greater than 2
            if(nums == null || length < 2)
            {
                return new int[0];
            }


            //Logic
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }
            }

            //The solution not found 
            return new int[0];
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumOptimized(int[] nums, int target)
        {
            //Check the min length of array
            int length = nums.Length;

            //Length must be greater than 2
            if(length < 2 || nums == null)
            {
                return new int[0];
            }

            //Store nums in a dictionary
            Dictionary<int, int> resultDict = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int firstValue = nums[i];
                int secondValue = target - firstValue;

                if (resultDict.TryGetValue(secondValue, out int index))
                {
                    return new[] { index, i };

                }

                //Add key value pair 
                resultDict[firstValue] = i;

            }


            //Solutions not found
            return new int[0];
        }



    }
}

