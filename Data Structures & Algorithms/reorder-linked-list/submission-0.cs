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

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

        }


        second = slow.next;
        slow.next = null;
        ListNode prev = null;

        if(second != null )
        Console.WriteLine($"second : {second.val}");
        
        while(second != null)
        {   
            ListNode next =  second.next;
            second.next = prev;
            prev = second;
            second = next;
        }



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
