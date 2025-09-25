using System;
namespace ReverseInteger
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
        public int Reverse(int x)
        {

			// Checking outside of int32 ranges
			if(x > int.MaxValue || x < int.MinValue)
			{
				return 0;
			}





			return -1;
        }
    }
}

