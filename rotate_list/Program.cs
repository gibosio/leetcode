/*
Given the head of a linked list, rotate the list to the right by k places.
Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
**/

namespace rotate_list;


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
public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}


public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
            return head;
        // calculate list lenght and taking last node
        var size = 1;
        var lastNode = head;
        for (; lastNode.next != null; lastNode = lastNode.next)
            size += 1;

        // k = k % list_lenght;
        k %= size;
        if (k == 0)
            return head;

        /// make it circular
        lastNode.next = head;
        // *** first | ... | (k+1)from_end | k_from_end | ... | last | null   /***initially
        // // *** k_from_end | ... | last | first | ... | (k+1)from_end | null   /***after
        // // *** new_first                               new_last
        var newLastNode = head;
        for (int i = 0; i < size - k - 1; i++)
            newLastNode = newLastNode.next;

        var newFirstNode = newLastNode.next;
        newLastNode.next = null;
        return newFirstNode;
    }
}

