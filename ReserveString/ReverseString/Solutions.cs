	using System;
	using Microsoft.VisualBasic;

	namespace ReverseString
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
			public void ReverseString(char[] s)
			{
				List<string> reverse = new List<string> { };
				string[] strings = new string[] { };
				//strings = s.ToArray<string>(){ };


				//The array is empty, return with an empty array 
				int counter = s.Length - 1;

				for (int i = 0; i < s.Length; i++)
				{
					//reverse.Add(s[counter]);
					reverse.Add(s[counter].ToString());
					counter--;
				}

				//Console.WriteLine(reverse.ToString());
				Console.WriteLine(string.Join("", reverse));
			// Print the reversed list

		}	
	

			/// <summary>
			/// 
			/// </summary>
			/// <param name="strings"></param>
			/// <returns></returns>
			public List<string> ReverseStringArray(string[] strings)
			{
				List<string> reverse = new List<string> {};

				//The array is empty, return with an empty array 
				int counter = strings.Length -1 ;
				if (counter <= 0)
					return new List<string> {};


				for (int i = 0; i < strings.Length; i++)
				{
					reverse.Add(strings[counter]);
					counter--;
				}


				return reverse;
			}



		}
	}

