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

/**
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.
*/

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
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var (current1, current2) = (list1, list2);
        var retList = new ListNode() ;
        var currentRetList = retList;
        while( current1 != null && current2 != null)
        {
            if (current1.val < current2.val)
            {
                currentRetList.next = new(current1.val) ;
                current1 = current1.next;
            } else
            {
                currentRetList.next = new(current2.val) ;
                current2 = current2.next;
            }
            currentRetList = currentRetList.next;
        }
        var lastItems = current1 is null ? current2 : current1;
        while (lastItems != null)
        {
            currentRetList.next = new(lastItems.val);
            currentRetList = currentRetList.next;
            lastItems = lastItems.next;
        }
        return retList.next;
    }
}
