public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
 
public class Solution21
{
    //https://leetcode.com/problems/merge-two-sorted-lists/
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();
        ListNode tmp = head;
        while (list1 != null || list2 != null)
        {
            if (list1 != null)
            {
                if (list2 != null)
                {
                    ListNode newNode1 = new ListNode(list1.val);
                    ListNode newNode2 = new ListNode(list2.val);
                    if (newNode1.val > newNode2.val)
                    {
                        tmp.next = newNode2;
                        tmp = tmp.next;
                        list2 = list2.next;
                    }
                    else if (newNode1.val <= newNode2.val)
                    {
                        tmp.next = newNode1;
                        tmp = tmp.next;
                        list1 = list1.next;
                    }
                }
                else
                {
                    ListNode newNode = new ListNode(list1.val);
                    tmp.next = newNode;
                    tmp = tmp.next;
                    list1 = list1.next;
                }
            }
            else
            {
                ListNode newNode = new ListNode(list2.val);
                tmp.next = newNode;
                tmp = tmp.next;
                list2 = list2.next;
            }

        }
        return head.next;
    }
}