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

public class Solution {
    public void ReorderList(ListNode head) {
        
        ListNode slow = head; 
        ListNode fast = head;
        ListNode second = null;

        //Find the middle and generate two listNodes
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

        }
        second = slow.next; //The loop stop in the middle & the next element will be the head of 2nd listnodes 
        slow.next = null; // Split the nodelist by setting null to end of 1st listNodes
        ListNode prev = null;

        //Reversing the second List nodes        
        while(second != null)
        {   
            ListNode next =  second.next;
            second.next = prev;
            prev = second;
            second = next;
        }
        


        //Patching the two list elements.
        ListNode first = head;
        ListNode secondHalf = prev;
        while(secondHalf != null)
        {
            ListNode fpNext = first.next;
            ListNode spNext = secondHalf.next;

            first.next = secondHalf;
            first.next.next = fpNext;

            first = fpNext;
            secondHalf = spNext;
        }


    }
}