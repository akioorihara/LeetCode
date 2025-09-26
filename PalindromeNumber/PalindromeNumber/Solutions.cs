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

			if(x < 0)
				return false;

			char[] chars = x.ToString().ToCharArray();
			chars.Reverse();
			string reverse = chars.ToString();

			int size = x.ToString().Length;



			return false;
        }

    }
}

