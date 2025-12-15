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
You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.*/


/**
 * Definition for singly-linked list.*/
public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}
public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var headRet = new ListNode();
        var current = headRet;
        ListNode[] heads = lists;
        // while (FindIndexOfMinHead(heads) is int minIndex)
        while (FindIndexOfMinHead_v2(heads) is int minIndex)
        {
            current.next = heads[minIndex];
            heads[minIndex] = heads[minIndex]?.next;
            current = current.next;
        }
        return headRet.next;
    }
    static int? FindIndexOfMinHead(ListNode[] lists)
    {
        (var minSoFar, int? index) = (int.MaxValue, null);
        foreach (var (head, h_index) in lists.Select((h, i) => (h, i)).Where(h => h.h is not null))
        {
            if (head?.val < minSoFar)
                (minSoFar, index) = (head.val, h_index);
        }

        return index;
    }
    static int? FindIndexOfMinHead_v2(ListNode[] lists)
    {
        int min = int.MaxValue;
        int? index = null;

        for (int i = 0; i < lists.Length; i++)
        {
            var node = lists[i];
            if (node is null) continue;

            if (node.val < min)
            {
                min = node.val;
                index = i;
            }
        }

        return index;
    }
}