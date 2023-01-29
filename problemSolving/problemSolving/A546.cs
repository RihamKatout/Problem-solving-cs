using System;
using System.IO;

namespace codeforces
{
    //https://codeforces.com/contest/546/problem/A
    class P546A
    {
        //soldier and bananas
        public static void Main(string[] args)
        {
            string[] input = (Console.ReadLine()).Split(' ');
            long k = int.Parse(input[0]), w = int.Parse(input[1]), n = int.Parse(input[2]);
            Console.WriteLine(Math.Max(0, k * n * (n + 1) / 2 - w) + "\n");
        }
    }
}