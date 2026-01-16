/*
You are given a 2D integer array squares. Each squares[i] = [xi, yi, li] represents the coordinates of the bottom-left point and the side length of a square parallel to the x-axis.
Find the minimum y-coordinate value of a horizontal line such that the total area of the squares above the line equals the total area of the squares below the line.
Answers within 10-5 of the actual answer will be accepted.
Note: Squares may overlap. Overlapping areas should be counted multiple times.
*/


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
    public double SeparateSquares(int[][] squares)
    {
        return SeparateSquares_3(squares);
    }
    private double SeparateSquares_3(int[][] squares)
    {
        double maxHeight = double.MinValue, minHeight = double.MaxValue, totalArea = 0;
        foreach (var square in squares)
        {
            double y = square[1];
            double l = square[2];
            totalArea += square[2] * square[2];
            maxHeight = double.Max(maxHeight, y + l);
            minHeight = double.Min(minHeight, y);
        }
        var targetArea = totalArea / 2.0;

        double mean = 0;
        for (var i = 0; i < 100; i++)
        {
            mean = (maxHeight + minHeight) / 2.0;
            var (areaAbove, areaBelow) = AreaAboveAndBelow(squares, mean);
            if (areaAbove > areaBelow)
                minHeight = mean;
            else
                maxHeight = mean;
        }

        return mean;
    }
    private double SeparateSquares_1(int[][] squares)
    {
        if (squares.Length < 2
            || squares[0].Length < 3
            || squares[1].Length < 3)
            return 0;
        var (x1, y1, l1) = (squares[0][0], squares[0][1], squares[0][2]);
        var (x2, y2, l2) = (squares[1][0], squares[1][1], squares[1][2]);
        double maxHeight = Math.Max(y1 + l1, y2 + l2);
        double minHeight = Math.Min(y1, y2);
        double mean = 0;
        for (var i = 0; i < 100; i++)
        {
            mean = (maxHeight + minHeight) / 2;
            var (areaAbove, areaBelow) = AreaAboveAndBelow(squares, mean);
            if (areaAbove > areaBelow)
                minHeight = mean;
            else
                maxHeight = mean;
        }

        return mean;
    }
    private double SeparateSquares_2(int[][] squares)
    {
        if (squares.Length < 2
            || squares[0].Length < 3
            || squares[1].Length < 3)
            return 0;
        var (x1, y1, l1) = (squares[0][0], squares[0][1], squares[0][2]);
        var (x2, y2, l2) = (squares[1][0], squares[1][1], squares[1][2]);
        double maxHeight = Math.Max(y1 + l1, y2 + l2);
        double minHeight = Math.Min(y1, y2);
        double mean, areaAbove, areaBelow;
        do
        {
            mean = (maxHeight + minHeight) / 2;
            (areaAbove, areaBelow) = AreaAboveAndBelow(squares, mean);
            if (areaAbove > areaBelow)
                minHeight = mean;
            else
                maxHeight = mean;
        } while (Math.Abs(areaAbove - areaBelow) > 0.00001); ;

        return mean;
    }
    private static (double, double) AreaAboveAndBelow(int[][] squares, double separator)
    {
        double areaAbove = 0;
        double areaBelow = 0;
        foreach (var square in squares)
        {
            var (y, l) = (square[1], square[2]);
            if (separator <= y)
                areaAbove += l * l;
            else if (separator >= y + l)
                areaBelow += l * l;
            else
            {
                areaBelow += l * (separator - y);
                areaAbove += l * (y + l - separator);
            }
        }
        return (areaAbove, areaBelow);
    }
}