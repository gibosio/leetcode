/*
On a 2D plane, there are n points with integer coordinates points[i] = [xi, yi]. Return the minimum time in seconds to visit all the points in the order given by points.

You can move according to these rules:

    In 1 second, you can either:
        move vertically by one unit,
        move horizontally by one unit, or
        move diagonally sqrt(2) units (in other words, move one unit vertically then one unit horizontally in 1 second).
    You have to visit the points in the same order as they appear in the array.
    You are allowed to pass through points that appear later in the order, but these do not count as visits.
                Input: points = [[1,1],[3,4],[-1,0]]
                Output: 7
                Explanation: One optimal path is [1,1] -> [2,2] -> [3,3] -> [3,4] -> [2,3] -> [1,2] -> [0,1] -> [-1,0]   
                Time from [1,1] to [3,4] = 3 seconds 
                Time from [3,4] to [-1,0] = 4 seconds
                Total time = 7 seconds
*/


/**
*    leetcode exercise
*    Copyright (C) 2025  GB

*    This program is free software: you can redistribute it and/or modify
*    it under the terms of the GNU General Public License as published by
*    the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.

*    This program is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU General Public License for more details.

*    You should have received a copy of the GNU General Public License
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.
**/
// public class Solution
// {
//     public int MinTimeToVisitAllPoints(int[][] points)
//     {
//         var count = 0;
//         for (int i = 1; i < points.Length; i++)
//         {
//             var (x1, y1) = (points[i - 1][0], points[i - 1][1]);
//             var (x2, y2) = (points[i][0], points[i][1]);
//             while ((x1, y1) != (x2, y2))
//             {
//                 count += 1;
//                 if (x1 == x2)
//                 {
//                     if (y1 > y2)
//                         y1--;
//                     else
//                         y1++;
//                 }
//                 else if (y1 == y2)
//                 {
//                     if (x1 > x2)
//                         x1--;
//                     else
//                         x1++;
//                 }
//                 else if (x1 > x2)
//                 {
//                     x1--;
//                     if (y1 > y2)
//                         y1--;
//                     else
//                         y1++;
//                 }
//                 else
//                 {
//                     x1++;
//                     if (y1 > y2)
//                         y1--;
//                     else
//                         y1++;

//                 }
//             }

//         }
//         return count;

//     }
// }


public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int time = 0;

        for (int i = 1; i < points.Length; i++)
        {
            int dx = Math.Abs(points[i][0] - points[i - 1][0]);
            int dy = Math.Abs(points[i][1] - points[i - 1][1]);
            time += Math.Max(dx, dy);
        }

        return time;
    }
}