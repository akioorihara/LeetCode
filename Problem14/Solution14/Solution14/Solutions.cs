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


            //strs[i] consists of only lowercase English letters.
            var isFailed = CheckLowerCaseEnglish(strs);
            if (isFailed)
                return "";


            //Logic

            string result = "";

            //Input: strs = ["flower", "flow", "flight"]
            for (int i = 1; i < strs.Length; i++)
            {
                for(int j = 0; j < strs.Length; j++)
                {
                    if (strs[0][j] == strs[i][j])
                    {
                        continue;
                    }
                    else
                    {

                    }

                }


                if (strs[0][i] == strs[i][-i])
                {
                    //result += strs[0][i];
                }
               

            }



            return "";
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

