using System;

namespace LeetCodeSolutions
{
    public partial class Solution
    {
        /// <summary>
        /// On a plane there are n points with integer coordinates points[i] = [xi, yi]. 
        /// Your task is to find the minimum time in seconds to visit all points.
        /// 
        /// You can move according to the next rules:
        /// In one second always you can either move vertically, horizontally by one unit or diagonally (it means to move one unit vertically and one unit horizontally in one second).
        /// You have to visit the points in the same order as they appear in the array.
        /// </summary>
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int result = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                var startPoint = points[i];
                var finalPoint = points[i + 1];

                result += Math.Max(Math.Abs(finalPoint[0] - startPoint[0]), Math.Abs(finalPoint[1] - startPoint[1]));
            }

            return result;
        }
    }
}