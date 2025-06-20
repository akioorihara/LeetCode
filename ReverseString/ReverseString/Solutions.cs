using System;
namespace ReverseString
{
	public class Solutions
	{
            public class Solution
        {
            public void ReverseString(char[] s)
            {
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    // Swap s[left] and s[right]
                    char temp = s[left];
                    s[left] = s[right];
                    s[right] = temp;

                    left++;
                    right--;
                }
            }
        }


    }
}

