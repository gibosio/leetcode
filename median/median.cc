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
**

#include <vector>
using namespace std;

class Solution {
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        vector<int> merged = merge(nums1, nums2);
        int m = merged.size();
        if (m % 2 == 0) {
            return (merged[m/2 - 1] + merged[m/2]) / 2.0;
        } else {
            return merged[m / 2];
        }
    }

    vector<int> merge(const vector<int>& nums1, const vector<int>& nums2) {
        vector<int> merged;
        int i1 = 0, i2 = 0;
        while (i1 < nums1.size() && i2 < nums2.size()) {
            if (nums1[i1] < nums2[i2]) merged.push_back(nums1[i1++]);
            else merged.push_back(nums2[i2++]);
        }
        while (i1 < nums1.size()) merged.push_back(nums1[i1++]);
        while (i2 < nums2.size()) merged.push_back(nums2[i2++]);
        return merged;
    }
};
