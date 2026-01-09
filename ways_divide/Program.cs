

/*
Along a long library corridor, there is a line of seats and decorative plants. You are given a 0-indexed string corridor of length n consisting of letters 'S' and 'P' where each 'S' represents a seat and each 'P' represents a plant.

One room divider has already been installed to the left of index 0, and another to the right of index n - 1. Additional room dividers can be installed. For each position between indices i - 1 and i (1 <= i <= n - 1), at most one divider can be installed.

Divide the corridor into non-overlapping sections, where each section has exactly two seats with any number of plants. There may be multiple ways to perform the division. Two ways are different if there is a position with a room divider installed in the first way but not in the second way.

Return the number of ways to divide the corridor. Since the answer may be very large, return it modulo 109 + 7. If there is no way, return 0.*/

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
namespace ways_divide;

public class Solution
{
    public int NumberOfWays(string corridor)
    {
        long count = 1;
        int plantCountBetweenSections = 0;
        int seatCount = 0;
        for (int i = 0; i < corridor.Length; i++)
        {
            if (corridor[i] == 'S')
            {
                seatCount += 1;
                if (seatCount > 2 && seatCount % 2 == 1)
                {
                    count = count * (plantCountBetweenSections + 1) % 1000000007;
                    plantCountBetweenSections = 0;
                }
            }
            else if (seatCount >= 2 && seatCount % 2 == 0)
                plantCountBetweenSections += 1;
        }

        if (seatCount < 2 || seatCount % 2 != 0)
            return 0;

        return (int)count;
    }
}