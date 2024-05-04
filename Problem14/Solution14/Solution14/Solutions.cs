using System;
namespace Solution14
{
	public class Solutions
	{
		public Solutions()
		{
		}



        /// <summary>
        /// 
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// If there is no common prefix, return an empty string "".
        ///
        /// Example 1:
        /// Input: strs = ["flower", "flow", "flight"]
        /// Output: "fl"
        ///
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
		{
            //Validate and check for the constrains
            if (strs.Length <= 1 && strs.Length >= 200){
                return "";
            }

            //Elemennt must be bigger than 0 or grater and less than 200
            //0 <= strs[i].length <= 200


            string res = string.Empty;
            string str = strs[0];

            //Logic

            //Get the shortest string 
            foreach(var s in strs)
            {
                if(s.Length < str.Length)
                {
                    str = s;
                }
            }

            //Get the smallest string len 
            int len = strs.Length;


            for(int i = 0; i < strs.Length; i++)
            {
                for(int j = 0; j < len; j++)
                {
                    if (str[i] == strs[j][i])
                    {
                        continue;
                    }
                    else
                    {
                        return res;
                    }
                }
                res += str[i];
            }

            return res;
		}



        /// <summary>
        /// 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        private bool CheckLowerCaseEnglish(string[] strs)
        {


            return false;
        }
	}
}

