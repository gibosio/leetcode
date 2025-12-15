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

use std::collections::HashMap;

impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let mut map: HashMap<i32, usize>= HashMap::new();
        for (i, &n) in nums.iter().enumerate() {
            let searching = target - n;
            if let Some(&j) = map.get(&searching) {
                return vec![i.try_into().unwrap(), j.try_into().unwrap()];
            }
            map.insert(n, i);
        }
        vec![]
    }
}




struct Solution;
fn main() {
    let a = Solution::two_sum(vec![3,2,4], 6);
    dbg!(a);
}
