using System;

class B499
{
    //https://codeforces.com/contest/499/problem/B
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]), n2 = int.Parse(input[1]);
        Dictionary<string, string> map = new Dictionary<string, string>();
        while (n2-- != 0)
        {
            input = Console.ReadLine().Split(' ');
            string z = input[0], x = input[1];
            if (x.Length < z.Length)
            {
                map[z] = x;
                map[x] = x;
            }
            else
            {
                map[x] = z;
                map[z] = z;
            }
        }

        input = Console.ReadLine().Split(' ');
        foreach (string i in input)
        {
            Console.Write(map[i] + " ");
        }
        Console.WriteLine();
    }
}