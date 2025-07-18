﻿/* 

1071 - Greatest Common Divisor of Strings 

For two strings s and t, we say t divides s " if and only if s = t + t + t 
    (i.e. is concatenated with itself one or more times

Given two strings `str1` and `str2`, return the largest string x such x divides both str1 and str2 


Example 1:
Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"


Example 2:
Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"

Example 3:
Input: str1 = "LEET", str2 = "CODE"
Output: ""

*/



using System.Dynamic;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

string str1 = "ABCABC", str2 = "ABC";



var x = new Solutions();

x.GcdofString(str1, str2);

Console.WriteLine(x.GcdofString(str1, str2));
