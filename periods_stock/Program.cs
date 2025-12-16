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

/*
You are given an integer array prices representing the daily price history of a stock, where prices[i] is the stock price on the ith day.

A smooth descent period of a stock consists of one or more contiguous days such that the price on each day is lower than the price on the preceding day by exactly 1. The first day of the period is exempted from this rule.

Return the number of smooth descent periods.
*/

public class Solution
{
    public long GetDescentPeriods_v1(int[] prices)
    {
        if (prices.Length == 1)
            return 1;

        uint first = 0, second = 1;
        uint sumSoFar = 0;
        while (second < prices.Length)
        {
            if (prices[first] - prices[second] == second - first)
            {
                second++;
            }
            else
            {
                uint lenght = second - first;
                sumSoFar += lenght * (lenght + 1) / 2;
                first = second;
                second = first + 1;
            }
        }
        uint lastLenght = second - first;
        sumSoFar += lastLenght * (lastLenght + 1) / 2;

        return sumSoFar;
    }
    public long GetDescentPeriods(int[] prices) {
        if (prices.Length == 0)
            return 0;

        long sumSoFar = 1; 
        long currentLenght = 1; 

        for (int i = 1; i < prices.Length; i++) {
            if (prices[i-1] - prices[i] == 1) {
                currentLenght++;
            } else {
                currentLenght = 1; 
            }
            sumSoFar += currentLenght;
        }

        return sumSoFar;
    }
}

