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
    public bool IsMatch(string s, string p)
    {
        return IsMatch_rec(s, p, 0, 0);
    }
    bool IsMatch_rec(string s, string p, int i_s, int i_p)
    {
        if (i_p >= p.Length)
            return i_s >= s.Length;

        bool match = (i_s < s.Length) && (p[i_p] == s[i_s] || p[i_p] == '.');
        bool isNextStar = (i_p + 1 < p.Length) && (p[i_p + 1] == '*');

        if (isNextStar)
            // 0 occurencies or 1+ occurencies
            return IsMatch_rec(s, p, i_s, i_p + 2) || (match && IsMatch_rec(s, p, i_s + 1, i_p));
        else
            return match && IsMatch_rec(s, p, i_s + 1, i_p + 1);
    }

}
