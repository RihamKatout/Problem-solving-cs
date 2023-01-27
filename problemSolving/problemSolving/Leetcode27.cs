public class Solution
{
    //https://leetcode.com/problems/remove-element/description/
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0, last = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                k++;
                nums[i] = nums[last];
                nums[last] = -1;
                last--;
                i--;
            }
        }
        return nums.Length - k;
    }
}