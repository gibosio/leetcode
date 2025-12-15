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
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
*/
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var solutions = new List<string>();
        GenerateParenthesis_bk(n - 1, n, "(", solutions);
        return solutions;
    }
    public static void GenerateParenthesis_bk(int open, int closed, string currentSolution, IList<string> solutions)
    {
        if (closed <= 0 && open <= 0)
        {
            solutions.Add(currentSolution);
            return;
        }
        if (open > 0)
            GenerateParenthesis_bk(open - 1, closed, currentSolution + '(', solutions);
        if (closed > open)
            GenerateParenthesis_bk(open, closed - 1, currentSolution + ')', solutions);

    }
}