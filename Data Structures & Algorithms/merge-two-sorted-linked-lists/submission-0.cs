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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        if(list1 ==null && list2 != null)
            return list2;
        if(list1 !=null && list2 == null)
            return list1;

        ListNode dummy = new ();
        ListNode node = dummy;

        while(list1 != null && list2 != null )
        {
            if(list1.val <= list2.val )
            {
                node.next = list1;
                list1=list1.next;
            }
            else
            {
                node.next = list2;
                list2 = list2.next;
            }

            node = node.next; // moving the pointer which points newly added node
        }

        if(list1 == null && list2 != null)
            node.next = list2;
        if(list1 !=null && list2 == null)
            node.next = list1;

        return dummy.next;
    }
}