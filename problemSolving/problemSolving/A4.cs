using System;
using System.IO;

namespace P4A
{
    //https://codeforces.com/contest/4/problem/A
    class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 2 || x % 2 == 1) Console.WriteLine("NO\n");
            else Console.WriteLine("YES\n");
        }
    }
}