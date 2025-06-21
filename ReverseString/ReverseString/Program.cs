/*
Write a function that reverses a string. The input string is given as an array of characters s.
You must do this by modifying the input array in-place with O(1) extra memory.


Example - 1 
Input: s = ['h','e','l','l','o']
Output: ['o','l','l','e','h']

Example - 2 
Input: s = ['H','a','n','n','a','h']
Output: ['h','a','n','n','a','H']

*/


var solution = new Solution();
char[] str = new char[] {'H','a','n','n','a','h'};
char[] str2 = new char[] { 'h', 'e', 'l', 'l', 'o' };
solution.ReverseString(str);
solution.ReverseString(str2);



public class Solution
{
    public void ReverseString(char[] s)
    {
        Console.WriteLine(s);
        int lastIndex = s.Length - 1;

        for (int i = 0; i >= lastIndex; i++)
        {
            //swap 
            if (lastIndex == i)
            {
                //cannot swap + dont do anything 
                break;
            }
            else
            {
                char tempChar = s[i];
                s[i] = s[lastIndex];
                s[lastIndex] = tempChar;
            }
            // firstIndex++;
            lastIndex--;
        }

        Console.WriteLine(s);
    }
}