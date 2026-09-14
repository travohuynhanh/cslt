using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session_6
{
    internal class ex06
    {
        static int Max(int a, int b, int c) 
        {
            int max = a;
            if (max < b) { max = b; }
            if (max < c) { max = c; }
            return max;
        }
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i<=n;  i++)
            {
                result = result* i;
            }
            return result;
        }
        static bool IsPrime (int n)
        {
            if (n<2)
            {
                return false;
            }
            for (int i = 2; i<n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static 

    }
}
