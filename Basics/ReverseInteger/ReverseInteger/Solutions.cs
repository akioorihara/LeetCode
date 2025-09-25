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
			if(x > int.MaxValue || x < int.MinValue)
			{
				return 0;
			}

			var convertedToString = x.ToString();
			var sb = new StringBuilder();

			foreach(var each in convertedToString.Reverse())
			{
				sb.Append(each);
				Console.WriteLine(each);
			}

			var sbString = sb.ToString().Trim();

            int result = -1;

            try
            {
				// do try parse
				int.TryParse(sbString, out result);
			}
			catch(Exception ex)
			{

			}


			return result;
        }
    }
}

