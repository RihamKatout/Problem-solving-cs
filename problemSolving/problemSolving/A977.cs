using System;

class A977
{
    public static void Main()
    {
        //https://codeforces.com/contest/977/problem/A
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]), k = int.Parse(input[1]);
        while (k-- != 0)
        {
            if (n % 10 == 0) n /= 10;
            else n--;
        }
        Console.WriteLine(n);
    }
}