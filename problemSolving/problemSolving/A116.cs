using System;

public class HelloWorld
{
    //https://codeforces.com/contest/116/problem/A
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()), max = 0, counter = 0;
        while (n-- != 0)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);
            counter -= a - b;
            max = Math.Max(counter, max);
        }
        Console.WriteLine(max);
    }
}