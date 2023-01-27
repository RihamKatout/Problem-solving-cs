
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution2
{
    //https://leetcode.com/problems/add-two-numbers/description/
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode ans = new();
        ListNode tmp = new();
        int carry = 0, flag = 0;
        while (l1 != null || l2 != null)
        {
            int a = 0, b = 0;
            if (l1 != null)
            {
                a = l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                b = l2.val;
                l2 = l2.next;
            }
            a += b + carry;
            carry = a / 10;
            if (flag == 0)
            {
                ans = new(a % 10);
                tmp = ans;
                flag = 1;
            }
            else
            {
                tmp.next = new(a % 10);
                tmp = tmp.next;
            }
        }
        if (carry != 0)
        {
            tmp.next = new(carry);
        }
        return ans;
    }
}