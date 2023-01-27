public class Solution20
{
    //https://leetcode.com/problems/valid-parentheses/
    public bool IsValid(string str)
    {
        Stack<char> s = new Stack<char>();

        foreach (char i in str)
        {
            if (i == '(' || i == '[' || i == '{') s.Push(i);
            else
            {
                if (s.Count == 0) return false;
                if (i == ')' && s.Peek() == '(') s.Pop();
                else if (i == ']' && s.Peek() == '[') s.Pop();
                else if (i == '}' && s.Peek() == '{') s.Pop();
                else return false;
            }
        }
        if (s.Count == 0) return true;
        return false;
    }
}