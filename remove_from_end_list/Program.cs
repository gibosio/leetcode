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
    Given the head of a linked list, remove the nth node from the end of the list and return its head.
*/

namespace removeFromEndOfList;


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}


public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var map = new Dictionary<int, ListNode>();
        int size = 0;
        for (var current = head; current != null; current = current.next)
        {
            map.TryAdd(size, current);
            size += 1;
        }
        var nodeToRemove = size - n;
        if (nodeToRemove <= 0)
        {   //first element
            return head.next;
        }
        else if (map.TryGetValue(nodeToRemove - 1, out var previous))
        {
            previous.next = previous.next?.next;
        }
        else
        {
            return new();
        }
        return head;
    }
    public ListNode? RemoveNthFromEnd_v2(ListNode head, int n)
    {   //idea: moving a pointer until end. Start to move a second pointer only after n movement of the end pointer
        var currentMinusN = head;
        for(var current = head; current != null; current = current.next)
        {
            if(n > 0)
            {
                n--;
            } else
            {
                currentMinusN = currentMinusN?.next;
            }
        }
        currentMinusN?.next = currentMinusN.next?.next;
        return head;
    }
}

class Program
{
    static void Main()
    {
        var solution = new Solution();
        // var list = new ListNode(1, new(2, new(3, new(4, new(5)))));
        var list = new ListNode(1, new(2, null));
        PrintList(list);
        list = solution.RemoveNthFromEnd(list, 2);
        PrintList(list);
    }
    static void PrintList(ListNode head)
    {
        Console.WriteLine("printing");
        for (var current = head; current != null; current = current.next)
        {
            Console.WriteLine(current.val);
        }
    }

}


