using System.Text;
namespace RomanToInteger
{
	public class Solutions
	{
		public Solutions()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
        public int RomanToInt(string s)
        {
			var sb = new StringBuilder();
			int total = 0;
			char[] chars = s.ToCharArray(); // should be ToCharArray() over ToArray()

			for(int i = 0; i < s.Length; i++)
			{

				if (i + 1 < s.Length)
				{
					if (chars[i + 1] != 'I' && chars[i] == 'I')
					{
						total += Convert(chars[i + 1]) -1;
					}
					else
					{
						total += Convert(chars[i]);
					}
				}
				else //last index and no more index after this 
				{
					total += Convert(chars[i]);
				}

			}


			return total;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		private int Convert(char x)
		{
			switch(x)
			{
				case 'I':
					return 1;
				case 'V':
					return 5;
				case 'X':
					return 10;
				case 'L':
					return 50;
				case 'C':
					return 100;
				case 'D':
					return 500;
				case 'M':
					return 1000;
				default:

					break;
			}
			return 0;
		}

    }
}

