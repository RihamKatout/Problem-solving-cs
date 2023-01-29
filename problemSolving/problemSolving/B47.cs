using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolving
{
    internal class B47
    {
        //https://codeforces.com/problemset/problem/47/B
        public static void Main(string[] args)
        {
            string x;
            Dictionary<char, int> m = new();
            for (int i = 0; i < 3; i++) m.Add((char)(i + 65), 0);
            for (int t = 0; t < 3; t++)
            {
                x = Console.ReadLine();
                if (x[1] == '<') m[x[2]]++;
                else m[x[0]]++;
            }
            int flag1 = 0, flag2 = 0;
            char []arr = new char[3];
            for (int i = 0; i < 3; i++)
            {
                if (m[(char)(i + 65)] == 1)
                {
                    flag1++;
                }

                if (m[(char)(i + 65)] == 2) flag2++;
                arr[m[(char)(i + 65)]] = (char)(i + 65);
            }
            if (flag1 == 1 && flag2 == 1) foreach (var i in arr) Console.Write(i);
            else Console.Write("Impossible");
            Console.WriteLine();
        }
    }
}
