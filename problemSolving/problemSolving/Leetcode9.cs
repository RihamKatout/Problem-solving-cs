public class Solution9
{
    //https://leetcode.com/problems/palindrome-number/
    public bool IsPalindrome(int x)
    {
        string xString = x.ToString();
        int mid = xString.Length / 2, size = xString.Length - 1;
        for (int i = 0; i < mid; i++)
        {
            if (xString[i] != xString[size - i]) return false;
        }
        return true;
    }
}