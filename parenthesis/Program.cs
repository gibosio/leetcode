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
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.

*/



public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var p in s)
        {
            switch (p)
            {
                case '(' or '[' or '{':
                    stack.Push(p);
                    break;
                case ')' or ']' or '}':
                    if (!stack.TryPop(out var open))
                        return false;
                    if ((open == '(' && p != ')') ||
                        (open == '[' && p != ']') ||
                        (open == '{' && p != '}'))
                        return false;
                    break;
            }
        }
        if (stack.Count <= 0)
            return true;
        else
            return false;
    }
}
