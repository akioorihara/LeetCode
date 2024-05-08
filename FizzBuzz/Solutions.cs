using System;
namespace FizzBuzz
{
	public class Solutions
	{
		public Solutions()
		{
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
        public IList<string> FizzBuzz(int n)
        {
			//Constrains and validations
			if (n <= 0)
				return new List<string>(); //Return an empty list 
			else if (n % 3 == 0)
			{
				//fizz
			}
			else if (n % 5 == 0)
			{
				//buzz
			}
			else if (n % 3 == 0 && n % 5 == 0)
			{
				//fizzbuzz
			}
			else
			{
				//i (as a string) if none of the above conditions are true
				return new List<string> {"i"};
			}


			return new List<string> ();
        }


    }
}

