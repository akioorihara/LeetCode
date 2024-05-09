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
			//Instantiate a List to hold the "n"
			List<string> fizzBuzz = new List<string>();


			//Constrains and validations
			if (n <= 0)
				return new List<string>(); //Return an empty list 


			for(int i = 1; i <= n; i++)
			{
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        //buzz
                        fizzBuzz.Add("FizzBuzz");
                        continue;
                    }
                    //fizz
                    fizzBuzz.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    fizzBuzz.Add("Buzz");
                    //buzz
                }
                else
                {
                    fizzBuzz.Add($"{i}");
                    //i (as a string) if none of the above conditions are true
                    
                }
            }
            return fizzBuzz;
        }
    }
}

