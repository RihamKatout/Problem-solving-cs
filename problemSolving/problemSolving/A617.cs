using System;

class A617
{
    //https://codeforces.com/contest/617/problem/A
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine()), answer = 0;
        if (x >= 5)
        {
            answer += x / 5;
            x = x % 5;
        }
        if (x >= 4)
        {
            answer += x / 4;
            x = x % 4;
        }
        if (x >= 3)
        {
            answer += x / 3;
            x = x % 3;
        }
        if (x >= 2)
        {
            answer += x / 2;
            x = x % 2;
        }
        answer += x;
        Console.WriteLine(answer);
    }
}