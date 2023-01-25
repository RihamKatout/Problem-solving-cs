using System;

class A41
{
    public static void Main()
    {
        //https://codeforces.com/contest/41/problem/A
        string input1 = Console.ReadLine(), input2 = Console.ReadLine();
        input2 = new string(input2.Select(c => c).Reverse().ToArray());
        Console.WriteLine(input1.Equals(input2) ? "YES" : "NO");
    }
}