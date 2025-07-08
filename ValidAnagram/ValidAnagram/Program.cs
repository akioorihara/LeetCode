/*

Given two strings s and t, 
return true if t is an anagram of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.


*/

Solutions solution = new Solutions();

// Console.WriteLine(solution.IsAnagram("anagram", "nagaram"));
Console.WriteLine(solution.IsAnagram("rat", "car"));
Console.WriteLine(solution.IsAnagram("rac", "car"));