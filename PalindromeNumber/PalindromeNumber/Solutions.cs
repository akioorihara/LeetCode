using System;
namespace PalindromeNumber
{
	public class Solutions
	{
		public Solutions()
		{
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
        public bool IsPalindrome(int x)
        {

			// Negative values cannot be palindrom
			if (x < 0)
				return false;

			string orignalOrder = x.ToString();
			char[] chars = x.ToString().ToCharArray();
			chars.Reverse().ToString();

			if (string.IsNullOrEmpty(chars.ToString()))
				return false;

			string reverseOrder = new String(chars);
			int size = x.ToString().Length;

			var loopSize = x.ToString().Length;
			if(loopSize % 2 == 0)
			{
				loopSize = loopSize / 2;
			}
			else
			{
				loopSize = Math.Abs(loopSize / 2);
			}

			int counterFromBcak = size - 1;
			for(int i = 0; i < loopSize; i++)
			{
				if (orignalOrder[i] != reverseOrder[counterFromBcak])
				{
					return false;
				}

				counterFromBcak -= 1;
			}

			return true;
        }

    }
}

