using System;
namespace ReverseInteger
{
	public class Solutions_v2
	{
		public Solutions_v2()
		{
		}


		/// <summary>
		/// Reverse an integer 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public int Reverse(int x)
		{
			if(x > int.MaxValue || x < int.MinValue)
			{
				return 0;
			}

			bool isNegative = false;
			if(x < 0)
			{
				isNegative = true;
			}

			char[] arr = x.ToString().ToCharArray();
			arr.Reverse();
			string reverse = arr.ToString();


			if(int.TryParse(reverse, out int result))
			{
                return isNegative ? -result : result;
            }

			return 0;
        }


	}
}

