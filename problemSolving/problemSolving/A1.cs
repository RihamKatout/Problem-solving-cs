using System;

class A1
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        long n = int.Parse(input[0]), m = int.Parse(input[1]), a = int.Parse(input[2]);
        Console.WriteLine((n / a + (n % a == 0 ? 0 : 1)) * (m / a + (m % a == 0 ? 0 : 1)));
    }
}