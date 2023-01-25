using System;

class A58
{
    public static void Main()
    {
        string input = Console.ReadLine(), hello = "hello";
        int index = 0;
        bool flag = false;
        foreach (char i in input)
        {
            if (i == hello[index])
            {
                index++;
                if (index == 5)
                {
                    flag = true;
                    break;
                }
            }
        }
        Console.WriteLine(flag ? "YES" : "NO");
    }
}