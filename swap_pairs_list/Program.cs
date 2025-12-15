

/*
Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)*/


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
**//**
  Definition for singly-linked list.*/
public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}


public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head is null || head.next is null)
            return head;

        var dummy = new ListNode(0, head);
        var prev = dummy;

        while (prev.next is ListNode first && first.next is ListNode second)
        {
            // swap
            first.next = second.next;
            second.next = first;
            prev.next = second;

            // move forward
            prev = first;
        }

        return dummy.next;
    }

}
