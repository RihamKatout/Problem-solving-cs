using System;

class A69
{
    public static void Main()
    {
        //https://codeforces.com/contest/69/problem/A
        int n = int.Parse(Console.ReadLine()), cnt1 = 0, cnt2 = 0, cnt3 = 0;
        while (n-- != 0)
        {
            string[] input = Console.ReadLine().Split(' ');
            cnt1 += int.Parse(input[0]);
            cnt2 += int.Parse(input[1]);
            cnt3 += int.Parse(input[2]);
        }
        Console.WriteLine((cnt1 == 0 && cnt2 == 0 && cnt3 == 0) ? "YES" : "NO");
    }
}