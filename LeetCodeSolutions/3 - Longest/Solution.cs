using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            var sLength = s.Length;
            var i = 0;
            var j = 0;
            var currentChars = new HashSet<char>();
            var longestSubstringLength = 0;
            while (i < sLength && j < sLength)
            {
                if(!currentChars.Contains(s[j]))
                {
                    currentChars.Add(s[j]);
                    j++;
                }
                else
                {
                    longestSubstringLength = Math.Max(longestSubstringLength, currentChars.Count);
                    currentChars.Remove(s[i]);
                    i++;
                }
            }

            return Math.Max(longestSubstringLength, currentChars.Count);
        }      
    }
}
