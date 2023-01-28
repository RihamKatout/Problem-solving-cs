using System;
using System.IO;

namespace codeforces
{
    //https://codeforces.com/contest/59/problem/A
    class P59A
    {
        //soldier and bananas
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sC = 0, cC = 0;
            foreach (char i in input)
            {
                if (i >= 'a' && i <= 'z') sC++;
                else cC++;
            }
            if (sC >= cC) input = input.ToLower();
            else input = input.ToUpper();
            Console.WriteLine(input);
        }
    }
}