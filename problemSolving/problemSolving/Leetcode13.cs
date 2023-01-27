public class Solution13
{
    //https://leetcode.com/problems/roman-to-integer/
    public int RomanToInt(string s)
    {
        int answer = 0;
        Dictionary<char, int> m = new Dictionary<char, int>();
        m['I'] = 1;
        m['V'] = 5;
        m['X'] = 10;
        m['L'] = 50;
        m['C'] = 100;
        m['D'] = 500;
        m['M'] = 1000;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == 'I')
            {
                if (s[i + 1] == 'V' || s[i + 1] == 'X') answer--;
                else answer++;
            }
            else if (s[i] == 'X')
            {
                if (s[i + 1] == 'L' || s[i + 1] == 'C') answer -= 10;
                else answer += 10;
            }
            else if (s[i] == 'C')
            {
                if (s[i + 1] == 'D' || s[i + 1] == 'M') answer -= 100;
                else answer += 100;
            }
            else answer += m[s[i]];
        }
        answer += m[s[s.Length - 1]];
        return answer;
    }
}