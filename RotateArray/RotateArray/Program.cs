﻿// Rotate array 
// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
/*


Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]

*/

var solution = new Solution();

// Test case 1 
int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
solution.Rotate(nums, 3);


// test case 2 
nums = new int[] { -1, -100, 3, 99 };
solution.Rotate(nums, 2);