using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace problemSolving
{
    internal class E1790
    {
        public static long power(long a, long b)
        {
            long ret = 1, mod = 1000000007;
            while (b != 0)
            {
                if (b % 2 == 1) ret = ret * a % mod;
                a = a*a%mod;
                b >>= 1;
            }
            return ret%mod;
        }
        public static void Main(string[] arg)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- != 0)
            {
                long x = long.Parse(Console.ReadLine());
                if(x%2==1)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                int last = (int)(x % 2);
                x /= 2;
                List<int>a  = new();
                List<int>b = new();
                bool flag = false;
                while (x != 0 || last != 0) 
                {
                    if (last == 1 && (x % 2 == 1))
                    {
                        flag = true;
                        break;
                    }
                    if (x % 2 == 1)
                    {
                        a.Add(1);
                        b.Add(1);
                    }
                    else
                    {
                        a.Add(0);
                        b.Add(last);
                    }
                    last = (int)(x % 2);
                    x /= 2;
                }
                if(flag) {
                    Console.WriteLine(-1);
                }
                else
                {
                    long aN = 0, bN = 0;
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (a[i] != 0) aN += power(2, i);
                        if (b[i] != 0) bN += power(2, i);
                    }
                    Console.WriteLine($"{aN} {bN}");
                }
            }
        }
    }
}
