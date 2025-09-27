using System;
namespace PalindromeNumber
{
	public class Solutions_v2
	{
		public Solutions_v2()
		{
		}

        /// <summary>
        /// Could you solve it without converting the integer to a string?
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
		{

			// Negagtive cannot be a palindrom, unfortunately
			if (x < 0)
				return false;

			int intSize = x.ToString().Length;
			if(intSize % 2 == 0)
			{
				intSize /= 2;
			}
			else
			{
				intSize = Math.Abs(intSize / 2);
			}

			//var temp = 

			int countFromBack = x.ToString().Length - 1;
			for(int i = 0; i < intSize; i++)
			{



			}



			return true;
		}

	}
}

