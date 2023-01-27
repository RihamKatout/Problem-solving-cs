public class Solution1
{
    //https://leetcode.com/problems/two-sum/
    public int[] TwoSum(int[] nums, int target)
    {
        int[] answer = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int t = i + 1; t < nums.Length; t++)
            {
                if (nums[i] + nums[t] == target)
                {
                    answer[0] = i;
                    answer[1] = t;
                    return answer;
                }
            }
        }
        return answer;
    }
}