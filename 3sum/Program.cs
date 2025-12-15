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

/* Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets. */


public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var triplets = new List<IList<int>>();
        Array.Sort(nums);
        foreach (var (i, n) in nums.Select((n, i) => (i, n)))
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            if (n > 0) break;

            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = n + nums[left] + nums[right];
                switch (sum)
                {
                    case 0:
                        triplets.Add([n, nums[left], nums[right]]);
                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;

                        break;
                    case < 0:
                        left++;
                        break;
                    case > 0:
                        right--;
                        break;
                }
            }
        }
        return triplets;
    }
}
