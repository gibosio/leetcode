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

/* Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters. */

using System.Text;

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        var strings = new List<string>();
        LetterCombinations_bk(digits, 0, new char[digits.Length], strings);
        return strings;
    }
    static void LetterCombinations_bk(string digits, int index, char[] currentSolution, IList<string> solutions)
    {
        if (index >= digits.Length)
        {
            solutions.Add(new(currentSolution));
            return;
        }
        var choices = GetChoice(digits[index]);
        foreach (var choice in choices)
        {
            currentSolution[index] = choice;
            LetterCombinations_bk(digits, index + 1, currentSolution, solutions);
        }
    }
    static char[] GetChoice(char n)
    {
        return n switch
        {
            '2' => ['a', 'b', 'c'],
            '3' => ['d', 'e', 'f'],
            '4' => ['g', 'h', 'i'],
            '5' => ['j', 'k', 'l'],
            '6' => ['m', 'n', 'o'],
            '7' => ['p', 'q', 'r', 's'],
            '8' => ['t', 'u', 'v'],
            '9' => ['w', 'x', 'y', 'z'],
            _ => []
        };
    }
}
