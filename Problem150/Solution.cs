using System;
namespace Problem150
{

	/// <summary>
	/// 
	/// </summary>
	public class Solution
	{
		/// <summary>
		/// 
		/// </summary>
		public Solution()
		{

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
        public bool HasDuplicate(int[] nums)
        {
			var xDict = new Dictionary<int, int>();

			// Loop through each number  
			foreach(var each in nums)
			{
				// Check 
				if (xDict.ContainsKey(each))
				{
					xDict[each] += 1;
					// I could return true already here 
                }
				else{
                    xDict.Add(each, 1);
                }
			}

			foreach (var n in xDict)
			{
				Console.WriteLine($"Key : {n.Key}, Occurence {n.Value}");

				if (n.Value > 1)
				{
					return true;
				}
			}
            return false;
        }





		/// <summary>
		/// This is the revised version of 217 Has Duplicate
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public bool DetectDuplicate(int[] nums)
		{
			var seen = new HashSet<int>();

			foreach(var num in nums)
			{
				if (seen.Add(num))
				{
					//keep looping and successfully added the value 
				}
				else
				{
					return true;
					//unable to add = found a dup
				}
			}

			return false;

		}


    }
}




// option 1 - keep each number in an array to keep track

// option 2 - 