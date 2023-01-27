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
public class Solution
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/
    public ListNode DeleteDuplicates(ListNode head)
    {
        int last = 101, flag = 0;
        if (head == null) return null;
        ListNode ans = new();
        ListNode tmp = new();

        while (head != null)
        {
            if (last != head.val)
            {
                if (flag == 0)
                {
                    ans.val = head.val;
                    tmp = ans;
                    flag = 1;
                }
                else
                {
                    tmp.next = new(head.val);
                    tmp = tmp.next;
                }
                last = head.val;
            }
            head = head.next;
        }
        return ans;
    }
}