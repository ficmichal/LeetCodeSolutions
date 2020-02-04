using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        /// <summary>
        ///  Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        ///  You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///  
        /// Example:
        /// Given nums = [2, 7, 11, 15], target = 9,
        /// Because nums[0] + nums[1] = 2 + 7 = 9,
        /// return [0, 1].
        /// </summary>
        public int[] TwoSum(int[] nums, int target)
        {
            var numsDict = new Dictionary<int, int> { { nums.First(), 0 } };
            var numsLength = nums.Length;
            for (var i = 1; i < numsLength; i++)
            {
                var value = nums[i];
                var lookingValue = target - value;
                if (numsDict.ContainsKey(lookingValue))
                {
                    return new[] { numsDict[lookingValue], i };
                }
                if (!numsDict.ContainsKey(value))
                {
                    numsDict.Add(value, i);
                }
            }
            return new[] { 0, 0 };
        }
    }
}
