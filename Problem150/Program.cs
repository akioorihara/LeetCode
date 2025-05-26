/*
 * 
 * Leetcode problem 150 
 * 
 * 

Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

Example 1:

Input: nums = [1, 2, 3, 3]
Output: true

Example 2:
Input: nums = [1, 2, 3, 4]
Output: false

 * 
 */

using Problem150;

Console.WriteLine("Starts - Leetcode 150");


var solution = new Solution();

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };


var testCaseOne = solution.HasDuplicate(numbers);


Console.WriteLine("Test Case Result :" + testCaseOne);

Console.ReadLine();


