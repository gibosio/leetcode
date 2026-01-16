

/*
There is a large (m - 1) x (n - 1) rectangular field with corners at (1, 1) and (m, n) containing some horizontal and vertical fences given in arrays hFences and vFences respectively.
Horizontal fences are from the coordinates (hFences[i], 1) to (hFences[i], n) and vertical fences are from the coordinates (1, vFences[i]) to (m, vFences[i]).
Return the maximum area of a square field that can be formed by removing some fences (possibly none) or -1 if it is impossible to make a square field.
Since the answer may be large, return it modulo 109 + 7.
Note: The field is surrounded by two horizontal fences from the coordinates (1, 1) to (1, n) and (m, 1) to (m, n) and two vertical fences from the coordinates (1, 1) to (m, 1) and (1, n) to (m, n). These fences cannot be removed.
*/

using System.Reflection.Metadata;

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
public class Solution
{
    private readonly static int MOD = 1000000000 + 7;
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences)
    {
        hFences = [1, .. hFences, m];
        vFences = [1, .. vFences, n];
        Array.Sort(hFences);
        Array.Sort(vFences);
        HashSet<int> heights = [];
        for (int i = 0; i < hFences.Length; i++)
            for (int j = i + 1; j < hFences.Length; j++)
                heights.Add(hFences[j] - hFences[i]);

        var maxSide = -1;
        for (var i = 0; i < vFences.Length; i++)
            for (var j = 0; j < i; j++)
            {
                int width = vFences[i] - vFences[j];
                if (heights.Contains(width))
                    maxSide = Math.Max(maxSide, width);
            }

            
        if (maxSide == -1)
            return -1;

        return (int)((long)maxSide * maxSide % MOD);
    }
}