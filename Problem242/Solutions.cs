using System;
namespace Problem242
{
	public class Solutions
	{
		public Solutions()
		{
		}



		/// <summary>
		/// Leetcode Problem 242 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="t"></param>
		/// <returns></returns>
		public bool IsAnagram(string s, string t)
		{
			// Does the length match?
			if(s.Length != t.Length)
			{
				return false;
			}

			// Contains all letters? 
			Dictionary<char, int> dict = new Dictionary<char, int>();
			Dictionary<char, int> validator = new Dictionary<char, int>();


			// Get letter counts for word 
			foreach(var c in s)
			{
				if (dict.ContainsKey(c))
				{
					dict[c] += 1;
				}
				else
				{
					dict.Add(c, 1);
				}
			}

            // count for the second string
            foreach (var c in t)
            {
                if (validator.ContainsKey(c))
                {
                    validator[c] += 1;
                }
                else
                {
                    validator.Add(c, 1);
                }
            }


            Console.WriteLine("First Dict");
			foreach(var k in dict)
			{
				Console.WriteLine($"Key: {k.Key} | Value: {k.Value}");
			}

            Console.WriteLine("Validator Dict");
            foreach (var k in validator)
            {
                Console.WriteLine($"Key: {k.Key} | Value: {k.Value}");
            }

			int counter = 0;

            var list = dict.ToList();
            // Compare the key and value pair
            for (int i = 0; i < list.Count; i++)
			{
				//var list = dict.ToList();

				counter++;
				
				// check if the char contains
				char c1 = list[i].Key;
				int num1 = list[i].Value;


				if (validator.ContainsKey(c1))
				{
					var x = validator[c1];
					if(x != num1)
					{
						return false; 
					}
				}
				else
				{
					return false;
				}

            }

            return true; 
		}


		/// <summary>
		/// This is the solution provided for the better ways 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="t"></param>
		/// <returns></returns>
        public bool V2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var count = new Dictionary<char, int>();

            // Count characters in 's'
            foreach (var c in s)
            {
                if (count.ContainsKey(c))
                    count[c]++;
                else
                    count[c] = 1;
            }

            // Subtract count based on characters in 't'
            foreach (var c in t)
            {
                if (!count.ContainsKey(c))
                    return false;

                count[c]--;

                if (count[c] < 0)
                    return false;
            }

            // All values should be 0 if it's a valid anagram
            return true;
        }


    }

}

