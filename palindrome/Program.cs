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

using System.Runtime.ExceptionServices;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if (x < 10)
            return true;
            var (firstDigit, rest) = ExtractAndRemoveFirstDigit(x);
        return firstDigit == x%10 && IsPalindrome(rest/10) ;
    }

    (int firstDigit, int rest) ExtractAndRemoveFirstDigit(int n)
{
    bool isNegative = n < 0;
    n = Math.Abs(n);

    if (n == 0)
        return (0, 0);

    int digits = (int)Math.Log10(n);
    int divisor = (int)Math.Pow(10, digits);

    int firstDigit = n / divisor;
    int rest = n % divisor;

    if (isNegative)
        rest = -rest;

    return (firstDigit, rest);
}
}
