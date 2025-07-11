﻿/*

Reverse Integer 

Given a signed 32-bit integer x, return x with its digits reversed. 
If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned)

*/


// Example 1 
// Input: x = 123
// Output: 321


// Exmaple 2 
// Input: x = -123
// Output: -321


// Example 3 
// Input: x = 120
// Output: 21


// Solutions solution = new Solutions();
// solution.Reverse(123);
// solution.Reverse(-123);


Reverse rev = new Reverse();
rev.ReverseInteger(1234);
rev.ReverseInteger(-12345);
