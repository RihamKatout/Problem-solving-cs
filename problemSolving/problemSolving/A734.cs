using System;

class A734
{
    //https://codeforces.com/contest/734/problem/A
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int cnt1 = 0, cnt2 = 0;
        foreach (char i in input)
        {
            if (i == 'A') cnt1++;
            else cnt2++;
        }
        Console.WriteLine(((cnt1 == cnt2) ? "Friendship" : (cnt1 > cnt2 ? "Anton" : "Danik")));
    }
}