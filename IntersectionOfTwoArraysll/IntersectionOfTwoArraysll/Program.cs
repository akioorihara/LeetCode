/*

Intersection of Two Arrays 2 

Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.


Example 1: 
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]

Example 2: 
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted.

Example 3: 
Input num1: [1,2,2,1], num2 = [2]
Output: [2]

*/


Solutions solution = new Solutions();
Console.WriteLine(string.Join(",", solution.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2,2 })));
Console.WriteLine(string.Join(",", solution.Intersect(new int[] { 4, 9, 5 , 6}, new int[] { 9, 4, 9, 8, 4, 6 })));
Console.WriteLine(string.Join(",", solution.Intersect(new int[] { 1,2,2,1 }, new int[] { 2 })));
