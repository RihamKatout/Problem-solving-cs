using System;

public class HelloWorld
{
    //https://codeforces.com/contest/96/problem/A
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if (input.IndexOf("0000000") == -1 && input.IndexOf("1111111") == -1)
            Console.WriteLine("NO");
        else
            Console.WriteLine("YES");
    }
}