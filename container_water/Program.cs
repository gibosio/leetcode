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
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxSoFar = 0;
        while (left < right)
        {
            int width = right - left;
            int actualHeight = height[left] < height[right] ?
                            height[left++] : height[right--];
            int area = actualHeight * width ;
            maxSoFar = Math.Max(maxSoFar, area);
        }
        return maxSoFar;
    }
}
