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

solution.ReverseString(str);



public class Solution
{
    public void ReverseString(char[] s)
    {
        Console.WriteLine(s);
        int lastIndex = s.Length - 1;
        int firstIndex = 0;
        foreach (char e in s)
        {
            //swap 
            if (lastIndex == firstIndex)
            {
                //cannot swap + dont do anything 
                break;
            }
            else
            {

                char tempChar = e;
                s[firstIndex] = s[lastIndex];
                s[lastIndex] = e;
            }
            firstIndex++;
            lastIndex--;

        }

        Console.WriteLine(s);
    }
}