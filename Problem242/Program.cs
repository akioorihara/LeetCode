//Given two strings s and t, return true if t is an anagram of s, and false otherwise.
//Example 1:
//Input: s = "anagram", t = "anagram"
//Output: true

//Example 2:
//Input: s = "rat", t = "car"
//Output: false


//Constraints:

//1 <= s.length, t.length <= 5 * 104
//s and t consist of lowercase English letters.


//Anagram = a word, phase, or name formed by rearranged the letters of another, such as cinema, formed from iceman 


using Problem242;

Console.WriteLine("Starts the problem 242 - Valid Anagram");


var solution = new Solutions();

// Test case 1 
var result = solution.IsAnagram("anagram", "nagaram");
Console.WriteLine($"Is Anagram : {result}");

// Test case 2 
result = solution.IsAnagram("rat", "car");
Console.WriteLine($"Is Anagram : rat | car |  {result}");


//Test Case 3 
result = solution.IsAnagram("cinema", "iceman");
Console.WriteLine($"Is Anagram : {result}");






Console.ReadLine();


