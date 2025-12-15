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

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var merged_lenght = nums1.Length + nums2.Length;
        if (merged_lenght % 2 == 0) {  // even/pari
            int i1 = 0;
            int i2 = 0;
            int target = merged_lenght / 2 ;
            int ret = 0;
            while (i1+i2 < target)
            {
                if (nums1[i1] < nums2[i2])
                {
                    i1++;
                }
                else 
                    i2++;
            }
        }

    }
}
