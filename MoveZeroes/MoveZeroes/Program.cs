/* 

Problem: Move Zeroes

Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.

Example 1:
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:
Input: nums = [0]
Output: [0]

Example 3: 
Input: nums = [0,1,0]
Output: [1, 0, 0]

*/

var solution = new Solution();

solution.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
solution.MoveZeroes(new int[] { 0 });
solution.MoveZeroes(new int[] { 0, 1, 2 });