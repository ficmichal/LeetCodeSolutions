using System.Linq;

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// If there is no common prefix, return an empty string "".
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            int i = 0;
            char iLetter;
            var firstString = strs[0];
            var firstStringLength = firstString.Length;
            var numberOfStrings = strs.Length;
            var stringLength = strs.Select(x => x.Length).ToArray();
            for (; i < firstStringLength; i++)
            {
                iLetter = strs[0][i];
                for (int j = 1; j < numberOfStrings; j++)
                {
                    if (i == stringLength[j] || iLetter != strs[j][i])
                    {
                        return firstString.Substring(0, i);
                    }
                }
            }

            return firstString;
        }
    }
}