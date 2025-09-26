using System.Text;
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
            if (x > int.MaxValue || x < int.MinValue)
            {
                return 0;
            }

            var convertedToString = x.ToString();
            var sb = new StringBuilder();

            // check if negavie or not
            bool isNegative = false;
            if (x < 0)
            {
                isNegative = true;
                convertedToString = convertedToString.Substring(1);
            }

            foreach (var each in convertedToString.Reverse())
            {
                sb.Append(each);
                //Console.WriteLine(each);
            }

            var sbString = sb.ToString().Trim();


            // do try parse
            if(int.TryParse(sbString, out int result))
            {
                return isNegative ? -result : result;
            }

            return 0;


            //bool isNegative = x < 0;
            //string s = Math.Abs((long)x).ToString(); // use long to avoid issues on -2147483648
            //char[] arr = s.ToCharArray();
            //Array.Reverse(arr);
            //string reversed = new string(arr);

            //if (int.TryParse(reversed, out int result))
            //{
            //    return isNegative ? -result : result;
            //}
            //return 0; // overflow case


        }
    }
}

