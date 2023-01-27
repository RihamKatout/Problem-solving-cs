using System;

class A110
{
    public static void Main()
    {
        //https://codeforces.com/contest/110/problem/A
        string input = Console.ReadLine();
        int cnt = 0;
        foreach (char i in input)
        {
            if (i == '4' || i == '7') cnt++;
        }
        Console.WriteLine(isLucky(cnt) ? "YES" : "NO");
    }

    public static bool isLucky(int n)
    {
        if (n == 0) return false;
        while (n != 0)
        {
            if (n % 10 != 4 && n % 10 != 7) return false;
            n /= 10;
        }
        return true;
    }
}