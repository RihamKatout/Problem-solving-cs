public class Solution
{
    //https://leetcode.com/problems/climbing-stairs/description/
    private Dictionary<int, int> d = new();
    public int ClimbStairs(int n)
    {
        d[0] = 0;
        d[1] = 1;
        d[2] = 2;
        if (n <= 2) return n;
        else
        {
            if (d.ContainsKey(n) == false)
            {
                d[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            }
            return d[n];
        }
    }
}