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
