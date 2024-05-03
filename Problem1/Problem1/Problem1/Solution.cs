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
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] GetAnswer(int[] nums, int target)
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
    }
}

