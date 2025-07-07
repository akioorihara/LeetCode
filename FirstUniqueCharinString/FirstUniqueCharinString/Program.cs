/* 

Problem - First Unique Charactor in a string 


Given a string s, find the first non-repeating character in it and return its index. 
If it does not exist, return -1.

Example 1:
Input: s = "leetcode"
Output: 0
Explanation:
The character 'l' at index 0 is the first character that does not occur at any other index.

Example 2:
Input: s = "loveleetcode"
Output: 2

Example 3:
Input: s = "aabb"
Output: -1


*/

Solutions solution = new Solutions();

Console.WriteLine(solution.FirstUniqChar("leetcode")); // 0
Console.WriteLine(solution.FirstUniqChar("loveleetcode")); // 0
Console.WriteLine(solution.FirstUniqChar("aabb")); //-1 