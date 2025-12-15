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
    public int MyAtoi(string s)
    {
        var ret = 0;
        var sign = 1;
        s = s.Trim();
        if (s.Length == 0)
        {
            return 0;
        }
        switch (s[0])
        {
            case '+':
                s = s[1..];
                break;
            case '-':
                sign = -1;
                s = s[1..];
                break;
            default:
                if (CharToInt(s[0]) is null)
                    return 0;
                break;
        }
        foreach (var c in s)
        {
            if (CharToInt(c) is int value)
            {
                if (ret > (int.MaxValue - value) / 10)
                    return sign < 0 ? int.MinValue : int.MaxValue;
                ret = ret * 10 + value;
            }
            else
            {
                return ret * sign;
            }
        }
        return ret * sign;
    }
    static int? CharToInt(char c) => c switch
    {
        '0' => 0,
        '1' => 1,
        '2' => 2,
        '3' => 3,
        '4' => 4,
        '5' => 5,
        '6' => 6,
        '7' => 7,
        '8' => 8,
        '9' => 9,
        _ => null,
    };
}



