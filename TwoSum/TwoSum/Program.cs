// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

// Example 1:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Example 2:
// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:
// Input: nums = [3,3], target = 6
// Output: [0,1]
 
// Constraints:

// 2 <= nums.length <= 104
// -109 <= nums[i] <= 109
// -109 <= target <= 109
// Only one valid answer exists.

// Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

Console.WriteLine("Two Sum : LeetCode");


// static int[] TwoSum(int[] nums, int target){
//     return nums;
// }



// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
int[] nums = new int[] {2,7,11,15};
int target = 9;

twoSum(nums, target);

int[] twoSum(int[] nums, int target){
    
    //Create an integer array to store the values of returns 
    int[] returns = new int[] {};
    
    //Create a variable to count for the remainder 
    int remainder;

    //index counter 
    int indexCounter = 0;

    //check the target can be substracted 
    foreach(int num in nums){
        remainder = target - num;
        returns.Append(num);
        
        Console.WriteLine(returns);

        indexCounter++;
        if(remainder == target)
            break;
    }



    return nums; //should be return of 0,1
}


//Note - what is collection expressionnn and use version 12.0 or greater CS9058 