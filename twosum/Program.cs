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
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        foreach (var (i, n) in nums.Select((a, i) => (i, a)))
        {
            var searching = target - n;
            if (map.TryGetValue(searching, out int j))
                return [i, j];
            map[n] = i;
        }
        return [];
    }
}
